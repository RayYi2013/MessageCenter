using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Data.Entities;

namespace Server.Data.SqlServer
{
    public class Context : DbContext   
    {
        public Context()
            : base()
        {

        }

        public DbSet<Message> Messages { get; set; } 
    }
}
