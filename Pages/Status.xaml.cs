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
    /// Логика взаимодействия для Status.xaml
    /// </summary>
    public partial class Status : Page
    {
        public Status()
        {
            InitializeComponent();
            MainWindow.main.SizeToContent = SizeToContent.Manual;
            MainWindow.main.SizeToContent = SizeToContent.Height;
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
            MainWindow.main.OpenPages(MainWindow.pages.speciality);
        }
    }
}
