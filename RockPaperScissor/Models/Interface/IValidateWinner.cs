using Models;
using System.Collections.Generic;

namespace API.Interface
{
	public interface IValidateWinner
	{
		List<Player> rps_game_winner(List<Player> listPlayers);

	}
}
