﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz5 {
	public class EntryPoint {

		public static void Main(string[] args) {
			// 型推論
			var rules = new List<FizzBuzzRule>();
			// ラムダ式
			rules.Add(new FizzBuzzRule(x => x % 3 == 0, "Fizz"));
			rules.Add(new FizzBuzzRule(x => x % 5 == 0, "Buzz"));

			// LINQ
			new string[100].Select((_, i) => {
				var number = i + 1;
				var outputStr = string.Empty;
				var matches = false;
				// ref
				rules.ForEach(x => matches = (matches | x.Judge(number, ref outputStr)));
				if (!matches) {
					outputStr = number.ToString();
				}
				return outputStr;
			}).ToList().ForEach(x => Console.WriteLine(x));
		}

	}
}

