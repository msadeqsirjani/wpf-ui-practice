using ContentLoaderApplication.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;

namespace ContentLoaderApplication
{
    public class ContentLoader : INotifyPropertyChanged
    {
        public ContentLoader()
        {
            Visibility = Visibility.Collapsed;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Visibility _visibility;

        public Visibility Visibility
        {
            get => _visibility;
            set
            {
                _visibility = value;
                OnPropertyChanged(nameof(Visibility));
            }
        }

        public void LoadContent()
        {
            Visibility = Visibility.Visible;

            var thread = new Thread(() =>
            {
                Thread.Sleep(3000);
                Visibility = Visibility.Collapsed;
            });

            thread.Start();
        }
    }
}
