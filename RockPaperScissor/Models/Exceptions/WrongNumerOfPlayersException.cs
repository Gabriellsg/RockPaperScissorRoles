﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Exceptions
{
	public class WrongNumerOfPlayersException : Exception
	{
		public WrongNumerOfPlayersException()
		{
				
		}
		public WrongNumerOfPlayersException(string message) : base (message)
		{
			
		}
	}
}