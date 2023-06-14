using GameShopWebApi.Commands;
using GameShopWebApi.GenericRepo;
using GameShopWebApi.Model;
using GameShopWebApi.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameShopWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class customerController : Controller
	{
		private IMediator _mediator;
		public customerController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet("[action]/{CustomerId}")]
		public async Task<Customer> GetSingleCustomerData(int CustomerId)
		{

     	//var data=await _mediator.Send(new GetSingleDataQuery(GameId) );

			var data = await _mediator.Send(new GetSingleDataQuery() { Id = CustomerId });
			return data;
		}

		[Route("[action]")]
		[HttpGet]
		public async Task<List<Customer>> GetAllCustomers()
		{

			var data = await _mediator.Send(new GetAllDataQuery());
			return data;
		}





	
		[HttpPost("[action]")]

		public async Task<Customer> CustomerCreate([FromBody] Customer obj)
		{

			var model=new CreateDataCommand(obj.FirstName,obj.LastName,obj.Age);
		    return await _mediator.Send(model);


		}


		
	[HttpPut("[action]")]

	public async Task<int> CustomerUpdate([FromBody] Customer obj)
	{

			
			var model = new UpdateDataCommand(obj.Id,obj.FirstName, obj.LastName, obj.Age);
			return await _mediator.Send(model);


	}
		
			[HttpDelete("[action]/{CustomerId}")]
			public async Task<int> DeleteCustomerData(int CustomerId)
			{

				var model=new DeleteDataCommand(CustomerId);
			return await _mediator.Send(model);

			}
	}
}
