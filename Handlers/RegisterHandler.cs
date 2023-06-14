using GameShopWebApi.Commands;
using GameShopWebApi.GenericRepo;
using GameShopWebApi.Model;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace GameShopWebApi.Handlers
{
	public class RegisterHandler : IRequestHandler<RegisterCommand, bool>

	{
		private readonly IGame<Login> _obj;
		public RegisterHandler(IGame<Login> obj)
		{
			_obj = obj;
		}

		public async Task<bool> Handle(RegisterCommand request, CancellationToken cancellationToken)
		{
			//var identity = new IdentityUser
			//{
			//	UserName = request.UserName,

			//};
			Login obj = new Login()
			{
				UserName = request.UserName,
				Password = request.Password,
			};

			return await _obj.RegisterData(obj);
		}

	
	}
}

