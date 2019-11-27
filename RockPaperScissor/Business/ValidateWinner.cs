using API.Interface;
using System.Collections.Generic;

namespace Models
{
	public class ValidateWinner : IValidateWinner
	{
		public List<Player> rps_game_winner(List<Player> listPlayers)
		{

			this.validateWinner(listPlayers);

			return listPlayers;
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
			} else
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
