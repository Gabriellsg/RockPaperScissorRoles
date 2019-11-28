using Models.Models;
using System.Collections.Generic;

namespace API.Interface
{
	public interface IValidateWinner
	{
		Response rps_game_winner(List<Player> listPlayers);

		Response rps_tournament_winner(List<List<Player>> listTournament);
	}
}
