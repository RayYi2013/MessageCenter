using System;
using Server.Data.Entities;

namespace Server.Data.QueryProcessors
{
    public interface IAddMessageQueryProcessor
    {
        void AddMessage(Message msg);
    }
}
