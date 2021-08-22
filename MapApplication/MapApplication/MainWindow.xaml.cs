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

            Map.CredentialsProvider = new ApplicationIdCredentialsProvider("your-secret-key");
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
