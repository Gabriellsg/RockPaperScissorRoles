using API.Interface;
using Models.Exceptions;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Business
{
	public class ValidateWinner : IValidateWinner
	{
		public Response rps_game_winner(List<Player> listPlayers)
		{
			try
			{
				this.validateRequest(listPlayers);
				var list = this.validateWinner(listPlayers);

				return new Response
				{
					Data = list,
					StatusCode = HttpStatusCode.OK
				};

			}
			catch (Exception ex)
			{
				return new Response
				{
					StatusCode = HttpStatusCode.BadRequest,
					Message = ex.Message
				};
			}
		}

		public Response rps_tournament_winner(List<List<Player>> listTournament)
		{
			try
			{
				List<List<Player>> listAux = new List<List<Player>>();

				while (listTournament.Count > 2 || listAux.Count >= 2)
				{
					if (listTournament.Count > 0)
					{
						for (int index = 0; index < listTournament.Count; index++)
						{
							this.validateWinner(listTournament[index]);
						}
					}
					else if (listAux.Count > 0)
					{
						for (int index = 0; index < listAux.Count; index++)
						{
							this.validateWinner(listAux[index]);
						}

						listTournament.AddRange(listAux);
						listAux.RemoveRange(0, listAux.Count);
					}

					for (int count = 0; count < listTournament.Count; count += 2)
					{
						int index = count + 1;

						List<Player> listPlayer = new List<Player>
						{
							listTournament[count].First(),
							listTournament[index].First()
						};
						listAux.Add(listPlayer);
					}

					listTournament.RemoveRange(0, listTournament.Count);
				}

				var winner = this.validateWinner(listAux.First());

				return new Response
				{
					Data = winner,
					StatusCode = HttpStatusCode.OK
				};

			}
			catch (Exception ex)
			{
				return new Response
				{
					StatusCode = HttpStatusCode.BadRequest,
					Message = ex.Message
				};
			}


		}

		private void validateRequest(List<Player> listPlayers)
		{

			if (listPlayers.Count < 2)
			{
				throw new WrongNumerOfPlayersException("The number of players is not equal to 2!");
			}

			foreach (var item in listPlayers)
			{
				List<string> typesWeapon = new List<string>
				{
					"R","P","S"
				};

				if (!typesWeapon.Contains(item.Weapon))
				{
					throw new WrongNumerOfPlayersException("The type of weapon is invalid!");
				}

			}
		}


		private List<Player> validateWinner(List<Player> list)
		{

			if (list[0].Weapon.Contains("R") && list[1].Weapon.Contains("R"))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Weapon.Equals("R"))
					{
						list.RemoveAt(i + 1);
					}
				}
				return list;
			}
			else if (list[0].Weapon.Contains("P") && list[1].Weapon.Contains("P"))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Weapon.Equals("P"))
					{
						list.RemoveAt(i + 1);
					}
				}
				return list;
			}
			else if (list[0].Weapon.Contains("S") && list[1].Weapon.Contains("S"))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Weapon.Equals("S"))
					{
						list.RemoveAt(i + 1);
					}
				}
				return list;
			}
			else if (list[0].Weapon.Contains("R") && list[1].Weapon.Contains("S"))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Weapon.Equals("S"))
					{
						list.RemoveAt(i);
					}
				}
				return list;
			}
			else if (list[0].Weapon.Contains("S") && list[1].Weapon.Contains("R"))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Weapon.Equals("S"))
					{
						list.RemoveAt(i);
					}
				}
				return list;
			}
			else if (list[0].Weapon.Contains("R") && list[1].Weapon.Contains("P"))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Weapon.Equals("R"))
					{
						list.RemoveAt(i);
					}
				}
				return list;
			}
			else if (list[0].Weapon.Contains("P") && list[1].Weapon.Contains("R"))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Weapon.Equals("R"))
					{
						list.RemoveAt(i);
					}
				}
				return list;
			}
			else if (list[0].Weapon.Contains("P") && list[1].Weapon.Contains("S"))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Weapon.Equals("P"))
					{
						list.RemoveAt(i);
					}
				}
				return list;
			}
			else
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Weapon.Equals("P"))
					{
						list.RemoveAt(i);
					}
				}
				return list;
			}
		}

	}
}
