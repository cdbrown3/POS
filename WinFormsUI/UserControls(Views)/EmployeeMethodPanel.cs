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
    public partial class EmployeeMethodPanel : UserControl
    {
        MainWindow Instance;
        public EmployeeMethodPanel(MainWindow Instance)
        {
            InitializeComponent();
            this.Instance = Instance;
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            Instance.EditUser();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Instance.NewOrder();
        }
    }
}
