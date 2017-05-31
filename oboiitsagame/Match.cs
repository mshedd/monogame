using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameLibrary
{
    public class Match
    {
		public EventCard[] EventDeck { get; }
		public Player[] Players { get; }
		public Area[,] Board { get; }
        public Player currentTurn { get; }

		public Match(Game game, Player player1, Player player2)
		{
			Board = new Area[7, 7];
			for(int r = 0; r < Board.GetLength(0); r++)
			{
				for(int c = 0; c < Board.GetLength(1); c++)
				{
					Board[r, c] = new Area(game, r, c);
				}
			}
			Players = new Player[] { player1, player2 };

		}
    }
}
