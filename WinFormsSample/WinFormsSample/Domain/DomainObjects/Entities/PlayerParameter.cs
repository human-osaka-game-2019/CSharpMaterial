using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using WinFormSample.Infrastructures;

namespace WinFormSample.Domain.DomainObjects.Entities {
	/// <summary>
	/// プレイヤーのパラメータ格納用データクラス。
	/// </summary>
	[DataContract]
	public partial class PlayerParameter {

		#region enums
		/// <summary>
		/// 職業の種類。
		/// </summary>
		public enum JobType {
			/// <summary>剣士。</summary>
			Knight = 10,
			/// <summary>魔法使い。</summary>
			Witch = 20,
			/// <summary>忍者。</summary>
			Ninja = 30
		}
		#endregion

		#region properties
		/// <summary>
		/// 名前。
		/// </summary>
		[DataMember]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// 性別。
		/// </summary>
		/// <remarks><c>true</c>: 男性 <c>false</c>: 女性</remarks>
		[DataMember]
		public bool IsMale { get; set; }

		/// <summary>
		/// 火属性への耐性があるかどうか。
		/// </summary>
		[DataMember]
		public bool IsTolerantOfFire { get; set; }

		/// <summary>
		/// 氷属性への耐性があるかどうか。
		/// </summary>
		[DataMember]
		public bool IsTolerantOfIce { get; set; }

		/// <summary>
		/// 風属性への耐性があるかどうか。
		/// </summary>
		[DataMember]
		public bool IsTolerantOfWind { get; set; }

		/// <summary>
		/// 雷属性への耐性があるかどうか。
		/// </summary>
		[DataMember]
		public bool IsTolerantOfThunder { get; set; }

		///// <summary>
		///// 能力のタイプ。
		///// </summary>
		//[DataMember]
		//public PlayerParameterType ParameterType { get; set; }

		/// <summary>
		/// 能力のタイプ。
		/// </summary>
		[DataMember]
		public string ParameterType { get; set; } = string.Empty;

		/// <summary>
		/// 職業。
		/// </summary>
		[DataMember]
		public JobType Job { get; set; }
		#endregion

		#region public static methods
		/// <summary>
		/// プレイヤー情報をファイルに保存する。
		/// </summary>
		/// <param name="value">保存する情報</param>
		/// <param name="filePath">保存先ファイルパス</param>
		/// <remarks>同期版</remarks>
		public static void Save(PlayerParameter value, string filePath) { 
			// XML出力
			XmlIO.WritePlayerParameter(value, AddExtension(filePath, XmlIO.Extension));

			// JSON出力
			//var jsonTask = JsonIO.WriteAsync(value, AddExtension(filePath, JsonIO.Extension));
		}

		/// <summary>
		/// プレイヤー情報をファイルに保存する。
		/// </summary>
		/// <param name="value">保存する情報</param>
		/// <param name="filePath">保存先ファイルパス</param>
		/// <remarks>非同期版</remarks>
		public static async Task SaveAsync(PlayerParameter value, string filePath) {
			// XML出力
			var xmlTask = XmlIO.WriteAsync(value, AddExtension(filePath, XmlIO.Extension));

			// JSON出力
			var jsonTask = JsonIO.WriteAsync(value, AddExtension(filePath, JsonIO.Extension));

			await Task.WhenAll(xmlTask, jsonTask);
		}

		/// <summary>
		/// プレイヤー情報をXMLファイルから読み込む。
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		/// <returns>読み込んだデータを格納したオブジェクト</returns>
		/// <remarks>同期版</remarks>
		public static PlayerParameter? Load(string filePath) {
			return XmlIO.ReadPlayerParameter(filePath);
		}

		/// <summary>
		/// プレイヤー情報をファイルから読み込む。
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		/// <returns>読み込んだデータを格納したオブジェクト</returns>
		/// <remarks>非同期版</remarks>
		public static async Task<PlayerParameter?> LoadAsync(string filePath) {
			// 拡張子で判断してデシリアライズ
			return Path.GetExtension(filePath)?.ToLower() switch {
				XmlIO.Extension => await XmlIO.ReadAsync<PlayerParameter>(filePath),
				JsonIO.Extension => await JsonIO.ReadAsync<PlayerParameter>(filePath),
				_ => null
			};
		}
		#endregion

		#region private static methods
		/// <summary>
		/// ファイルパスに拡張子を付与する。
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		/// <param name="extention">拡張子</param>
		/// <returns>拡張子が付与されたファイルパス</returns>
		private static string AddExtension(string filePath, string extention) {
			return Path.ChangeExtension(filePath, extention);
		}
		#endregion

	}
}

