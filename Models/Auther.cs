﻿namespace bookshop.Models
{
	public class Auther
	{
		public int Id { get; set; }
		public string AutherName { get; set; }


		public DateTime CreatedOn { get; set; } = DateTime.Now;
		public DateTime UpdateOn { get; set; } = DateTime.Now;
	}
}