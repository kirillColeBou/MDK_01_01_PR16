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

namespace Submission_of_Applications_Тепляков.Pages
{
    /// <summary>
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class Education : Page
    {
        public Education()
        {
            InitializeComponent();
            MainWindow.main.SizeToContent = SizeToContent.Manual;
            MainWindow.main.Height = MainWindow.main.ActualHeight + 60;
        }

        private void Format_doc(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.jpg; *.jpeg; *.png; *.pdf)|*.jpg;*.jpeg;*.png;*.pdf";
            ofd.Title = "Выберите несколько фотографий"; ofd.Multiselect = true;
            if (ofd.ShowDialog() == true) ;
            format_file.Text += ofd.FileName;
        }

        private void Next_Pages(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(series.Text) || !Classes.CheckRegex.Match("^[0-9]{2} [а-яА-Я]{2} [0-9]{8}$", series.Text))
            {
                MessageBox.Show("Не правильно указана серия и номер документа об образовании!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            if (string.IsNullOrEmpty(avg_score.Text) || !Classes.CheckRegex.Match("^[0-5]\\,[0-9]{2}$", avg_score.Text))
            {
                MessageBox.Show("Не правильно указан средний балл!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                return;
            }
            MainWindow.main.OpenPages(MainWindow.pages.status);
        }
    }
}
