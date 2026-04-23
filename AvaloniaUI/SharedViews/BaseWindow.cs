using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;

namespace AvaloniaUI
{
    //Home to the minimum width and the icon...
    public class BaseWindow : Window
    {
        public BaseWindow()
        {
            Icon = new WindowIcon("Resources/Icons/app_icon.ico");

            Width = 1300;
            Height = 600;
            MinWidth = 1300;
            MinHeight = 600;
            Title = "POS";
        }
    }
}
