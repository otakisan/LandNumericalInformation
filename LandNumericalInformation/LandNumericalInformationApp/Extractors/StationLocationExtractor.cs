using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LandNumericalInformationApp.Extractors
{
    public class StationLocationExtractor
    {
        public List<StationLocationExtractResult> Extract(string filepath)
        {
            var xdoc = XDocument.Load(filepath);

            string ksjNS = @"http://nlftp.mlit.go.jp/ksj/schemas/ksj-app";
            string xlinkNS = @"http://www.w3.org/1999/xlink";
            string gmlNS = @"http://www.opengis.net/gml/3.2";

            var results = new List<StationLocationExtractResult>();
            xdoc.Root.Elements(XName.Get("Station", ksjNS)).Take(20).ToList().ForEach(ksjStationElement =>
                {
                    // 各種情報を取得
                    var extractResult = new StationLocationExtractResult();
                    extractResult.RailwayLineName = ksjStationElement.Element(XName.Get("railwayLineName", ksjNS)).Value;
                    extractResult.OperationCompany = ksjStationElement.Element(XName.Get("operationCompany", ksjNS)).Value;
                    extractResult.StationName = ksjStationElement.Element(XName.Get("stationName", ksjNS)).Value;

                    // Curve情報より座標を取得
                    var curveId = ksjStationElement.Element(XName.Get("location", ksjNS)).Attribute(XName.Get("href", xlinkNS)).Value.TrimStart('#');

                    var curveElement = xdoc.Root.Elements(XName.Get("Curve", gmlNS)).Where(element => element.Attribute(XName.Get("id", gmlNS)).Value == curveId).FirstOrDefault();
                    if(curveElement != null)
                    {
                        var posListElement = curveElement.Descendants(XName.Get("posList", gmlNS)).FirstOrDefault();
                        if(posListElement != null)
                        {
                            PushCoordinate(extractResult, posListElement);
                        }
                    }

                    results.Add(extractResult);
                });

            return results;
        }

        private void PushCoordinate(StationLocationExtractResult extractResult, XElement posListElement)
        {
            var coordinateStrings = posListElement.Value;
            var coordinatesTemp = coordinateStrings.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var coordinatesList = new List<string>();
            Array.ForEach(coordinatesTemp, line =>
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    coordinatesList.Add(line.Trim());
                }
            });
            var coordinates = coordinatesList.ToArray();

            double latitude = 0;
            double longitude = 0;
            if (coordinates.Length % 2 == 0)
            {
                var coordinateLeft = coordinates[(coordinates.Length / 2) - 1];
                var numericCoordinateLeft = ConvertToNumericCoordinate(coordinateLeft);

                var coordinateRight = coordinates[coordinates.Length / 2];
                var numericCoordinateRight = ConvertToNumericCoordinate(coordinateRight);

                latitude = (numericCoordinateLeft.Item1 + numericCoordinateRight.Item1) /2;
                longitude = (numericCoordinateLeft.Item2 + numericCoordinateRight.Item2) / 2;
            }
            else
            {
                var coordinate = coordinates[coordinates.Length / 2];
                var numericCoordinate = ConvertToNumericCoordinate(coordinate);

                latitude = numericCoordinate.Item1;
                longitude = numericCoordinate.Item2;
            }

            extractResult.Latitude = latitude;
            extractResult.Longitude = longitude;
        }

        private Tuple<double, double>ConvertToNumericCoordinate(string coordinate)
        {
            var coordinateElements = coordinate.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double latitude = double.Parse(coordinateElements[0]);
            double longitude = double.Parse(coordinateElements[1]);

            return Tuple.Create(latitude, longitude);
        }
    }
}
