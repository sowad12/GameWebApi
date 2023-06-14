using GameShopWebApi.Commands;
using GameShopWebApi.GenericRepo;
using GameShopWebApi.Model;
using MediatR;

namespace GameShopWebApi.Handlers
{
	public class LoginHandler : IRequestHandler<LoginCommand, string>

	{
		private readonly IGame<Login> _obj;
		public LoginHandler(IGame<Login> obj)
		{
			_obj = obj;
		}

		public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
		{
			
			Login obj = new Login()
			{
				UserName = request.UserName,
				Password = request.Password,
			};

			return await _obj.LoginData(obj);
		}

		
	}
}


