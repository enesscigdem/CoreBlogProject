﻿using System;
namespace EntityLayer.Concrete
{
	public class Message
	{
		public int MessageID { get; set; }
		public string Sender { get; set; }
		public string Receiver { get; set; }
		public string Subject { get; set; }
		public string MessageDetails { get; set; }
		public DateTime MessageDate { get; set; }
		public bool MessageStatus { get; set; }
    }
}

