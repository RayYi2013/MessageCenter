using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using Client.Common;
using Client.Proxy;


namespace Client.Main
{
    /// <summary>
    /// Interaction logic for SendMessage.xaml
    /// </summary>
    public partial class SendMessage : Window
    {
        public SendMessage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var msg = txtMessage.Text;
            if (!string.IsNullOrEmpty(msg))
            {
                var client = Container.Instance.Get<IMessageService>();
                client.AddMessage(txtMessage.Text);
                MessageBox.Show("message send.");
                txtMessage.Text = "";
            }
        }
    }
}
