using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Backend.Model;
using System.Collections.ObjectModel;

namespace AvaloniaUI;

public partial class ListEmployeeView : UserControl
{
    public ObservableCollection<EmployeeInfo> Employees { get; set; } = new ObservableCollection<EmployeeInfo>();
    public ListEmployeeView()
    {
        InitializeComponent();
    }

    public ListEmployeeView(ObservableCollection<EmployeeInfo> employees) : this()
    {
        Employees = employees;
        employeesListBox.ItemsSource = Employees;
    }
}