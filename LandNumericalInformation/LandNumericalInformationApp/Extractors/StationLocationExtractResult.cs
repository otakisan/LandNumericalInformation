using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandNumericalInformationApp.Extractors
{
    public class StationLocationExtractResult
    {
        public string RailwayLineName { get; set; }
        public string OperationCompany { get; set; }
        public string StationName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
