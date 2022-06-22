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
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for AutWindow.xaml
    /// </summary>
    public partial class AutWindow : Window
    {
        private Base.TestAppEntities DataBase;
        public AutWindow()
        {
            InitializeComponent();
            try
            {
                DataBase = new Base.TestAppEntities();
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к базе данных", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Aut_Click(object sender, RoutedEventArgs e)
        {
            Base.Users User = DataBase.Users.SingleOrDefault(U => (U.login == LoginTextBox.Text && U.passwordd == PasswordTextBox.Text));
            if (User != null)
            {
                MainWindow window = new MainWindow();
                window.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Не верно указан логин/пароль!","Предупреждение!",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            RegistrWindow registr = new RegistrWindow(DataBase);
            registr.ShowDialog();
        }
    }
}
