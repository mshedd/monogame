using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameLibrary
{
	public abstract class Ability : Card
	{
		public abstract void effect();
        public abstract void effect(int x, int y);
		public Ability(Game game) : base(game)
		{

		}
	}
}