using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class SubmitChangesPanel : UserControl
    {
        private MainWindow Need;
        public SubmitChangesPanel()
        {
            InitializeComponent();
        }
        public SubmitChangesPanel(MainWindow need)
        {
            InitializeComponent();
            this.Need = need;
        }
        private void SumbitChangesButton_Click(object sender, EventArgs e)
        {
            Need.SubmitChanges();
            Need.ReloadListBox();
        }
    }
}
