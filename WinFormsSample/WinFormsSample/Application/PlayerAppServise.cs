using System.IO;
using System.Threading.Tasks;
using WinFormSample.Domain.DomainObjects.Entities;
using WinFormSample.Infrastructures;

namespace WinFormSample.Application {
	/// <summary>
	/// プレイヤー画面のビジネスロジッククラス。
	/// </summary>
	public class PlayerAppService {

		#region public methods
		/// <summary>
		/// プレイヤー情報をファイルに保存する。
		/// </summary>
		/// <param name="value">保存する情報</param>
		/// <param name="filePath">保存先ファイルパス</param>
		/// <remarks>同期版</remarks>
		public void Save(PlayerParameter value, string filePath) {
			PlayerParameter.Save(value, filePath);
		}

		/// <summary>
		/// プレイヤー情報をファイルに保存する。
		/// </summary>
		/// <param name="value">保存する情報</param>
		/// <param name="filePath">保存先ファイルパス</param>
		/// <remarks>非同期版</remarks>
		public Task SaveAsync(PlayerParameter value, string filePath) {
			return PlayerParameter.SaveAsync(value, filePath);
		}

		/// <summary>
		/// プレイヤー情報をXMLファイルから読み込む。
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		/// <returns>読み込んだデータを格納したオブジェクト</returns>
		/// <remarks>同期版</remarks>
		public PlayerParameter? Load(string filePath) {
			return PlayerParameter.Load(filePath);
		}

		/// <summary>
		/// プレイヤー情報をファイルから読み込む。
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		/// <returns>読み込んだデータを格納したオブジェクト</returns>
		/// <remarks>非同期版</remarks>
		public Task<PlayerParameter?> LoadAsync(string filePath) {
			return PlayerParameter.LoadAsync(filePath);
		}
		#endregion

	}
}

