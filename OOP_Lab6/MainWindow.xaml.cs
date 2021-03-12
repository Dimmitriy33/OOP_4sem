using MaterialDesignThemes.Wpf;
using OOP_Lab6.Menu;
using OOP_Lab6.MenuItems;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace OOP_Lab6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var MenuProductsSub = new List<SubItem>();
            MenuProductsSub.Add(new SubItem("Gaming Headsets"));
            MenuProductsSub.Add(new SubItem("Microphones"));
            MenuProductsSub.Add(new SubItem("Keyboards"));
            MenuProductsSub.Add(new SubItem("Mice"));
            MenuProductsSub.Add(new SubItem("Mouse Pads"));
            var MenuProduct = new ItemMenu("Products", PackIconKind.Devices, MenuProductsSub);

            var MenuSupportSub = new List<SubItem>();
            MenuSupportSub.Add(new SubItem("Product Verification"));
            MenuSupportSub.Add(new SubItem("Return Policy"));
            var MenuSupport = new ItemMenu("Support", PackIconKind.Support, MenuSupportSub);

            var MenuShopsSub = new List<SubItem>();
            MenuShopsSub.Add(new SubItem("Russia"));
            MenuShopsSub.Add(new SubItem("Belarus"));
            MenuShopsSub.Add(new SubItem("Ukraine"));
            var MenuShops = new ItemMenu("Shops", PackIconKind.Shop, MenuShopsSub);

            var MenuContacts = new ItemMenu("Contacts", PackIconKind.Contact, new UserControl());

            var MenuInfoAboutUs = new ItemMenu("About us", PackIconKind.AboutCircleOutline, new UserControl());

            MenuPanel.Children.Add(new UserControlMenuItem(MenuProduct));
            MenuPanel.Children.Add(new UserControlMenuItem(MenuSupport));
            MenuPanel.Children.Add(new UserControlMenuItem(MenuShops));
            MenuPanel.Children.Add(new UserControlMenuItem(MenuContacts));
            MenuPanel.Children.Add(new UserControlMenuItem(MenuInfoAboutUs));
        }

        private void LightDarkThemeIcon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AccountIcon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseIcon_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
