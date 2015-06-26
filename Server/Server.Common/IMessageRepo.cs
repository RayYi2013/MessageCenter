using System;
using System.Collections.Generic;
using Server.Data.Entities;

namespace Server.Common
{
    public interface IMessageRepo
    {
        void AddMessage(string text);

        List<Message> GetMessages();
    }
}
