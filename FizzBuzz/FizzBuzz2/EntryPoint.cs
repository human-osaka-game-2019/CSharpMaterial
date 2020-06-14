using System;
using System.Linq;

namespace FizzBuzz2 {
	public class EntryPoint {

		// タプル
		// readonly
		private static readonly Tuple<int, string>[] FizzBuzzRules = { Tuple.Create(3, "Fizz"), Tuple.Create(5, "Buzz") };

		public static void Main(string[] args) {
			// LINQ
			// ラムダ式
			Enumerable.Range(1, 100).ToList().ForEach(i => {
				Console.WriteLine(ToFizzBuzz(i));
			});
		}

		private static string ToFizzBuzz(int value) {
			// LINQのクエリ式
			var fizzBuzz = from x in FizzBuzzRules
							let y = value % x.Item1 == 0 ? x.Item2 : string.Empty
							where !string.IsNullOrEmpty(y)
							select y;

			// 上記と同じ処理のラムダ式バージョン
			//var fizzBuzz = FizzBuzzRules.Select(x => value % x.Item1 == 0 ? x.Item2 : string.Empty)
			//				.Where(x => !string.IsNullOrEmpty(x));

			var ret = string.Join(null, fizzBuzz);
			if (ret.Length == 0) {
				ret = value.ToString();
			}

			return ret;
		}

	}
}

