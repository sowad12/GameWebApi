﻿namespace GameShopWebApi.Model
{
	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		//public Country Country { get; set; }
		//public ICollection<GameCustomer> GameCustomers { get; set; }
	}
}
