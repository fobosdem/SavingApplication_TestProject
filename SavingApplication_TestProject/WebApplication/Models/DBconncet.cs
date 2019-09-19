using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
	public class DBconncet : DbContext
	{
		public DbSet<Users> Users { get; set; }
		public DbSet<Chats> Chats { get; set; }
		public DbSet<Messages> Messages { get; set; }
		public DBconncet() : base("SavingHistoryDB")
		{ }
	}
}