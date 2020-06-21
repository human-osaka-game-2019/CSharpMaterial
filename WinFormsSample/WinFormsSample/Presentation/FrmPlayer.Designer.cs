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
			this.chkIsTolerantOfFire = new System.Windows.Forms.CheckBox();
			this.cmbParameterType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.grbTolerance = new System.Windows.Forms.GroupBox();
			this.chkIsTolerantOfThunder = new System.Windows.Forms.CheckBox();
			this.chkIsTolerantOfWind = new System.Windows.Forms.CheckBox();
			this.chkIsTolerantOfIce = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.grbJob.SuspendLayout();
			this.grbTolerance.SuspendLayout();
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
			this.rbtnMale.Location = new System.Drawing.Point(33, 30);
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
			this.rbtnFemale.Location = new System.Drawing.Point(114, 30);
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
			this.rbtnKnight.Location = new System.Drawing.Point(33, 31);
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
			this.rbtnWitch.Location = new System.Drawing.Point(114, 31);
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
			this.groupBox1.Size = new System.Drawing.Size(200, 70);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "性別";
			// 
			// grbJob
			// 
			this.grbJob.Controls.Add(this.rbtnNinja);
			this.grbJob.Controls.Add(this.rbtnKnight);
			this.grbJob.Controls.Add(this.rbtnWitch);
			this.grbJob.Location = new System.Drawing.Point(76, 235);
			this.grbJob.Margin = new System.Windows.Forms.Padding(4);
			this.grbJob.Name = "grbJob";
			this.grbJob.Padding = new System.Windows.Forms.Padding(4);
			this.grbJob.Size = new System.Drawing.Size(302, 70);
			this.grbJob.TabIndex = 7;
			this.grbJob.TabStop = false;
			this.grbJob.Text = "職業";
			// 
			// rbtnNinja
			// 
			this.rbtnNinja.AutoSize = true;
			this.rbtnNinja.Location = new System.Drawing.Point(215, 30);
			this.rbtnNinja.Margin = new System.Windows.Forms.Padding(4);
			this.rbtnNinja.Name = "rbtnNinja";
			this.rbtnNinja.Size = new System.Drawing.Size(49, 19);
			this.rbtnNinja.TabIndex = 6;
			this.rbtnNinja.TabStop = true;
			this.rbtnNinja.Text = "忍者";
			this.rbtnNinja.UseVisualStyleBackColor = true;
			// 
			// chkIsTolerantOfFire
			// 
			this.chkIsTolerantOfFire.AutoSize = true;
			this.chkIsTolerantOfFire.Location = new System.Drawing.Point(36, 29);
			this.chkIsTolerantOfFire.Margin = new System.Windows.Forms.Padding(4);
			this.chkIsTolerantOfFire.Name = "chkIsTolerantOfFire";
			this.chkIsTolerantOfFire.Size = new System.Drawing.Size(38, 19);
			this.chkIsTolerantOfFire.TabIndex = 8;
			this.chkIsTolerantOfFire.Text = "火";
			this.chkIsTolerantOfFire.UseVisualStyleBackColor = true;
			// 
			// cmbParameterType
			// 
			this.cmbParameterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbParameterType.FormattingEnabled = true;
			this.cmbParameterType.Location = new System.Drawing.Point(573, 164);
			this.cmbParameterType.Margin = new System.Windows.Forms.Padding(4);
			this.cmbParameterType.Name = "cmbParameterType";
			this.cmbParameterType.Size = new System.Drawing.Size(140, 23);
			this.cmbParameterType.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(437, 168);
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
			// grbTolerance
			// 
			this.grbTolerance.Controls.Add(this.chkIsTolerantOfThunder);
			this.grbTolerance.Controls.Add(this.chkIsTolerantOfWind);
			this.grbTolerance.Controls.Add(this.chkIsTolerantOfIce);
			this.grbTolerance.Controls.Add(this.chkIsTolerantOfFire);
			this.grbTolerance.Location = new System.Drawing.Point(435, 57);
			this.grbTolerance.Name = "grbTolerance";
			this.grbTolerance.Size = new System.Drawing.Size(278, 70);
			this.grbTolerance.TabIndex = 13;
			this.grbTolerance.TabStop = false;
			this.grbTolerance.Text = "耐性";
			// 
			// chkIsTolerantOfThunder
			// 
			this.chkIsTolerantOfThunder.AutoSize = true;
			this.chkIsTolerantOfThunder.Location = new System.Drawing.Point(213, 29);
			this.chkIsTolerantOfThunder.Margin = new System.Windows.Forms.Padding(4);
			this.chkIsTolerantOfThunder.Name = "chkIsTolerantOfThunder";
			this.chkIsTolerantOfThunder.Size = new System.Drawing.Size(38, 19);
			this.chkIsTolerantOfThunder.TabIndex = 8;
			this.chkIsTolerantOfThunder.Text = "雷";
			this.chkIsTolerantOfThunder.UseVisualStyleBackColor = true;
			// 
			// chkIsTolerantOfWind
			// 
			this.chkIsTolerantOfWind.AutoSize = true;
			this.chkIsTolerantOfWind.Location = new System.Drawing.Point(154, 29);
			this.chkIsTolerantOfWind.Margin = new System.Windows.Forms.Padding(4);
			this.chkIsTolerantOfWind.Name = "chkIsTolerantOfWind";
			this.chkIsTolerantOfWind.Size = new System.Drawing.Size(38, 19);
			this.chkIsTolerantOfWind.TabIndex = 8;
			this.chkIsTolerantOfWind.Text = "風";
			this.chkIsTolerantOfWind.UseVisualStyleBackColor = true;
			// 
			// chkIsTolerantOfIce
			// 
			this.chkIsTolerantOfIce.AutoSize = true;
			this.chkIsTolerantOfIce.Location = new System.Drawing.Point(95, 29);
			this.chkIsTolerantOfIce.Margin = new System.Windows.Forms.Padding(4);
			this.chkIsTolerantOfIce.Name = "chkIsTolerantOfIce";
			this.chkIsTolerantOfIce.Size = new System.Drawing.Size(38, 19);
			this.chkIsTolerantOfIce.TabIndex = 8;
			this.chkIsTolerantOfIce.Text = "氷";
			this.chkIsTolerantOfIce.UseVisualStyleBackColor = true;
			// 
			// FrmPlayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 455);
			this.Controls.Add(this.grbTolerance);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbParameterType);
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
			this.grbTolerance.ResumeLayout(false);
			this.grbTolerance.PerformLayout();
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
		private System.Windows.Forms.CheckBox chkIsTolerantOfFire;
		private System.Windows.Forms.ComboBox cmbParameterType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.RadioButton rbtnNinja;
		private System.Windows.Forms.GroupBox grbTolerance;
		private System.Windows.Forms.CheckBox chkIsTolerantOfThunder;
		private System.Windows.Forms.CheckBox chkIsTolerantOfWind;
		private System.Windows.Forms.CheckBox chkIsTolerantOfIce;
	}
}