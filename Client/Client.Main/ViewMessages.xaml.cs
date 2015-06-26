using System;
using System.Windows;

using Client.Common;
using Client.Proxy;


namespace Client.Main
{
    /// <summary>
    /// Interaction logic for ViewMessages.xaml
    /// </summary>
    public partial class ViewMessages : Window
    {
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
            var client = Container.Instance.Get<IMessageService>();
            var list = client.GetMessages();
            
            messageGrid.ItemsSource = list; 
        }
    }
}
