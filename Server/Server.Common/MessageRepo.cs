using System;
using System.Collections.Generic;
using Server.Data.Entities;
using Server.Data.QueryProcessors;

namespace Server.Common
{
    public class MessageRepo : IMessageRepo
    {
        private IAddMessageQueryProcessor _add;
        private IGetAllMessagesQueryProcessor _get;

        public MessageRepo(IAddMessageQueryProcessor iAdd, IGetAllMessagesQueryProcessor iGet)
        {
            _add = iAdd;
            _get = iGet;
        }

        public void AddMessage(String text)
        {
            _add.AddMessage(new Message
            {
                ID = Guid.NewGuid(),
                CreatedAt = DateTime.Now,
                Text = text
            });
        }

        public List<Message> GetMessages()
        {
            return _get.GetMessages();
        }
    }
}
