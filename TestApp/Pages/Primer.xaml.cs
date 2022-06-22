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

namespace TestApp.Pages
{
    /// <summary>
    /// Interaction logic for Primer.xaml
    /// </summary>
    public partial class Primer : Page
    {
        public Primer()
        {
            InitializeComponent();
            DataContext = this;
            NameDatagrid.ItemsSource = SourseCore.DB.Name_1.ToList();
        }
        private void CommitButtonPod(object sender, RoutedEventArgs e)
        {
            if (DataGridPod.SelectedItem == null)
            {
                var A = new Data.SUBROUTINES();
                A.NAME_SUB = NameTextBox.Text;
                A.PROGRAMS = (Data.PROGRAMS)ComboBoxPro.SelectedItem;


                SourceCore.DB.SUBROUTINES.Add(A);

            }
            SourceCore.DB.SaveChanges();
            CloseEdChangeClick(sender, e);
            Data.SUBROUTINES SelectingArea = (Data.SUBROUTINES)DataGridPod.SelectedItem;
            UpdateGrid(SelectingArea);
            DataGridPod.Focus();
        }
    }
}
