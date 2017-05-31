using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameLibrary
{
	public abstract class Card : DrawableGameComponent
	{
		protected string Name;
		protected int Cost;
		protected Texture2D Image;
        protected Rectangle Rectangle;

		public Card(Game game) : base(game)
		{

		}
	}
}