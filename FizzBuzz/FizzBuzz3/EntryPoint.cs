using FizzBuzz3.FizzBuzzRule;
using System;
using System.Linq;

namespace FizzBuzz3 {
	public class EntryPoint {

		// readonly
		private static readonly IFizzBuzzRule[] rules = { FizzRule.Instance, BuzzRule.Instance, NonFizzBuzzRule.Instance };

		public static void Main(string[] args) {
			// LINQ
			Enumerable.Range(1, 100).ToList().ForEach(i => {
				var outputStr = string.Empty;
				// ref
				Array.ForEach(rules, x => x.Judge(i, ref outputStr));
				Console.WriteLine(outputStr);
			});
		}

	}
}

