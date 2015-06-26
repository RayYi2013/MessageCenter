using System;
using System.Collections.Generic;
using Client.Data;

namespace Client.Proxy
{
    public interface IMessageService
    {
        void AddMessage(string text);

        List<Message> GetMessages();
    }
}
