using GameShopWebApi.GenericRepo;
using GameShopWebApi.Model;
using GameShopWebApi.Queries;
using MediatR;

namespace GameShopWebApi.Handlers
{
	public class GetAllDataHandler : IRequestHandler<GetAllDataQuery, List<Customer>>
	{
		private readonly IGame<Customer>  _obj;
        public GetAllDataHandler(IGame<Customer> obj)
        {
            _obj = obj;
        }

		public async Task<List<Customer>> Handle(GetAllDataQuery request, CancellationToken cancellationToken)
		{
			return await _obj.GetAllData();

		}

		/*public Task<List<Game>> Handle(Queries.GetAllDataQuery request, CancellationToken cancellationToken)
		{
			return await _obj.GetAllData();
		}*/
	}
}
