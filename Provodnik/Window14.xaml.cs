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
using System.Windows.Shapes;

namespace Provodnik
{
    /// <summary>
    /// Логика взаимодействия для Window14.xaml
    /// </summary>
    public partial class Window14 : Window
    {
        public Window14()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = (Window4)sender;
            window4.Show();
            Hide();
        }
    }
}
