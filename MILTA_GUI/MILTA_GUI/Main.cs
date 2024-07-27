using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MILTA_GUI
{
    public partial class Main : Form
    {
        miltaVTKControl miltaVTKControl;
        public Main()
        {
            InitializeComponent();
            InitVTKControl();
        }
        private void InitVTKControl()
        {
            miltaVTKControl = new miltaVTKControl();
            miltaVTKControl.Dock = DockStyle.Fill;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            drawingAreaSplitContainer.Panel1.Controls.Add(miltaVTKControl);

        }
    }
}
