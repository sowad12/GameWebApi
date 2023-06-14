using GameShopWebApi.Model;
using MediatR;

namespace GameShopWebApi.Commands
{
	public class DeleteDataCommand : IRequest<int>
	{
		public DeleteDataCommand(int id)
		{
			Id = id;
			
		}
		public int Id { get; set; }
		
	}
}
