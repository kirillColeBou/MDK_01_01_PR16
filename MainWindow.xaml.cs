﻿using System;
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
        public MainWindow()
        {
            this.SizeToContent = SizeToContent.Manual;
            this.SizeToContent = SizeToContent.Width;
            this.SizeToContent = SizeToContent.Height;
            this.SizeToContent = SizeToContent.WidthAndHeight;
            InitializeComponent();
            OpenPages(pages.statement);
        }

        public enum pages
        {
            statement
        }

        public void OpenPages(pages _pages)
        {
            if (_pages == pages.statement)
                frame.Navigate(new Pages.Statement());
        }
    }
}
