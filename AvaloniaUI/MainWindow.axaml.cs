using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Backend;

namespace AvaloniaUI
{
    //all windows will inherit MainWindow
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Icon = new WindowIcon("resources/app_icon.ico");
        }

        public String WelcomeText
        {
            get { return Model.getName() + " " + Controller.getName(); }
        }
    }
}