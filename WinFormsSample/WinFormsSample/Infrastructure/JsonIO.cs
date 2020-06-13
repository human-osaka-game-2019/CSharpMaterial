﻿using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace WinFormSample.Infrastructures {
	/// <summary>
	/// JSON入出力クラス。
	/// </summary>
	public static class JsonIO {

		#region constants
		/// <summary>
		/// 拡張子。
		/// </summary>
		public const string Extension = ".json";
		#endregion

		#region public methods
		/// <summary>
		/// JSONファイルを読み込む。
		/// </summary>
		/// <typeparam name="T">読み込んだデータを格納する型</typeparam>
		/// <param name="filePath">読み込むファイルパス</param>
		/// <returns>読み込んだデータを<typeparamref name="T"/>型のオブジェクトに変換したもの</returns>
		public static async Task<T?> ReadAsync<T>(string filePath) where T : class {
			T? ret = default;

			// ファイル読込
			var serializer = new DataContractJsonSerializer(typeof(T));
			await using (var stream = File.Open(filePath, FileMode.Open)) {
				await Task.Run(() => ret = serializer.ReadObject(stream) as T);
			}

			return ret;
		}

		/// <summary>
		/// JSONファイルに書き出す。
		/// </summary>
		/// <typeparam name="T">書き出すオブジェクトの型</typeparam>
		/// <param name="target">出力対象のオブジェクト</param>
		/// <param name="filePath">出力先ファイルパス</param>
		public static async Task WriteAsync<T>(T target, string filePath) {
			var serializer = new DataContractJsonSerializer(typeof(T));
			await using (var stream = new FileStream(filePath, FileMode.OpenOrCreate)) {
				await Task.Run(() => {
					// 既存データ削除
					stream.SetLength(0);

					serializer.WriteObject(stream, target);
				});
			}
		}
		#endregion

	}
}

