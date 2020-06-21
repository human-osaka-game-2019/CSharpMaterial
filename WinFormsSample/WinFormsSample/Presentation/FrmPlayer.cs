using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSample.Domain.DomainObjects.Entities;
using WinFormSample.Domain.Services;
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
		private PlayerService service = new PlayerService();
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
					ParameterType = (PlayerParameter.PlayerParameterType)this.cmbParameterType.SelectedValue,

					IsTolerantOfFire = this.chkIsTolerantOfFire.Checked,
					IsTolerantOfIce = this.chkIsTolerantOfIce.Checked,
					IsTolerantOfWind = this.chkIsTolerantOfWind.Checked,
					IsTolerantOfThunder = this.chkIsTolerantOfThunder.Checked,
					// 職業のGroupBoxの中に配置されているRadioButtonの中で選択状態のもののTagを取得
					Job = (JobType)this.grbJob.Controls.OfType<RadioButton>().First(x => x.Checked).Tag
				};

				await this.service.SaveAsync(player, filePath);
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
				var player = await this.service.LoadAsync(dialog.FileName);

				// 読み込めた場合は画面に表示
				if (player != null) {
					this.txtName.Text = player.Name;
					(player.IsMale ? this.rbtnMale : this.rbtnFemale).Checked = true;
					this.chkIsTolerantOfFire.Checked = player.IsTolerantOfFire;
					this.chkIsTolerantOfIce.Checked = player.IsTolerantOfIce;
					this.chkIsTolerantOfWind.Checked = player.IsTolerantOfWind;
					this.chkIsTolerantOfThunder.Checked = player.IsTolerantOfThunder;

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
			var parameterList
				= ((int[])Enum.GetValues(typeof(PlayerParameterType)))
					.Select(value => new { value, name = ((PlayerParameterType)value).GetDisplayName() });
			this.cmbParameterType.DataSource = parameterList.ToList();
			this.cmbParameterType.ValueMember = "value";
			this.cmbParameterType.DisplayMember = "name";
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

