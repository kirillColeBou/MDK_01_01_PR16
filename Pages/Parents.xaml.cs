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
        }

        private void Next_Pages(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заявка подана, ожидайте результатов!");
            MainWindow.main.Close();
        }
    }
}
