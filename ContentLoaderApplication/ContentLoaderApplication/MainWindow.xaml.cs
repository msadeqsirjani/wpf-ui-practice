using System.Windows;
using System.Windows.Input;

namespace ContentLoaderApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ContentLoader ContentLoader { get; }

        public MainWindow()
        {
            InitializeComponent();

            ContentLoader = new ContentLoader();

            DataContext = ContentLoader;
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ContentLoader.LoadContent();
        }
    }
}
