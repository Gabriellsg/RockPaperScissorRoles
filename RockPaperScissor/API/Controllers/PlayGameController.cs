using API.Interface;
using Business;
using Models.Models;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace API.Controllers
{

	public class PlayGameController : ApiController
	{
		private ValidateWinner validate = new ValidateWinner();
		

		[HttpPost]
		[Route("api/rps_game_winner")]
		public IHttpActionResult rps_game_winner(List<Player> listPlayers)
		{
			Response response = validate.rps_game_winner(listPlayers);

			if (response.StatusCode == HttpStatusCode.OK)
			{
				List<Player> winner = (List<Player>)response.Data;
				return Ok(winner);
			}
			else
			{
				return BadRequest(response.Message);
			}
		}

		[HttpPost]
		[Route("api/rps_tournament_winner")]
		public IHttpActionResult rps_tournament_winner(List<List<Player>> listTournament)
		{
			List<Player> playerWinner = new List<Player>();
			Response response = validate.rps_tournament_winner(listTournament);

			if (response.StatusCode == HttpStatusCode.OK)
			{
				playerWinner = (List<Player>)response.Data;
				return Ok(playerWinner);
			}
			else
			{
				return BadRequest(response.Message);
			}
		}
	}
}
