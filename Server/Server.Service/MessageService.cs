using System;
using System.Collections.Generic;
using System.ServiceModel;
using Ninject;
using Server.Data.Entities;
using Server.Common;

namespace Server.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MessageService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MessageService : IMessageService
    {
        private IMessageRepo _repo;

        public MessageService(IMessageRepo repo)
        {
            _repo = repo;
        }

        public void AddMessage(string text)
        {
            _repo.AddMessage(text);
        }

        public List<Message> GetMessages()
        {
            return _repo.GetMessages();

        }
    }
}
