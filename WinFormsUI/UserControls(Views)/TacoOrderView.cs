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
    public partial class TacoOrderView : UserControl
    {
        MainWindow Instance;
        public TacoOrderView(MainWindow instance)
        {
            InitializeComponent();
            this.Instance = instance;
        }

        private void CornTortillaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CornTortillaCheckBox.Checked == true)
            {
                FlourCheckBox.Checked = false;
            }
        }

        private void FlourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FlourCheckBox.Checked == true)
            {
                CornTortillaCheckBox.Checked = false;
            }
        }
    }
}
