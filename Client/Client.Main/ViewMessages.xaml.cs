using System;
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
using Client.Main.MessageServiceReference;

namespace Client.Main
{
    /// <summary>
    /// Interaction logic for ViewMessages.xaml
    /// </summary>
    public partial class ViewMessages : Window
    {
        public Message[] Data;

        public ViewMessages()
        {
            InitializeComponent();
            showMessages();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            showMessages();
        }

        private void showMessages()
        {
            MessageServiceClient client = new MessageServiceClient();
            Data = client.GetMessages();
            var list = from m in Data
                select new {Text = m.Text, CreatedAt = m.CreatedAt};
            
            messageGrid.ItemsSource = list; 
        }
    }
}
