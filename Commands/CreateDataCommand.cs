using GameShopWebApi.Model;
using MediatR;

namespace GameShopWebApi.Commands
{
	public class CreateDataCommand:IRequest<Customer>
	{
        public CreateDataCommand(string fname, string lname,int age)
        {
            FirstName = fname;
            LastName = lname;
            Age=age;
        }
          public string FirstName { get; set; }
          public string LastName { get; set; }
          public  int Age { get; set; }
	}
	/*public class CreateDataCommand2 : IRequest<Customer>
	{
		public CreateDataCommand2(string fname, string lname, int age)
		{
			FirstName = fname;
			LastName = lname;
			Age = age;
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
	}*/
}
