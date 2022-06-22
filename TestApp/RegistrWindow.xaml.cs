using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        private Base.TestAppEntities Database;
        public RegistrWindow(Base.TestAppEntities Database)
        {
            InitializeComponent();
            this.Database = Database;
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            var pas = PasswordBox.Text;
            var Number = new Regex(@"[0-9]+");
            var UpperCase = new Regex(@"[A-Z|А-Я]+");
            var SpecSimv = new Regex(@"(?=.*[\W])");
            var Min8Char = new Regex(@".{8,}");
            if(Number.IsMatch(pas) && UpperCase.IsMatch(pas) && SpecSimv.IsMatch(pas) && Min8Char.IsMatch(pas))
            {
                Base.Users user = new Base.Users();
                user.login = LoginBox.Text;
                user.passwordd = PasswordBox.Text;
                Database.Users.Add(user);
                Database.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Введен не соответсвующий пароль","Предупреждение", MessageBoxButton.OK,MessageBoxImage.Warning);
            }
            
        }

        private void Сloses_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
