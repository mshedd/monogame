using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameLibrary
{
	public class Area : DrawableGameComponent
	{
		private int[] Coordinates;
		private Player Controller;
		private City CurrentCity;
        private int BuildCounter;
		private General General;

		public Area(Game game, int x, int y) : base(game)
		{
            Coordinates = new int[] { x, y };
            BuildCounter = -1;
		}

        
	}
}