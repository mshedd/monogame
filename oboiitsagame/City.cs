using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameLibrary
{
	public abstract class City : Entity
	{
		private string YEAR;
		private int LUMBER_INCOME, FOOD_INCOME, METAL_INCOME, TURNS_TO_BUILD;
		public City(Game game, int range, int attack, int health, int lumberIncome, int foodIncome, int metalIncome, int turns) : base(game, range, attack, health)
		{
			LUMBER_INCOME = lumberIncome;
            FOOD_INCOME = foodIncome;
            METAL_INCOME = metalIncome;
            TURNS_TO_BUILD = turns;
		}


	}
}