using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz5 {
	public class EntryPoint {
		public static void Main(string[] args) {

			var rules = new List<FizzBuzzRule>();
			// ラムダ式
			rules.Add(new FizzBuzzRule(x => x % 3 == 0, "Fizz"));
			rules.Add(new FizzBuzzRule(x => x % 5 == 0, "Buzz"));

			Enumerable.Range(1, 100).Select(i => {
				var outputStr = string.Empty;
				var matches = false;
				// ref
				rules.ForEach(x => matches = (matches | x.Judge(i, ref outputStr)));
				if (!matches) {
					outputStr = i.ToString();
				}
				return outputStr;
			}).ToList().ForEach(x => Console.WriteLine(x));

		}

	}
}

