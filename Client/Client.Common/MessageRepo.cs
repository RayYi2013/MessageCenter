using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Data;
using Client.Proxy;

namespace Client.Common
{
    public class MessageRepo : IMessageRepo
    {
        private IMessageService _serv;
        public MessageRepo(IMessageService serv)
        {
            _serv = serv;
        }

        public void AddMessage(string text)
        {
            _serv.AddMessage(text);
        }

        public List<Message> GetMessages()
        {
            var data = _serv.GetMessages();
            var list = from m in data.AsEnumerable()
                       select new Message { Text = m.Text, CreatedAt = m.CreatedAt };
            return list.ToList();
        }
    }
}
