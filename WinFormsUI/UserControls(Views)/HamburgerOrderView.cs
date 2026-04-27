using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class HamburgerOrderView : UserControl
    {
        MainWindow Instance;
        public HamburgerOrderView(MainWindow instance)
        {
            InitializeComponent();
            this.Instance = instance;
        }
        private void PattyCountUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BunCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BunCheckBox.Checked == true)
            {
                NoBunCheckBox.Checked = false;
            }
        }

        private void NoBunCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoBunCheckBox.Checked == true)
            {
                BunCheckBox.Checked = false;
            }
        }
    }
}
