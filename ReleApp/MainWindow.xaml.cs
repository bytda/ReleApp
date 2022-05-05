using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
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

namespace ReleApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UdpClient client = new UdpClient();
            client.Connect("169.254.153.128", 1200);
            string message = ":04;";
            byte[] data = Encoding.UTF8.GetBytes(message);
            int numberOfSentBytes = client.Send(data, data.Length);

            IPEndPoint ip = null;
            byte[] data2 = client.Receive(ref ip);
            string message2 = Encoding.UTF8.GetString(data2);
            textBox.Text = message2;
            if (message2[4]!='0')
            textBox.Text = "Реле включено";
            else textBox.Text = "Реле выключено";
            client.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UdpClient client = new UdpClient();
            client.Connect("169.254.153.128", 1200);
            string message = ":03;";
            byte[] data = Encoding.UTF8.GetBytes(message);
            int numberOfSentBytes = client.Send(data, data.Length);

            IPEndPoint ip = null;
            byte[] data2 = client.Receive(ref ip);
            string message2 = Encoding.UTF8.GetString(data2);
            textBox2.Text = message2;
          // if (message2[4] != '0')
          //     textBox.Text = "Реле включено";
          // else textBox.Text = "Реле выключено";
            client.Close();
        }
    }
}
