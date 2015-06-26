using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Data;
using Client.Proxy;
using Moq;
using NUnit.Framework;


namespace Client.Common.Tests
{
    [TestFixture]
    public class TestMessageRepo
    {
        private Mock<IMessageService> _serv;

        [SetUp]
        public void SetUp()
        {
            _serv = new Mock<IMessageService>();
        }

        [Test]
        public void AddMessage_with_correct_message()
        {
            //arrange
            string text = "test";
            _serv.Setup(x => x.AddMessage(It.IsAny<String>()));

            //act
            MessageRepo repo = new MessageRepo(_serv.Object);
            repo.AddMessage(text);

            //assert
            _serv.Verify(f => f.AddMessage(text), Times.Once());
        }


        [Test]
        public void GetMessages_return_correct_message()
        {
            //arrange
            var list = new List<Message>
            {
                new Message() {CreatedAt = DateTime.Now - TimeSpan.FromDays(1), Text = "test1"},
                new Message() {CreatedAt = DateTime.Now, Text = "test2"}
            };
            _serv.Setup(x => x.GetMessages()).Returns(list);

            //act
            MessageRepo repo = new MessageRepo(_serv.Object);
            var res = repo.GetMessages();

            //assert
            _serv.Verify(f => f.GetMessages(), Times.Once());
            Assert.AreEqual(list.Count, res.Count);
        }
    }
}

