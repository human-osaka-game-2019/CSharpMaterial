using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSample.Application;
using WinFormSample.Domain.DomainObjects.Entities;
using static WinFormSample.Domain.DomainObjects.Entities.PlayerParameter;

namespace WinFormSample.Presentation {
	/// <summary>
	/// プレイヤー画面クラス。
	/// </summary>
	public partial class FrmPlayer : Form {

		#region field members
		/// <summary>
		/// ビジネスロジッククラス。
		/// </summary>
		private PlayerAppService appService = new PlayerAppService();
		#endregion

		#region constructors
		/// <summary>
		/// コンストラクタ。
		/// </summary>
		public FrmPlayer() {
			InitializeComponent();

			this.Initialize();
		}
		#endregion

		#region private methods

		#region event handlers
		/// <summary>
		/// 保存ボタンクリックイベント。
		/// </summary>
		/// <param name="sender">イベント発行元</param>
		/// <param name="e">イベントパラメータ</param>
		private async void BtnSave_Click(object sender, EventArgs e) {
			// 保存ダイアログ表示
			var dialog = new SaveFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK) {
				var filePath = dialog.FileName;

				var player = new PlayerParameter() {
					Name = this.txtName.Text,
					IsMale = this.rbtnMale.Checked,
					IsTolerantOfFire = this.chkIsTolerantOfFire.Checked,
					IsTolerantOfIce = this.chkIsTolerantOfIce.Checked,
					IsTolerantOfWind = this.chkIsTolerantOfWind.Checked,
					IsTolerantOfThunder = this.chkIsTolerantOfThunder.Checked,

					// コンボボックスの選択項目を取得
					// [表示文字をそのまま取得する場合]
					ParameterType = this.cmbParameterType.SelectedItem.ToString()!,
					// [選択されているものに対応するコードを取得してEnumに変換する場合]
					//ParameterType = (PlayerParameter.PlayerParameterType)this.cmbParameterType.SelectedValue,

					// ラジオボタンの選択項目を取得
					// [LINQを使用して1行で行う場合]
					// 職業のGroupBoxの中に配置されているRadioButtonの中で選択状態のもののTagを取得
					//Job = (JobType)this.grbJob.Controls.OfType<RadioButton>().First(x => x.Checked).Tag
				};

				// ラジオボタンの選択項目を取得
				// [if文で1つずつ確認していく場合]
				if (this.rbtnKnight.Checked) {
					player.Job = JobType.Knight;
				} else if(this.rbtnWitch.Checked) {
					player.Job = JobType.Witch;
				} else {
					player.Job = JobType.Ninja;
				}

				// [同期版]
				this.appService.Save(player, filePath);
				// [非同期版]
				//await this.service.SaveAsync(player, filePath);
			}
		}

		/// <summary>
		/// 読込ボタンクリックイベント。
		/// </summary>
		/// <param name="sender">イベント発行元</param>
		/// <param name="e">イベントパラメータ</param>
		private async void BtnLoad_Click(object sender, EventArgs e) {
			// ファイルを開くダイアログ表示
			var dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK) {
				// ファイル読込
				// [同期版]
				var player = this.appService.Load(dialog.FileName);
				// [非同期版]
				//var player = await this.service.LoadAsync(dialog.FileName);

				// 読み込めた場合は画面に表示
				if (player != null) {
					this.txtName.Text = player.Name;
					(player.IsMale ? this.rbtnMale : this.rbtnFemale).Checked = true;
					this.chkIsTolerantOfFire.Checked = player.IsTolerantOfFire;
					this.chkIsTolerantOfIce.Checked = player.IsTolerantOfIce;
					this.chkIsTolerantOfWind.Checked = player.IsTolerantOfWind;
					this.chkIsTolerantOfThunder.Checked = player.IsTolerantOfThunder;

					// コンボボックスの選択項目を変更する
					// [PlayerParameterクラスのプロパティの値をそのまま表示する場合]
					this.cmbParameterType.SelectedItem = player.ParameterType;
					// [Enumを数値に変換して紐付ける場合]
					//this.cmbParameterType.SelectedValue = (int)player.ParameterType;

					// 職業のGroupBoxの中に配置されているRadioButtonの中でTagが一致するものを選択状態にする
					this.grbJob.Controls.OfType<RadioButton>().First(x => (JobType)x.Tag == player.Job).Checked = true;
				}
			}
		}
		#endregion

		/// <summary>
		/// 初期化処理。
		/// </summary>
		private void Initialize() {
			this.CreateParameterTypeDataSource();
			this.SetJobControlTags();
			this.DisplayInitialValues();
		}

		/// <summary>
		/// <see cref="cmbParameterType"/>にデータを設定する。
		/// </summary>
		private void CreateParameterTypeDataSource() {
			// PlayerParameterTypeをコンボボックス用に変換
			// [配列を設定する場合]
			var playerParameterNames = new string[] {
				PlayerParameterType.Power.GetDisplayName(),
				PlayerParameterType.Hp.GetDisplayName(),
				PlayerParameterType.Speed.GetDisplayName()
			};
			this.cmbParameterType.DataSource = playerParameterNames;

			// [LINQを使ってEnumから配列を生成する場合]
			//var parameterList
			//	= ((int[])Enum.GetValues(typeof(PlayerParameterType)))
			//		.Select(value => new { value, name = ((PlayerParameterType)value).GetDisplayName() });
			//this.cmbParameterType.DataSource = parameterList.ToList();
			//this.cmbParameterType.ValueMember = "value";
			//this.cmbParameterType.DisplayMember = "name";
		}

		/// <summary>
		/// 職業設定用コントロールにTagを設定する。
		/// </summary>
		/// <remarks><see cref="JobType"/>とRadioButtonをここで紐付けおく</remarks>
		private void SetJobControlTags() {
			this.rbtnKnight.Tag = JobType.Knight;
			this.rbtnWitch.Tag = JobType.Witch;
			this.rbtnNinja.Tag = JobType.Ninja;
		}

		/// <summary>
		/// 画面に初期値を表示する。
		/// </summary>
		private void DisplayInitialValues() {
			this.rbtnMale.Checked = true;
			this.rbtnKnight.Checked = true;
			this.cmbParameterType.SelectedIndex = 0;
		}
		#endregion

	}
}

