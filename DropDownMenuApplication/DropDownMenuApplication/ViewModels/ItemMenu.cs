using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Windows.Controls;

namespace DropDownMenuApplication.ViewModels
{
    public class ItemMenu
    {
        public ItemMenu(string header, PackIconKind icon, List<SubItem> subItems)
        {
            Header = header;
            Icon = icon;
            SubItems = subItems;
        }

        public string Header { get; set; }
        public PackIconKind Icon { get; set; }
        public List<SubItem> SubItems { get; set; }
        public UserControl Screen { get; set; }
    }
}