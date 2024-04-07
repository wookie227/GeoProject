using GeoProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;

namespace GeoProject
{
    public partial class GraphicForm : Form
    {
        private List<ElectrodeModel> _electrodes;
        public GraphicForm(List<ElectrodeModel> electrodes)
        {
            InitializeComponent();

            _electrodes = electrodes;
            var sorted = _electrodes.OrderBy(e => e.DateTime);

            var plotModel = new PlotModel { Title = "График" };

            var series = new LineSeries();
            foreach (var e in sorted)
            {
                series.Points.Add(new OxyPlot.DataPoint(DateTimeAxis.ToDouble(e.DateTime), e.Value));
            }
            plotModel.Series.Add(series);

            plotView1.Model = plotModel;
        }
    }
}
