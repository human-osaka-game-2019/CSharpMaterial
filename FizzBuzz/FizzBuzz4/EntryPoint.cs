using System;
using System.Linq;

namespace FizzBuzzRule4 {
	public class EntryPoint {

		public static void Main(string[] args) {
			// LINQ
			Enumerable.Range(1, 100)
				.Select(x => {
					var ret = (x % 3 == 0 ? "Fizz" : string.Empty) + (x % 5 == 0 ? "Buzz" : string.Empty);
					if (string.IsNullOrEmpty(ret)) ret = x.ToString();
					return ret;
				}).ToList().ForEach(x => Console.WriteLine(x));
		}

	}
}

