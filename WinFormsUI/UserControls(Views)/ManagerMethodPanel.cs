using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI.UserControls_Views_
{
    public partial class ManagerMethodPanel : UserControl
    {
        MainWindow Instance;
        public ManagerMethodPanel()
        {
            InitializeComponent();
        }
        public ManagerMethodPanel(MainWindow Instance)
        {
            InitializeComponent();
            this.Instance = Instance;
        }

        private void EditEmployeeButton2_Click(object sender, EventArgs e)
        {
            Instance.EditUser();
        }
    }
}
