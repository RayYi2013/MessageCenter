using System;
using System.ComponentModel.DataAnnotations;


namespace Server.Data.Entities
{
    public class Message
    {
        [Key]
        public Guid ID { get; set; }

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
