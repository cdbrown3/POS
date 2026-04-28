namespace WinFormsUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            String[] argv;

            System.Console.WriteLine(System.Environment.GetCommandLineArgs().Length);
            argv = System.Environment.GetCommandLineArgs();
            ApplicationConfiguration.Initialize();
            if ((argv.Length == 2) && (String.Compare(argv[1], "/Manage_Login", true) == 0))
            {
                Application.Run(new MainLoginWindow());
            }
            else if ((argv.Length == 2) && (String.Compare(argv[1], "/Cook_Login", true) == 0))
            {
                Application.Run(new CookLoginWindow());
            }
            else if ((argv.Length == 2) && (String.Compare(argv[1], "/Kiosk_Login", true) == 0))
            {
                Application.Run(new KioskLoginWindow());
            }
        }
    }
}