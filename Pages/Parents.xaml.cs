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
using System.Xml.Linq;

namespace Submission_of_Applications_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для Parents.xaml
    /// </summary>
    public partial class Parents : Page
    {
        public Parents()
        {
            InitializeComponent();
            MainWindow.main.SizeToContent = SizeToContent.Manual;
            MainWindow.main.Height = MainWindow.main.ActualHeight + 610;
        }

        private void Next_Pages(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FIO_mother.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я ]$", FIO_mother.Text))
            {
                MessageBox.Show("Не правильно указана ФИО матери!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(date_of_birth_mother.Text) || !Classes.CheckRegex.Match("^[0-9]{2}\\.[0-9]{2}\\.[0-9]{4}$", date_of_birth_mother.Text))
            {
                MessageBox.Show("Не правильно указана дата рождения матери!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(place_of_work_mother.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я ]$", place_of_work_mother.Text))
            {
                MessageBox.Show("Не правильно указано место работы матери!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(post_mother.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я ]$", post_mother.Text))
            {
                MessageBox.Show("Не правильно указана занимаемая должность матери!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(place_of_residence_mother.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я0-9,. ]$", place_of_residence_mother.Text))
            {
                MessageBox.Show("Не правильно указано место жительства матери!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(number_home_mother.Text) || !Classes.CheckRegex.Match(@"[0-9- ]$", number_home_mother.Text))
            {
                MessageBox.Show("Не правильно указан домашний телефон матери!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(number_mobile_mother.Text) || !Classes.CheckRegex.Match(@"[0-9-() ]$", number_mobile_mother.Text))
            {
                MessageBox.Show("Не правильно указан мобильный телефон матери!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(FIO_father.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я ]$", FIO_father.Text))
            {
                MessageBox.Show("Не правильно указана ФИО отца!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(date_of_birth_father.Text) || !Classes.CheckRegex.Match("^[0-9]{2}\\.[0-9]{2}\\.[0-9]{4}$", date_of_birth_father.Text))
            {
                MessageBox.Show("Не правильно указана дата рождения отца!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(place_of_work_father.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я ]$", place_of_work_father.Text))
            {
                MessageBox.Show("Не правильно указано место работы отца!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(post_father.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я ]$", post_father.Text))
            {
                MessageBox.Show("Не правильно указана занимаемая должность отца!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(place_of_residence_father.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я0-9,. ]$", place_of_residence_father.Text))
            {
                MessageBox.Show("Не правильно указано место жительства отца!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(number_home_father.Text) || !Classes.CheckRegex.Match(@"[0-9- ]$", number_home_father.Text))
            {
                MessageBox.Show("Не правильно указан домашний телефон отца!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(number_mobile_father.Text) || !Classes.CheckRegex.Match(@"[0-9-() ]$", number_mobile_father.Text))
            {
                MessageBox.Show("Не правильно указан мобильный телефон отца!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            MessageBox.Show("Заявка подана, ожидайте результатов!");
            MainWindow.main.Close();
        }
    }
}
