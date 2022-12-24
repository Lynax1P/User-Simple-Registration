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
using UserApp;



namespace UserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text;
            string email = textBoxEmail.Text;
            string pass = passwordBox.Password;
            string passTry = passwordBoxTry.Password;

            if (email.Length < 5 | !email.Contains('@') | !email.Contains('.'))
            {
                textBoxEmail.ToolTip = "Не корректный ввод поля.";
                textBoxEmail.Background = Brushes.LightPink;
            }
            else
            {
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;
            }

            if (login.Length < 3)
            {
                textBoxLogin.ToolTip = "Не корректный ввод поля.";
                textBoxLogin.Background = Brushes.LightPink;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
            }
            if (pass.Length < 5)
            {
                passwordBox.ToolTip = "Не корректный ввод поля.";
                passwordBox.Background = Brushes.LightPink;
            }
            else
            {
                passwordBox.ToolTip = "";
                passwordBox.Background = Brushes.Transparent;
            }
            if (pass != passTry)
            {
                passwordBoxTry.ToolTip = "Поля не совпадют.";
                passwordBoxTry.Background = Brushes.LightPink;
            }
            else
            {
                passwordBoxTry.ToolTip = "";
                passwordBoxTry.Background = Brushes.Transparent;
            }
            if ((string)passwordBoxTry.ToolTip == "" && (string)passwordBox.ToolTip == "" && (string)textBoxLogin.ToolTip == "" 
                    && (string)textBoxEmail.ToolTip == "")
            {
                MessageBox.Show("Всё хороошо!");
                User user = new User(login, pass, email);
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}