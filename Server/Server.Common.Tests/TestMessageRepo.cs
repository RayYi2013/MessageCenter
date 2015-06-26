using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Server.Data.Entities;
using Server.Data.QueryProcessors;

namespace Server.Common.Tests
{
    [TestFixture]
    public class TestMessageRepo
    {
        private Mock<IAddMessageQueryProcessor> _add;
        private Mock<IGetAllMessagesQueryProcessor> _get;

        [SetUp]
        public void SetUp()
        {
            _add = new Mock<IAddMessageQueryProcessor>();
            _get = new Mock<IGetAllMessagesQueryProcessor>();
        }

        [Test]
        public void AddMessage_with_correct_message()
        {
            //arrange
            string text = "test";
            Message msg;
            _add.Setup(x => x.AddMessage(It.IsAny<Message>()));

            //act
            MessageRepo repo = new MessageRepo(_add.Object, _get.Object);
            repo.AddMessage(text);

            //assert
            _add.Verify(f => f.AddMessage(It.Is<Message>(m=>m.Text==text) ), Times.Once());
        }


        [Test]
        public void GetMessages_return_correct_message()
        {
            //arrange
            var list = new List<Message>
            {
                new Message() {ID = Guid.NewGuid(), CreatedAt = DateTime.Now - TimeSpan.FromDays(1), Text = "test1"},
                new Message() {ID = Guid.NewGuid(), CreatedAt = DateTime.Now, Text = "test2"}
            };
            _get.Setup(x => x.GetMessages()).Returns(list);

            //act
            MessageRepo repo = new MessageRepo(_add.Object, _get.Object);
            var res = repo.GetMessages();

            //assert
            _get.Verify(f => f.GetMessages(), Times.Once());
            Assert.AreEqual(list, res);
        }
    }
}
