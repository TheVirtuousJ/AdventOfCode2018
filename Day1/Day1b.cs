using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdventOfCode2018.Day1
{
	public static class Day1b
	{
		public static int Solve()
		{
			var lines = File.ReadAllLines(@"C:\git\AdventOfCode2018\Day1\Day1Input.txt");
			var set = new HashSet<int>();
			var freq = 0;
			var	index = 0;

			while (true)
			{
				freq += int.Parse(lines[index++]);

				if (!set.Add(freq))
				{
					return freq;
				}

				if (index >= lines.Length)
				{
					index = 0;
				}
			}

			return freq;
		}
	}
}
