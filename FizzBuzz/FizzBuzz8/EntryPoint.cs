using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz8 {
	class EntryPoint {

		static void Main(string[] args) {
			// 型推論
			var fizzBuzzCollection= new FizzBuzzElement[100];
			OverwriteMessages(fizzBuzzCollection, 2, "Fizz");
			OverwriteMessages(fizzBuzzCollection, 4, "Buzz");

			// LINQ
			// ラムダ式
			fizzBuzzCollection.Select((x, i) => {
				// Null合体演算子
				x.OutputMessage ??= i.ToString();
				return x;
			}).ToList().ForEach(x => Console.WriteLine(x));
		}

		private static void OverwriteMessages(IEnumerable<FizzBuzzElement> target, int skipCount, string message) {
			var skipped = target.Skip(skipCount);
			skipped.First().OutputMessage += message;
			OverwriteMessages(skipped.Skip(1), skipCount, message);
		}

		private class FizzBuzzElement {
			// 自動プロパティ
			// Null許容参照型
			public string? OutputMessage { get; set; }
		}

	}
}

