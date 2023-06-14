using GameShopWebApi.Model;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameShopWebApi.Commands
{
	public class RegisterCommand:IRequest<bool>
	{
        public RegisterCommand(string uname, string pass)
	{
		UserName=uname;
		Password=pass;
	}
		
	public string UserName { get; set; }
	public string Password { get; set; }

}
	


}
