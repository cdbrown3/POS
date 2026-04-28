using Backend.Model;
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
    public partial class MenuItem : UserControl
    {
        MainWindow Instance;
        MenuItemInfo Item;
        public MenuItem(MainWindow instance, MenuItemInfo item)
        {
            InitializeComponent();
            this.Instance = instance;
            this.Item = item;
            MenuItemButton.Text = item.Name;
        }
        public void MenuItemButton_Click(object sender, EventArgs e)
        {
            Instance.SelectedMenuItem = this.Item;
            Instance.ispressed = true;
            Instance.LoadOrderPanel();
        }
    }
}
