using System;
using System.Linq;

namespace FizzBuzzRule4 {
	public class EntryPoint {

		public static void Main(string[] args) {
			// LINQ
			new string[100].Select((_, i) => {
				// 型推論
				var number = i + 1;
				var ret = (number % 3 == 0 ? "Fizz" : string.Empty) + (number % 5 == 0 ? "Buzz" : string.Empty);
				if (string.IsNullOrEmpty(ret)) ret = number.ToString();
				return ret;
			}).ToList().ForEach(x => Console.WriteLine(x));
		}

	}
}

