using System;
using Server.Data.Entities;


namespace Server.Data.SqlServer.QueryProcessors
{
    public class AddMessageQueryProcessor : Data.QueryProcessors.IAddMessageQueryProcessor
    {
        public void AddMessage(Message msg)
        {
            using (var ctx = new Context())
            {
                ctx.Messages.Add(msg);
                ctx.SaveChanges();
            } 
        }
    }
}
