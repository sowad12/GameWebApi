using GameShopWebApi.Commands;
using GameShopWebApi.GenericRepo;
using GameShopWebApi.Model;
using MediatR;

namespace GameShopWebApi.Handlers
{
	public class UpdateDataHandler : IRequestHandler<UpdateDataCommand, int>
	{
		private readonly IGame<Customer> _obj;
		public UpdateDataHandler(IGame<Customer> obj)
		{
			_obj = obj;
		}
		public async Task<int> Handle(UpdateDataCommand request, CancellationToken cancellationToken)
		{
			var customer = await _obj.GetSingleData(request.Id);
			if (customer == null) return default ;
			customer.Id = request.Id;
			customer.FirstName = request.FirstName;
			customer.LastName = request.LastName;
			customer.Age = request.Age;
			return await _obj.UpdateData(customer);

		
		}
	}
}
