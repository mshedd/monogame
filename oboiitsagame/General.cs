using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameLibrary
{
	public abstract class General : Entity
	{
		protected bool IsReady { get; }
		public General(Game game, int range, int attack, int health) : base(game, range, attack, health)
		{

		}
	}
}