using System.Windows.Controls;

namespace OOP_Lab6.MenuItems
{
    public class SubItem
    {
        public SubItem(string SubName, UserControl screen = null)
        {
            this.SubName = SubName;
            this.Screen = screen;
        }
        public string SubName { get; private set; }
        public UserControl Screen { get; private set; }
    }
}
