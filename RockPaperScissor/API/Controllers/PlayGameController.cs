using Models;
using System.Collections.Generic;
using System.Web.Http;

namespace API.Controllers
{

	public class PlayGameController : ApiController
    {
		[HttpPost]
		[Route("api/rps_game_winner")]
		public IHttpActionResult rps_game_winner(List<Player> listPlayers)
		{
			ValidateWinner validate = new ValidateWinner();
			validate.rps_game_winner(listPlayers);
			return Ok(listPlayers);
		}

		[HttpGet]
		[Route("api/rps_game_winner")]
		public IHttpActionResult rps_game_winner()
		{

			return Ok();
		}
	}
}
