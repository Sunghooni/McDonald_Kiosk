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
using System.Windows.Threading;

namespace McDonald_Kiosk
{
    /// <summary>
    /// OrderNumber.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OrderNumber : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        public OrderNumber()
        {
            InitializeComponent();
        }

        public void Label_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = TimeSpan.FromSeconds(15);
            timer.Tick += GoHomePage;
            timer.Start();
        }

        private void GoHomePage(object sender, EventArgs e)
        {
            Home home = new Home();
            NavigationService.Navigate(home);
            timer.Stop();
        }
    }
}
