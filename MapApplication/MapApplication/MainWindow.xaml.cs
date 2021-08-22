using Microsoft.Maps.MapControl.WPF;
using System.Windows;
using System.Windows.Input;

namespace MapApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Map.CredentialsProvider = new ApplicationIdCredentialsProvider("Lfv44DQzTbJaFpirns6L~2vQlrWcA6sOj6rINoie7AQ~Ap33ySEkdG8SzabV6pJwFEdjUlqdU6PbxmmsuulpHRfzLlAND7qnH0mPJB7DWmEG");
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
