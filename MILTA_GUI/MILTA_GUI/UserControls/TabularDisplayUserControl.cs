using MiltaCore;
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
    public partial class TabularDisplayUserControl : UserControl
    {
        public ShaftData Shaft { get; set; }
        public TabularDisplayUserControl()
        {
            InitializeComponent();
        }
    }
}
