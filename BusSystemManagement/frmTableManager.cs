using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusSystemManagement
{
    public partial class frmTableManager : Form
    {
        public frmTableManager()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbBusLineName.Text = "";
            nudFrequency.Value = 0;
            nudStartTime.Value = 0;
            nudEndTime.Value = 0;
            tbStartLocation.Text = "";
            tbEndLocation.Text = "";
            tbBusLineDetail.Text = "";
        }
    }
}
