﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
                Customer.getInstance().user_id = id_TextBox.Text;
                Customer.getInstance().isLogin = true;
                //SendMessage();
                Window.GetWindow(this).Close();
            }
            else
                MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Customer.getInstance().isAutoLogin = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Customer.getInstance().isAutoLogin = false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(Customer.getInstance().isLogin)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void SendMessage()
        {
            try {
                TcpClient tcp = new TcpClient("10.80.162.151", 80);
                var json = new JObject();
                json.Add("MSGType", 0);
                json.Add("Id", "2211");
                byte[] buff = Encoding.UTF8.GetBytes(json.ToString());
                NetworkStream network = tcp.GetStream();
                network.Write(buff, 0, buff.Length);
                Console.WriteLine(json.ToString());
            } catch(SocketException e)
            {
                MessageBox.Show("서버와 연결이 되지 않습니다.");
            }
        }
    }
}
