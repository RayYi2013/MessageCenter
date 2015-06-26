using System;
using System.Collections.Generic;
using Server.Data.Entities;

namespace Server.Data.QueryProcessors
{
    public interface IGetAllMessagesQueryProcessor
    {
        List<Message> GetMessages();
    }
}
