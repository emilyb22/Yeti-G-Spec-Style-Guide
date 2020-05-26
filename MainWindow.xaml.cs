using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Yeti_G_Spec_Style_Guide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataObject();
            mainFrame.Content = new Home();
        }

        private void ToIcons(object sender, RoutedEventArgs e)
        {
            var Icons = new Icons();
            mainFrame.NavigationService.Navigate(Icons);

        }
        private void ToColors(object sender, RoutedEventArgs e)
        {
            var colors = new Colors();
            mainFrame.NavigationService.Navigate(colors);

        }
        private void ToButtons(object sender, RoutedEventArgs e)
        {
            var buttons = new Buttons();
            mainFrame.NavigationService.Navigate(buttons);

        }
        private void ToSearches(object sender, RoutedEventArgs e)
        {
            var search = new Searches();
            mainFrame.NavigationService.Navigate(search);

        }
        private void ToHeaders(object sender, RoutedEventArgs e)
        {
            var header = new Headers();
            mainFrame.NavigationService.Navigate(header);

        }
        private void ToLists(object sender, RoutedEventArgs e)
        {
            var list = new Lists();
            mainFrame.NavigationService.Navigate(list);

        }
        private void ToForms(object sender, RoutedEventArgs e)
        {
            var formy = new Forms();
            mainFrame.NavigationService.Navigate(formy);

        }
        private void ToTree(object sender, RoutedEventArgs e)
        {
            var tree = new Tree();
            mainFrame.NavigationService.Navigate(tree);

        }
        private void ToDrawer(object sender, RoutedEventArgs e)
        {
            var draw = new DrawerPopUp();
            mainFrame.NavigationService.Navigate(draw);

        }
        private void ToError(object sender, RoutedEventArgs e)
        {
            var err = new Errors();
            mainFrame.NavigationService.Navigate(err);

        }
        private void ToType(object sender, RoutedEventArgs e)
        {
            var type = new Typography();
            mainFrame.NavigationService.Navigate(type);

        }

    }
}
