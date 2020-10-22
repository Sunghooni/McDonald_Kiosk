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

namespace McDonald_Kiosk
{
    public partial class CardPayment : Page
    {
        public CardPayment()
        {
            InitializeComponent();
            webcam.CameraIndex = 0;
        }

        private void webcam_QrDecoded(object sender, string e) 
        { 
            if(!PaymentBtn.IsEnabled)
            {
                tbRecog.Content = "회원명 : " + e;
                PaymentBtn.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            OrderNumber orderNumber = new OrderNumber();
            NavigationService.Navigate(orderNumber);
        }

        private void Button1_Load(object sender, RoutedEventArgs e)
        {
            PaymentBtn.IsEnabled = false;
        }
    }
}
