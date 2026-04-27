namespace WinFormsUI
{
    public partial class MainLoginWindow : Form
    {
        Title SelectedTitle;
        public MainLoginWindow()
        {
            InitializeComponent();
        }

        private void EmployeeViewButton_click(object sender, EventArgs e)
        {
            SelectedTitle = Title.Employee;
            new MainWindow(SelectedTitle).Show();
        }

        private void ManagerViewButton_Click(object sender, EventArgs e)
        {
            SelectedTitle = Title.Manager;
            new MainWindow(SelectedTitle).Show();
        }
    }
}
