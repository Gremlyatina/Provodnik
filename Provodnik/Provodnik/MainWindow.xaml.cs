using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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

namespace Provodnik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            // Проверьте данные на валидность

            string query = $"SELECT id, name, email FROM user WHERE email = '{email}' AND password = '{password}'";

            BD dataAccess = new BD();
            SQLiteDataReader reader = dataAccess.GetDataReader(query);

            if (reader.Read())
            {
                string id = reader["id"].ToString();
                string name = reader["name"].ToString();
                string userEmail = reader["email"].ToString();

                Window4 window4 = new Window4(id, name, userEmail);
                window4.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный email или пароль. Пожалуйста, попробуйте снова.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }
    }
}
