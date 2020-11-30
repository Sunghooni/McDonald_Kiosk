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
    /// Message.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Message : Window
    {
        public Message()
        {
            InitializeComponent();
        }



        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Customer.getInstance().isGroupMessage = true;
        }        

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Customer.getInstance().isGroupMessage = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TcpClient tcp = new TcpClient("10.80.162.151", 80);
                var json = new JObject();
                json.Add("MSGType", 1);
                json.Add("Id", "2211");
                json.Add("Content", message.Text);
                byte[] buff = Encoding.UTF8.GetBytes(json.ToString());
                NetworkStream network = tcp.GetStream();
                network.Write(buff, 0, buff.Length);
                Console.WriteLine(json.ToString());

                message.Text = "";
            }
            catch (SocketException)
            {
                MessageBox.Show("서버와 연결이 되지 않습니다.");
            }
        }
    }
}
