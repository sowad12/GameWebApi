using GameShopWebApi.Model;

namespace GameShopWebApi.GenericRepo
{
	public interface IGame< T> where T : class
	{
		Task<List<T>> GetAllData();
		
		Task<T> GetSingleData(int id);
		
		Task<T> CreateData(T obj);
		Task<Customer> CreateData(Customer obj);
		
		Task<int> UpdateData(T obj);
		Task<int> DeleteData(int id);
		Task<bool>RegisterData(Login obj);
		Task<string>LoginData(Login obj);
		string GenerateToken(Login user);
		Task<int>lol(T obj);	
		
	}
}
