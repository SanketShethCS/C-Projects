using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
	class Warrior
	{
		public string Name { get; set; } = "Warrior";

		public double Health { get; set; } = 0;
		public double AttackMax { get; set; } = 0;
		public double BlockMax { get; set; } = 0;

		Random rnd = new Random();

		public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0)
		{
			Name = name;
			Health = health;
			AttackMax = attackMax;
			BlockMax = blockMax;
		}

		public double Attack()
		{
			return rnd.Next(1, (int)AttackMax);
		}

		public double Block()
		{
			return rnd.Next(1, (int)BlockMax);
		}


	}
}
