using System.Windows.Controls;

namespace DropDownMenuApplication.ViewModels
{
    public class SubItem
    {
        public SubItem(string name, UserControl screen = null)
        {
            Name = name;
            Screen = screen;
        }

        public string Name { get; set; }
        public UserControl Screen { get; set; }
    }
}
