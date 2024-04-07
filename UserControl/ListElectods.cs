using GeoProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoProject
{
    public partial class ListElectods : UserControl
    {
        public ListElectods()
        {
            InitializeComponent();
            ControlHelper.RoundControl(this, 15);
        }

        public void SetElectrode(ElectrodeModel electrode)
        {
            lblNameElectrod.Text = electrode.ElectrodeCoordinateId.ToString();
            lblCoords.Text = electrode.Coordinates;
            lblType.Text = electrode.ElectrodeType;
            lblMeaning.Text = electrode.Value.ToString();
            lblDate.Text = electrode.DateTime.ToString();
        }
    }
}
