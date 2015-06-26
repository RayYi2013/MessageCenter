using System;
using System.Collections.Generic;
using System.Linq;
using Server.Data.Entities;
using Server.Data.QueryProcessors;

namespace Server.Data.SqlServer.QueryProcessors
{
    public class GetAllMessagesQueryProcessor  : IGetAllMessagesQueryProcessor
    {
        public List<Message> GetMessages()
        {
            using (var ctx = new Context())
            {
                return ctx.Messages.OrderByDescending(m => m.CreatedAt).ToList();
            } 
            //var list = new List<Message>
            //{
            //    new Message() {ID = Guid.NewGuid(), CreatedAt = DateTime.Now - TimeSpan.FromDays(1), Text = "test1"},
            //    new Message() {ID = Guid.NewGuid(), CreatedAt = DateTime.Now, Text = "test2"}
            //};

            //return list;
        }
    }
}
