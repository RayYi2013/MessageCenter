using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Data;

namespace Client.Common
{
    public interface IMessageRepo
    {
        void AddMessage(string text);

        List<Message> GetMessages();
    }
}
