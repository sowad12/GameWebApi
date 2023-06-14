using GameShopWebApi.GenericRepo;
using GameShopWebApi.Model;
using GameShopWebApi.Queries;
using MediatR;

namespace GameShopWebApi.Handlers
{
	public class GetSingleDataHandler : IRequestHandler<GetSingleDataQuery, Customer>
	{
		private readonly IGame<Customer> _obj;
		public GetSingleDataHandler(IGame<Customer> obj)
		{
			_obj = obj;
		}

		public async Task<Customer> Handle(GetSingleDataQuery request, CancellationToken cancellationToken)
		{
			return await _obj.GetSingleData(request.Id);
		}
	}
}
