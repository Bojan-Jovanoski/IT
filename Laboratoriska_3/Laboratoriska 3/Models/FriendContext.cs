using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Laboratoriska_3.Models
{
    public class FriendContext : DbContext
    {
        public FriendContext() : base("DefaultConnection") { }
        public DbSet<FriendModel> Friends { get; set; }

        public static FriendContext Create()
        {
            return new FriendContext();
        }
    }
}