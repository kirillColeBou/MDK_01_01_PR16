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

namespace Submission_of_Applications_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для Contacts.xaml
    /// </summary>
    public partial class Contacts : Page
    {
        public Contacts()
        {
            InitializeComponent();
            MainWindow.main.SizeToContent = SizeToContent.Manual;
            MainWindow.main.SizeToContent = SizeToContent.Height;
        }

        private void Next_Pages(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(number_home.Text) || !Classes.CheckRegex.Match("^[0-9]{3}\\-[0-9]{2}\\-[0-9]{2}$", number_home.Text))
            {
                MessageBox.Show("Не правильно указан домашний телефон!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(number_mobile.Text) || !Classes.CheckRegex.Match("^\\+[7]\\([0-9]{3}\\)[0-9]{3}\\-[0-9]{2}\\-[0-9]{2}$", number_mobile.Text))
            {
                MessageBox.Show("Не правильно указан мобильный телефон!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(email_address.Text) || !Classes.CheckRegex.Match(@"^\w+@\w+\.\w+$", email_address.Text))
            {
                MessageBox.Show("Не правильно указана почта!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            MainWindow.main.OpenPages(MainWindow.pages.parents);
        }
    }
}
