using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using System;

namespace AvaloniaUI
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                //Decide which view to load.

                //get arguments from the command line...
                String[] args = Environment.GetCommandLineArgs();
                if ((args.Length == 2) && (String.Compare(args[1], "/login", true) == 0))
                {
                    desktop.MainWindow = new LoginWindow();
                }
                else if ((args.Length == 2) && (String.Compare(args[1], "/customerlogin", true) == 0))
                {
                    desktop.MainWindow = new CustomerLoginView();
                }
                else if ((args.Length == 2) && (String.Compare(args[1], "/cooklogin", true) == 0))
                {
                    desktop.MainWindow = new CookLoginWindow();
                }
                else
                {
                    Console.WriteLine("Error: Invalid switch");
                    Console.WriteLine("System: Starting with default view of server");
                    desktop.MainWindow = new LoginWindow();
                }
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}