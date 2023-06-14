using GameShopWebApi.Commands;
using GameShopWebApi.GenericRepo;
using GameShopWebApi.Model;
using MediatR;

namespace GameShopWebApi.Handlers
{
	public class DeleteDataHandler : IRequestHandler<DeleteDataCommand, int>
	{
		private readonly IGame<Customer> _obj;
		public DeleteDataHandler(IGame<Customer> obj)
		{
			_obj = obj;
		}
		public async Task<int> Handle(DeleteDataCommand request, CancellationToken cancellationToken)
		{
			//var customer = await _obj.GetSingleData(request.Id);
			var customer = await _obj.GetSingleData(request.Id);
			if (customer == null) return default;

			return await _obj.DeleteData(request.Id);


		}
	}
}
