using GameShopWebApi.Commands;
using GameShopWebApi.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GameShopWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : Controller
	{
		private IMediator _mediator;
		public AuthController(IMediator mediator)
		{
			_mediator = mediator;
		}

		//[HttpPost("[action]")]

		//public async Task<Customer> CustomerCreate([FromBody] Customer obj)
		//{

		//	var model = new CreateDataCommand(obj.FirstName, obj.LastName, obj.Age);
		//	return await _mediator.Send(model);


		//}


		[HttpPost("[action]")]
		public async Task<bool> RegisterUser(Login user)
		{
			var model=new RegisterCommand(user.UserName, user.Password);
				return await _mediator.Send(model);
			//return true;
		}


		[HttpPost("[action]")]
		public async Task<string> LoginUser(Login user)
		{
			var model = new LoginCommand(user.UserName, user.Password);
			return await _mediator.Send(model);
			//return true;
		}

		
	}
}
