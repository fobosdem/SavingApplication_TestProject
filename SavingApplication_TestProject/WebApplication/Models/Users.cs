﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
	public class Users
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string NickName { get; set; }
		public string Password { get; set; }
	}
}