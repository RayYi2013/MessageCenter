using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Proxy.MessageServiceReference;



namespace Client.Proxy
{
    public class MessageService : IMessageService
    {
        public void AddMessage(string text)
        {
            MessageServiceClient client = new MessageServiceClient();
            client.AddMessage(text);
        }

        public List<Client.Data.Message> GetMessages()
        {
            MessageServiceClient client = new MessageServiceClient();
            var list = from m in client.GetMessages()
                       select new Client.Data.Message { Text = m.Text, CreatedAt = m.CreatedAt };
            return list.ToList();

        }
    }
}
