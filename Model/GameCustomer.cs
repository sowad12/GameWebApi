namespace GameShopWebApi.Model
{
	public class GameCustomer
	{
		public int GameId { get; set; }
		public int CustomerId { get; set; }
		public Game Game { get; set; }
		public Customer Customer { get; set; }
	}
}
