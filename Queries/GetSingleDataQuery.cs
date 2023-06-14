using GameShopWebApi.Model;
using MediatR;

namespace GameShopWebApi.Queries
{
	public class GetSingleDataQuery:IRequest<Customer>
	{
		
		
		public int Id { get; set; }
		
	}
}
