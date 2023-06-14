using MediatR;

namespace GameShopWebApi.Commands
{
	public class LoginCommand : IRequest<string>
	{
		public LoginCommand(string uname, string pass)
		{
			UserName = uname;
			Password = pass;
		}

		public string UserName { get; set; }
		public string Password { get; set; }

	}



}
