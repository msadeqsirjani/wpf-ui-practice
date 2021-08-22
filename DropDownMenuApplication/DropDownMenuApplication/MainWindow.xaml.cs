using DropDownMenuApplication.ViewModels;
using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DropDownMenuApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var menuRegister = new List<SubItem>
            {
                new("Customers", new UserControlCustomers()),
                new("Providers", new UserControlProviders()),
                new("Employees"),
                new("Products"),
            };
            var item0 = new ItemMenu("Register", PackIconKind.CashRegister, menuRegister);

            var menuSchedule = new List<SubItem>
            {
                new("Services"),
                new("Meetings"),
            };
            var item1 = new ItemMenu("Appointments", PackIconKind.Schedule, menuSchedule);

            var menuReports = new List<SubItem>
            {
                new("Customers"),
                new("Providers"),
                new("Products"),
                new("Stocks"),
                new("Sales"),
            };
            var item2 = new ItemMenu("Reports", PackIconKind.FileReport, menuReports);

            var menuExpenses = new List<SubItem>
            {
                new("Fixes"),
                new("Variables"),
            };
            var item3 = new ItemMenu("Expenses", PackIconKind.ShoppingBasket, menuExpenses);

            var menuFinancial = new List<SubItem>
            {
                new("Cash Flow")
            };
            var item4 = new ItemMenu("Financial", PackIconKind.ScaleBalance, menuFinancial);

            Menu.Children.Add(new UserControlMenuItem(item0, this));
            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this));
            Menu.Children.Add(new UserControlMenuItem(item3, this));
            Menu.Children.Add(new UserControlMenuItem(item4, this));
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        internal void SwitchScreen(object sender)
        {
            if (sender is not UserControl screen) return;

            StackPanelMain.Children.Clear();
            StackPanelMain.Children.Add(screen);
        }
    }
}
