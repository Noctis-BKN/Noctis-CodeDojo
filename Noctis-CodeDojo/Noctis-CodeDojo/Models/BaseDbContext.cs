using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Noctis_CodeDojo.Models
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Member> Members { get; set; }
         public DbSet<ArticleReply> ArticleReplys { get; set; }
        
    }
}