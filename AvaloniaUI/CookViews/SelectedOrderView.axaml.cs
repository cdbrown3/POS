using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Backend.Model;
using Microsoft.VisualBasic;

namespace AvaloniaUI;

public partial class SelectedOrderView : UserControl
{
    private OrderInfo orderInfo;
    public SelectedOrderView()
    {
        InitializeComponent();
    }

    public SelectedOrderView(OrderInfo info) : this()
    {
        orderInfo = info;

        LoadSelectedOrder();
    }

    private void LoadSelectedOrder()
    {
        //order number
        orderNumberTextBlock.Text = orderInfo.OrderNumber;

        //order info
        orderInfoTextBlock.Text = orderInfo.ToString();
    }
}