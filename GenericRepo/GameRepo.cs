using Dapper;
using GameShopWebApi.Data;
using GameShopWebApi.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GameShopWebApi.GenericRepo
{
	public class GameRepo<T> : IGame<T> where T : class
	{
		
		private readonly UserManager<IdentityUser> _userManager;
		private readonly IConfiguration _config;

		private readonly ApplicationDbContext _db2;
		private readonly DapperContext _db;
		DbSet<T> _entity = null;
		public GameRepo(DapperContext db, ApplicationDbContext db2, UserManager<IdentityUser> userManager, IConfiguration config)
		{
			_db = db;
			_db2 = db2;
			_entity = _db2.Set<T>();
			_userManager = userManager;
			_config = config;
		}

		//public async Task<T> CreateData(T obj)
		//{
		//	//var data=	_entity.Add(obj);

		//	//_db.SaveChanges();
		//	//return data.Entity;

	
		//	//var query = "insert into companies(firstName,lastName,age) values(@firstName,@lastName,@age)";
		//	//var parameters = new DynamicParameters();
		//	//parameters.Add("Name", obj.FirstName,);

		//	throw new NotImplementedException();
		//}

		public async Task<Customer> CreateData(Customer obj)
		{
			//var data=	_entity.Add(obj);

			//_db.SaveChanges();
			//return data.Entity;

		
			var query = "insert into customers(FirstName,LastName,Age) values(@FirstName,@LastName,@Age)"+
				"select cast(SCOPE_IDENTITY()AS int)";
			var parameters = new DynamicParameters();
			parameters.Add("FirstName", obj.FirstName,DbType.String);
			parameters.Add("LastName", obj.LastName,DbType.String);
			parameters.Add("Age", obj.Age,DbType.Int64);
			using (var connection = _db.CreateConnection())
			{
				//await connection.ExecuteAsync(query,parameters);
				var id = await connection.QuerySingleAsync<int>(query, parameters);
				var customerObj = new Customer
				{
					Id = id,
					FirstName = obj.FirstName,
					LastName = obj.LastName,
					Age = obj.Age,
				};
				return customerObj;
			}
			//throw new NotImplementedException();
		}

		public Task<T> CreateData(T obj)
		{
			//var data = _entity.Add(obj);

			//_db2.SaveChanges();
			//return data.Entity;
			throw new NotImplementedException();
		}

		public async Task<int> DeleteData(int id)
		{
			//_entity.Remove(obj);
			////_db.SaveChanges();
			//return await _db.SaveChangesAsync();

			var query = "delete from customers where id=@Id";
			using (var connection = _db.CreateConnection())
			{
				await connection.ExecuteAsync(query, new {Id=id});
				//await connection.QuerySingleOrDefaultAsync<T>(query, new { Id = id });

				return 1;
			}
		}

		public async Task<List<T>> GetAllData()
		{
			//using Enity Framework
			//return await _entity.ToListAsync();

			//using dapper
			var query = "SELECT * From Customers";
			using(var connection=_db.CreateConnection())
			{
				var data=await connection.QueryAsync<T>(query);
				return data.ToList();
			}
		}
	
		public async Task<T> GetSingleData(int id)
		{
			//return _entity.Find(id);
			



			var query = "SELECT * FROM Customers WHERE id=@Id";
			using (var connection = _db.CreateConnection())
			{
				var data = await connection.QuerySingleOrDefaultAsync<T>(query, new { Id = id });
		

				return data;
			}
		
		}

		public Task<int> lol(T obj)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> RegisterData(Login obj)
		{
			var identityUser = new IdentityUser
			{
				UserName=obj.UserName,
				Email=obj.UserName

			};
			var result = await _userManager.CreateAsync(identityUser, obj.Password);
			
			return result.Succeeded;
		}

		public async Task<string> LoginData(Login obj)
		{
			var identityUser = await _userManager.FindByEmailAsync(obj.UserName);

			if (identityUser == null) return "false";

			//return await _userManager.CheckPasswordAsync(identityUser, obj.Password);
			if(await _userManager.CheckPasswordAsync(identityUser, obj.Password))
			{
				var claims = new List<Claim>
			{
				new Claim(ClaimTypes.Email,obj.UserName),
				new Claim(ClaimTypes.Role,"Admin"),
			};

				var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("Jwt:Key").Value));

				var signingCred = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

				var securityToken = new JwtSecurityToken(
					claims: claims,
					expires: DateTime.Now.AddMinutes(60),
					issuer: _config.GetSection("Jwt:Issuer").Value,
					audience: _config.GetSection("Jwt:Audience").Value,
					signingCredentials: signingCred);

				string tokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);
				return tokenString;
			}
			return "false";
		}
		public async Task<int> UpdateData(T obj)
		{
			//_entity.update(obj);
			//_db.savechanges();
			//return await _entity.countasync();



			var query = "update customers set FirstName=@FirstName,LastName=@LastName,Age=@Age where id=@Id";
			using (var connection = _db.CreateConnection())
			{
				 await connection.ExecuteAsync(query,obj);
				//await connection.QuerySingleOrDefaultAsync<T>(query, new { Id = id });

				return 1;
			}
			
			}

		public string GenerateToken(Login user)
		{
			throw new NotImplementedException();
		}
	}
}