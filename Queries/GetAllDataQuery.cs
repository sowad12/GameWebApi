using GameShopWebApi.Model;
using MediatR;

namespace GameShopWebApi.Queries
{

	//public record GetAllDataQuery : IRequest<List<Game>> ;

	public class GetAllDataQuery:IRequest<List<Customer>>
	{
		//public int Id { get; set; }	

	}
}
