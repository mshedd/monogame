using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameLibrary
{
	public class Player
	{
		public string Name { get; }
		protected List<Card> Deck{ get; }
		protected List<Card> Hand { get; }
		protected IPAddress Address { get; }
		public Player(string name, List<Card> deck, IPAddress ipaddress)
		{
			Name = name;
			Deck = deck;
            Hand = new List<Card>();
            Address = ipaddress;
		}
	}
}
