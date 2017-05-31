using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameLibrary
{
	public abstract class Entity : Card
	{
		private int RANGE, ATTACK, HEALTH, MAX_HEALTH, FATIGUE;
		
		public abstract void onPlay();
		public abstract void onAttack();
		public abstract void onDefense();

		public Entity(Game game, int range, int attack, int health) : base(game)
		{
			HEALTH = health;
			MAX_HEALTH = health;
			FATIGUE = 0;
			ATTACK = attack;
			RANGE = range;
		}
	}
}