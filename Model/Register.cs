using System.ComponentModel.DataAnnotations;

namespace GameShopWebApi.Model
{
	public class Register
	{
		[Required(ErrorMessage = "User name is required")]
		public string UserName { get; set; }


		[Required(ErrorMessage = "Email is required")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password  is required")]
		public string Password { get; set; }
	}
}
