using RPGClassSystem.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClassSystem.Core.Stats
{
	public class StatsSystem
	{
		public Dictionary<UnitStats, int> Stats { get; } =
			new Dictionary<UnitStats, int>()
			{
				{ UnitStats.Health, 0 }
			};
	}
}
