using Submission_of_Applications_Тепляков.Pages;
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

namespace Submission_of_Applications_Тепляков
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow main;
        public MainWindow()
        {
            InitializeComponent();
            OpenPages(pages.statement);
            this.SizeToContent = SizeToContent.Height;
            main = this;
        }

        public enum pages
        {
            statement, education, status, speciality, passport, contacts, parents
        }

        public void OpenPages(pages _pages)
        {
            if (_pages == pages.statement)
                frame.Navigate(new Pages.Statement());
            if (_pages == pages.education)
                frame.Navigate(new Pages.Education());
            if (_pages == pages.status)
                frame.Navigate(new Pages.Status());
            if (_pages == pages.speciality)
                frame.Navigate(new Pages.Speciality());
            if (_pages == pages.passport)
                frame.Navigate(new Pages.Passport());
            if (_pages == pages.contacts)
                frame.Navigate(new Pages.Contacts());
            if (_pages == pages.parents)
                frame.Navigate(new Pages.Parents());
        }
    }
}
