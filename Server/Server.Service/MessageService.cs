using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MessageService" in both code and config file together.
    public class MessageService : IMessageService
    {

        public void AddMessage(string Text)
        {
            
        }

        public List<Data.Entities.Message> GetList()
        {
            List<Data.Entities.Message> list = new List<Data.Entities.Message>() {
                new Data.Entities.Message(){ ID=Guid.NewGuid(), CreatedAt = DateTime.Now, Text="test"},
                new Data.Entities.Message(){ ID=Guid.NewGuid(), CreatedAt = DateTime.Now, Text="test"}
            };
            return list;

        }
    }
}
