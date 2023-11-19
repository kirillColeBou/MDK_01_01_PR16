using Microsoft.Win32;
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
using static System.Net.Mime.MediaTypeNames;

namespace Submission_of_Applications_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для Passport.xaml
    /// </summary>
    public partial class Passport : Page
    {
        public Passport()
        {
            InitializeComponent();
            MainWindow.main.SizeToContent = SizeToContent.Manual;
            MainWindow.main.SizeToContent = SizeToContent.Height;
        }

        private void Format_doc(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pictures (*.jpg; *.jpeg; *.png; *.pdf)|*.jpg;*.jpeg;*.png;*.pdf";
            ofd.Title = "Выберите несколько фотографий"; ofd.Multiselect = true;
            if (ofd.ShowDialog() == true) ;
            format_file.Text += ofd.FileName;
        }

        private void Next_Pages(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(surname.Text) || !Classes.CheckRegex.Match(@"^\w+$", surname.Text))
            {
                MessageBox.Show("Не правильно указана фамилия!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(name.Text) || !Classes.CheckRegex.Match(@"^\w+$", name.Text))
            {
                MessageBox.Show("Не правильно указано имя!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(lastname.Text) || !Classes.CheckRegex.Match(@"^\w+$", lastname.Text))
            {
                MessageBox.Show("Не правильно указано отчество!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(date_of_birth.Text) || !Classes.CheckRegex.Match("^[0-9]{2}\\.[0-9]{2}\\.[0-9]{4}$", date_of_birth.Text))
            {
                MessageBox.Show("Не правильно указана дата рождения!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(citizenship.Text) || !Classes.CheckRegex.Match(@"^\w+$", citizenship.Text))
            {
                MessageBox.Show("Не правильно указано гражданство!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(place_of_birth.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я ]$", place_of_birth.Text))
            {
                MessageBox.Show("Не правильно указано место рождения!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(series.Text) || !Classes.CheckRegex.Match("^[0-9]{2} [0-9]{2} [0-9]{6}$", series.Text))
            {
                MessageBox.Show("Не правильно указана серия и номер паспорта!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(date_of_issue.Text) || !Classes.CheckRegex.Match("^[0-9]{2}\\.[0-9]{2}\\.[0-9]{4}$", date_of_issue.Text))
            {
                MessageBox.Show("Не правильно указана дата выдачи!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(unit_code.Text) || !Classes.CheckRegex.Match("^[0-9]{3}\\-[0-9]{3}$", unit_code.Text))
            {
                MessageBox.Show("Не правильно указан код подразделения!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(issued.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я ]$", issued.Text))
            {
                MessageBox.Show("Не правильно указано место выдачи!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(address_reg.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я0-9,. ]$", address_reg.Text))
            {
                MessageBox.Show("Не правильно указан адрес регистрации!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(district_reg.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я0-9,. ]$", district_reg.Text))
            {
                MessageBox.Show("Не правильно указан район регистрации!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(address_fact.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я0-9,. ]$", address_fact.Text))
            {
                MessageBox.Show("Не правильно указан фактический адрес!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(district_fact.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я0-9,. ]$", district_fact.Text))
            {
                MessageBox.Show("Не правильно указан фактический район проживания!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            MainWindow.main.OpenPages(MainWindow.pages.contacts);
        }
    }
}