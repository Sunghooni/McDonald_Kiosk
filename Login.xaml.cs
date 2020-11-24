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

namespace McDonald_Kiosk
{
    /// <summary>
    /// Login.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Login : Window
    {
        bool isAutoLogin = false;
        string userId;
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            checkOverlap(id_TextBox.Text, pw_TextBox.Text);
        }

        private void checkOverlap(string id, string pw)
        {
            if (id == "baejoohyun" && pw == "a1234567")
            {
                userId = id_TextBox.Text;
                Window.GetWindow(this).Close();
            }
            else
                MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            isAutoLogin = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            isAutoLogin = false;
        }
    }
}
