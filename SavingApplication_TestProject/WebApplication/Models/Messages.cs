﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
	public class Messages
	{
		public int ID { get; set; }
		public string MessageType { get; set; }
		public string Message { get; set; }
		public Messages()
		{
		}
	}
}