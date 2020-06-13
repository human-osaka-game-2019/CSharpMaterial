namespace WinFormSample.Domain.DomainObjects.Entities {
	/// <summary>
	/// 敵のパラメータ格納用データクラス。
	/// </summary>
	public class EnemyParameter {

		/// <summary>
		/// コンストラクタ。
		/// </summary>
		/// <param name="name">名前</param>
		/// <param name="hp">HP</param>
		/// <param name="isBoss">ボスかどうか</param>
		public EnemyParameter(string name, int hp, bool isBoss) {
			this.Name = name;
			this.Hp = hp;
			this.IsBoss = isBoss;
		}

		/// <summary>
		/// 名前。
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// HP.
		/// </summary>
		public int Hp { get; }

		/// <summary>
		/// ボスかどうか。
		/// </summary>
		public bool IsBoss { get; }

	}
}

