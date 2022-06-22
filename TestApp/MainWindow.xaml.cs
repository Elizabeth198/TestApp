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

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Base.TestAppEntities Database;

        private List<Page> ActivePages;
        private int PageIndex;
        public MainWindow()
        {
            
            InitializeComponent();
            Database = new Base.TestAppEntities();
            ActivePages = new List<Page>();
            PageIndex = -1;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        private void LoadedFrame_LoadCompleted(object sender, NavigationEventArgs e)
        {

        }

        private void aa_click(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new Pages.Primer());
        }

        
    }
}
