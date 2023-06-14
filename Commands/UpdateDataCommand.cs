using GameShopWebApi.Model;
using MediatR;

namespace GameShopWebApi.Commands
{
	public class UpdateDataCommand:IRequest<int>
	{
		public UpdateDataCommand(int id,string fname, string lname, int age)
		{
			Id = id;
			FirstName = fname;
			LastName = lname;
			Age = age;
		}
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
	}
}
