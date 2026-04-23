using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AvaloniaUI;

public partial class EmployeeView : UserControl
{
    public EmployeeView()
    {
        InitializeComponent();
    }

    public List<Customer> Customers { get; set; } = new List<Customer>()
    {
        new Customer("Carson", "Brown", "256-486-5343")
    };
}

public class Customer
{
    //String fullname;
    //String lname;
    //String phone;

    public Customer(String fname, String lname, String phone)
    {
        Fullname = fname;
        Lastname = lname;
        Phone = phone;
    }

    public String Fullname { get; set; }

    public String Lastname { get; set; }

    public String Phone { get; set; }
}