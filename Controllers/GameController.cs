/*using GameShopWebApi.GenericRepo;
using GameShopWebApi.Model;
using GameShopWebApi.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using System.Collections;
using System;
using System.Collections;
using System.Text;
namespace GameShopWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GameController : Controller
	{
		private readonly IGame<Game> _gameObj;
		private IMediator _mediator;
        public GameController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /*public GameController(IGame<Game> gameObj)
		{
			_gameObj = gameObj;
		}
       
		[HttpGet("[action]/{GameId}")]
		public async Task <Game> GetSingleGameData(int GameId)
		{

			
			//var data=await _mediator.Send(new GetSingleDataQuery(GameId) );
			var data=await _mediator.Send(new GetSingleDataQuery() { Id=GameId});
			return data;
		}
		
        [Route("[action]")]
		[HttpGet]
		public async Task<List<Game>> GetAllGames()
		{
		
			var data = await _mediator.Send(new GetAllDataQuery());
			return data;
		}

		





		/*
				[HttpPost("[action]")]


				public IActionResult GameCreate( [FromBody] Game obj)
				{


					_gameObj.CreateData(obj);

					return  Ok("Data created");


				}



				[HttpPut("[action]")]

				public IActionResult GameUpdate([FromBody] Game obj)
				{


					_gameObj.UpdateData(obj);

					return Ok("Data updated");


				}

				[HttpDelete("[action]/{GameId}")]
				public IActionResult DeleteGameData(int GameId)
				{

					var gameData = _gameObj.GetSingleData(GameId);


					_gameObj.DeleteData(gameData);

					return Ok("Delete Sucess");


				}
	}
}
*/