using System.Runtime.Serialization;

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
		public string Name { get; set; } = null!;

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
		public PlayerParameterType ParameterType { get; set; }

		/// <summary>
		/// 職業。
		/// </summary>
		[DataMember]
		public JobType Job { get; set; }
		#endregion

	}
}

