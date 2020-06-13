namespace WinFormSample.Presentation {
	partial class FrmPlayer {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.rbtnMale = new System.Windows.Forms.RadioButton();
			this.rbtnFemale = new System.Windows.Forms.RadioButton();
			this.rbtnKnight = new System.Windows.Forms.RadioButton();
			this.rbtnWitch = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grbJob = new System.Windows.Forms.GroupBox();
			this.rbtnNinja = new System.Windows.Forms.RadioButton();
			this.chkIsAvailableOnFirstPlay = new System.Windows.Forms.CheckBox();
			this.cmbParameterType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.grbJob.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(74, 70);
			this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(31, 15);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "名前";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(159, 66);
			this.txtName.Margin = new System.Windows.Forms.Padding(4);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(116, 23);
			this.txtName.TabIndex = 1;
			// 
			// rbtnMale
			// 
			this.rbtnMale.AutoSize = true;
			this.rbtnMale.Location = new System.Drawing.Point(33, 50);
			this.rbtnMale.Margin = new System.Windows.Forms.Padding(4);
			this.rbtnMale.Name = "rbtnMale";
			this.rbtnMale.Size = new System.Drawing.Size(37, 19);
			this.rbtnMale.TabIndex = 2;
			this.rbtnMale.TabStop = true;
			this.rbtnMale.Text = "男";
			this.rbtnMale.UseVisualStyleBackColor = true;
			// 
			// rbtnFemale
			// 
			this.rbtnFemale.AutoSize = true;
			this.rbtnFemale.Location = new System.Drawing.Point(114, 50);
			this.rbtnFemale.Margin = new System.Windows.Forms.Padding(4);
			this.rbtnFemale.Name = "rbtnFemale";
			this.rbtnFemale.Size = new System.Drawing.Size(37, 19);
			this.rbtnFemale.TabIndex = 3;
			this.rbtnFemale.TabStop = true;
			this.rbtnFemale.Text = "女";
			this.rbtnFemale.UseVisualStyleBackColor = true;
			// 
			// rbtnKnight
			// 
			this.rbtnKnight.AutoSize = true;
			this.rbtnKnight.Location = new System.Drawing.Point(33, 49);
			this.rbtnKnight.Margin = new System.Windows.Forms.Padding(4);
			this.rbtnKnight.Name = "rbtnKnight";
			this.rbtnKnight.Size = new System.Drawing.Size(49, 19);
			this.rbtnKnight.TabIndex = 4;
			this.rbtnKnight.TabStop = true;
			this.rbtnKnight.Text = "剣士";
			this.rbtnKnight.UseVisualStyleBackColor = true;
			// 
			// rbtnWitch
			// 
			this.rbtnWitch.AutoSize = true;
			this.rbtnWitch.Location = new System.Drawing.Point(114, 49);
			this.rbtnWitch.Margin = new System.Windows.Forms.Padding(4);
			this.rbtnWitch.Name = "rbtnWitch";
			this.rbtnWitch.Size = new System.Drawing.Size(71, 19);
			this.rbtnWitch.TabIndex = 5;
			this.rbtnWitch.TabStop = true;
			this.rbtnWitch.Text = "魔法使い";
			this.rbtnWitch.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtnFemale);
			this.groupBox1.Controls.Add(this.rbtnMale);
			this.groupBox1.Location = new System.Drawing.Point(76, 130);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(200, 106);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "性別";
			// 
			// grbJob
			// 
			this.grbJob.Controls.Add(this.rbtnNinja);
			this.grbJob.Controls.Add(this.rbtnKnight);
			this.grbJob.Controls.Add(this.rbtnWitch);
			this.grbJob.Location = new System.Drawing.Point(76, 270);
			this.grbJob.Margin = new System.Windows.Forms.Padding(4);
			this.grbJob.Name = "grbJob";
			this.grbJob.Padding = new System.Windows.Forms.Padding(4);
			this.grbJob.Size = new System.Drawing.Size(302, 109);
			this.grbJob.TabIndex = 7;
			this.grbJob.TabStop = false;
			this.grbJob.Text = "職業";
			// 
			// rbtnNinja
			// 
			this.rbtnNinja.AutoSize = true;
			this.rbtnNinja.Location = new System.Drawing.Point(215, 49);
			this.rbtnNinja.Margin = new System.Windows.Forms.Padding(4);
			this.rbtnNinja.Name = "rbtnNinja";
			this.rbtnNinja.Size = new System.Drawing.Size(49, 19);
			this.rbtnNinja.TabIndex = 6;
			this.rbtnNinja.TabStop = true;
			this.rbtnNinja.Text = "忍者";
			this.rbtnNinja.UseVisualStyleBackColor = true;
			// 
			// chkIsAvailableOnFirstPlay
			// 
			this.chkIsAvailableOnFirstPlay.AutoSize = true;
			this.chkIsAvailableOnFirstPlay.Location = new System.Drawing.Point(433, 69);
			this.chkIsAvailableOnFirstPlay.Margin = new System.Windows.Forms.Padding(4);
			this.chkIsAvailableOnFirstPlay.Name = "chkIsAvailableOnFirstPlay";
			this.chkIsAvailableOnFirstPlay.Size = new System.Drawing.Size(144, 19);
			this.chkIsAvailableOnFirstPlay.TabIndex = 8;
			this.chkIsAvailableOnFirstPlay.Text = "初回プレイから使用可能";
			this.chkIsAvailableOnFirstPlay.UseVisualStyleBackColor = true;
			// 
			// cmbParameterType
			// 
			this.cmbParameterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbParameterType.FormattingEnabled = true;
			this.cmbParameterType.Location = new System.Drawing.Point(566, 130);
			this.cmbParameterType.Margin = new System.Windows.Forms.Padding(4);
			this.cmbParameterType.Name = "cmbParameterType";
			this.cmbParameterType.Size = new System.Drawing.Size(140, 23);
			this.cmbParameterType.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(430, 134);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "パラメータ種別";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(498, 346);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(124, 66);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "保存";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(629, 346);
			this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(124, 66);
			this.btnLoad.TabIndex = 12;
			this.btnLoad.Text = "読込";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
			// 
			// FrmPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 455);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbParameterType);
			this.Controls.Add(this.chkIsAvailableOnFirstPlay);
			this.Controls.Add(this.grbJob);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmPlayer";
			this.Text = "プレイヤー設定";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grbJob.ResumeLayout(false);
			this.grbJob.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.RadioButton rbtnMale;
		private System.Windows.Forms.RadioButton rbtnFemale;
		private System.Windows.Forms.RadioButton rbtnKnight;
		private System.Windows.Forms.RadioButton rbtnWitch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox grbJob;
		private System.Windows.Forms.CheckBox chkIsAvailableOnFirstPlay;
		private System.Windows.Forms.ComboBox cmbParameterType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.RadioButton rbtnNinja;
	}
}