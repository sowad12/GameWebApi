//using GameShopWebApi.GenericRepo;
//using GameShopWebApi.Model;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;

//namespace GameShopWebApi.Controllers
//{
//	[Route("api/[controller]")]
//	[ApiController]
//	public class ReviewController : Controller
//	{
//		private readonly IGame<Review> _ReviewObj;

//		public ReviewController(IGame<Review> ReviewObj)
//		{
//			_ReviewObj = ReviewObj;
//		}

//		[HttpGet("[action]/{ReviewId}")]
//		public IActionResult GetSingleReviewData(int CustomerId)
//		{

//			var data = _ReviewObj.GetSingleData(CustomerId);
//			return Ok(data);
//		}

//		[Route("[action]")]
//		[HttpGet]
//		public IActionResult GetAllReviewes()
//		{
//			var data = _ReviewObj.GetAllData();
//			return Ok(data);
//		}


//		[HttpPost("[action]")]

//		public IActionResult ReviewCreate([FromBody] Review obj)
//		{


//			_ReviewObj.CreateData(obj);

//			return Ok("Data created");


//		}



//		[HttpPut("[action]")]

//		public IActionResult ReviewUpdate([FromBody] Review obj)
//		{


//			_ReviewObj.UpdateData(obj);

//			return Ok("Data updated");


//		}

//		[HttpDelete("[action]/{ReviewId}")]
//		public IActionResult DeleteReviewData(int ReviewId)
//		{

//			var ReviewData = _ReviewObj.GetSingleData(ReviewId);


//			//_ReviewObj.DeleteData(ReviewData);

//			return Ok("Delete Sucess");



//		}
//	}
//}
