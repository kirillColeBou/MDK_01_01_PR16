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
    /// Логика взаимодействия для Statement.xaml
    /// </summary>
    public partial class Statement : Page
    {
        public Statement()
        {
            InitializeComponent();
        }

        public void Next_Pages(object sender, RoutedEventArgs e) 
        {
            if (string.IsNullOrEmpty(st_edu_ins_and_city.Text) || !Classes.CheckRegex.Match(@"[а-яА-Я0-9, ]$", st_edu_ins_and_city.Text))
            {
                MessageBox.Show("Не правильно указано место обучения!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(year_of_graduation.Text) || !Classes.CheckRegex.Match("^[0-9]{4}$", year_of_graduation.Text))
            {
                MessageBox.Show("Не правильно указан год окончания!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            MainWindow.main.OpenPages(MainWindow.pages.education);
        }
    }
}
