using GameShopWebApi.Commands;
using GameShopWebApi.GenericRepo;
using GameShopWebApi.Model;
using MediatR;

namespace GameShopWebApi.Handlers
{
	public class CreateDataHandler : IRequestHandler<CreateDataCommand, Customer>
	
	{
		private readonly IGame<Customer> _obj;
		public CreateDataHandler(IGame<Customer> obj)
		{
			_obj = obj;
		}

		public async Task<Customer> Handle(CreateDataCommand request, CancellationToken cancellationToken)
		{
			Customer customer = new Customer()
			{
				FirstName = request.FirstName,
				LastName = request.LastName,
				Age = request.Age
			};

			return await _obj.CreateData(customer);
		}

		/*public Task<Customer> Handle(CreateDataCommand2 request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}*/
	}
}
