using System.IO;
using System.Linq;

namespace AdventOfCode2018.Day1
{
	public static class Day1
	{
		public static int Solve()
		{
			return File.ReadAllLines(@"C:\git\AdventOfCode2018\Day1\Day1Input.txt").Sum(line => int.Parse(line));
		}
	}
}
