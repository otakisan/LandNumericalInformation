using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LandNumericalInformationApp.Extractors;

namespace LandNumericalInformationApp.Interactive
{
    public partial class LNIRailwayControl : UserControl
    {
        public LNIRailwayControl()
        {
            InitializeComponent();

        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ExtractStationLocation(this.filepathTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ExtractStationLocation(string filepath)
        {
            var extractor = new StationLocationExtractor();
            var results = extractor.Extract(filepath);

            this.TraceOutExtractResults(results);
        }

        private void TraceOutExtractResults(List<StationLocationExtractResult> results)
        {
            var builder = new StringBuilder();
            results.ForEach(extractResult =>
                {
                    builder
                        .AppendFormat("OperationCompany:{0}", extractResult.OperationCompany)
                        .AppendFormat(" RailwayLineName:{0}", extractResult.RailwayLineName)
                        .AppendFormat(" StationName:{0}", extractResult.StationName)
                        .AppendFormat(" Latitude:{0}", extractResult.Latitude)
                        .AppendFormat(" Longitude:{0}", extractResult.Longitude)
                        .AppendLine();
                });

            this.traceTextBox.Text = builder.ToString();
        }
    }
}
