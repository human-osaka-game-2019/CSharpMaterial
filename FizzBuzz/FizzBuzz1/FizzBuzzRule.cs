using System;
using System.Linq;

namespace FizzBuzz1 {

	public class FizzBuzzRule {

		// Flags属性
		[Flags]
		public enum FizzBuzzType {
			Fizz = 3,
			Buzz = 5
		}

		// プロパティ
		public static  FizzBuzzType[] All => Enum.GetValues(typeof(FizzBuzzType)).OfType<FizzBuzzType>().ToArray();

		public static FizzBuzzType? Convert(int value) {
			// Null許容値型
			FizzBuzzType? ret = All.Aggregate((FizzBuzzType?)null, (current, next) => 
				// switch式
				(int)next switch {
					// パターンマッチング
					int x when value % x == 0 => 
						current switch {
							null => next,
							_ => current | next
						},
					_ => current
				} 
			);

			return ret;
		}

	}
}

