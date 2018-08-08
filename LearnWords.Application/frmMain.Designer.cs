namespace LearnWords.Domain {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnExercise = new System.Windows.Forms.Button();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnImportData = new System.Windows.Forms.Button();
			this.panButtons = new System.Windows.Forms.Panel();
			this.gpbStatistic = new System.Windows.Forms.GroupBox();
			this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblWordsCount = new System.Windows.Forms.Label();
			this.txtWordsCount = new System.Windows.Forms.TextBox();
			this.txtNew = new System.Windows.Forms.TextBox();
			this.lblCompleted = new System.Windows.Forms.Label();
			this.lblNew = new System.Windows.Forms.Label();
			this.txtCompleted = new System.Windows.Forms.TextBox();
			this.txtWrong = new System.Windows.Forms.TextBox();
			this.lblDoneOnce = new System.Windows.Forms.Label();
			this.lblWrong = new System.Windows.Forms.Label();
			this.txtDoneOnce = new System.Windows.Forms.TextBox();
			this.txtWorking = new System.Windows.Forms.TextBox();
			this.lblWorking = new System.Windows.Forms.Label();
			this.panStatistic = new System.Windows.Forms.Panel();
			this.panButtons.SuspendLayout();
			this.gpbStatistic.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panStatistic.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnExercise
			// 
			this.btnExercise.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnExercise.Location = new System.Drawing.Point(10, 10);
			this.btnExercise.Name = "btnExercise";
			this.btnExercise.Size = new System.Drawing.Size(180, 40);
			this.btnExercise.TabIndex = 0;
			this.btnExercise.Text = "Exercise";
			this.btnExercise.UseVisualStyleBackColor = true;
			this.btnExercise.Click += new System.EventHandler(this.btnExercise_Click);
			// 
			// btnSettings
			// 
			this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSettings.Location = new System.Drawing.Point(10, 50);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(180, 40);
			this.btnSettings.TabIndex = 1;
			this.btnSettings.Text = "Settings";
			this.btnSettings.UseVisualStyleBackColor = true;
			// 
			// btnImportData
			// 
			this.btnImportData.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnImportData.Location = new System.Drawing.Point(10, 90);
			this.btnImportData.Name = "btnImportData";
			this.btnImportData.Size = new System.Drawing.Size(180, 40);
			this.btnImportData.TabIndex = 1;
			this.btnImportData.Text = "Import";
			this.btnImportData.UseVisualStyleBackColor = true;
			// 
			// panButtons
			// 
			this.panButtons.Controls.Add(this.btnImportData);
			this.panButtons.Controls.Add(this.btnSettings);
			this.panButtons.Controls.Add(this.btnExercise);
			this.panButtons.Dock = System.Windows.Forms.DockStyle.Left;
			this.panButtons.Location = new System.Drawing.Point(0, 0);
			this.panButtons.Name = "panButtons";
			this.panButtons.Padding = new System.Windows.Forms.Padding(10);
			this.panButtons.Size = new System.Drawing.Size(200, 453);
			this.panButtons.TabIndex = 2;
			// 
			// gpbStatistic
			// 
			this.gpbStatistic.Controls.Add(this.cartesianChart1);
			this.gpbStatistic.Controls.Add(this.panel1);
			this.gpbStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gpbStatistic.Location = new System.Drawing.Point(10, 10);
			this.gpbStatistic.Name = "gpbStatistic";
			this.gpbStatistic.Size = new System.Drawing.Size(402, 433);
			this.gpbStatistic.TabIndex = 3;
			this.gpbStatistic.TabStop = false;
			this.gpbStatistic.Text = "Statistics";
			// 
			// cartesianChart1
			// 
			this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Left;
			this.cartesianChart1.Location = new System.Drawing.Point(231, 23);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(174, 407);
			this.cartesianChart1.TabIndex = 10;
			this.cartesianChart1.Text = "cartesianChart1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblWordsCount);
			this.panel1.Controls.Add(this.txtWordsCount);
			this.panel1.Controls.Add(this.txtNew);
			this.panel1.Controls.Add(this.lblCompleted);
			this.panel1.Controls.Add(this.lblNew);
			this.panel1.Controls.Add(this.txtCompleted);
			this.panel1.Controls.Add(this.txtWrong);
			this.panel1.Controls.Add(this.lblDoneOnce);
			this.panel1.Controls.Add(this.lblWrong);
			this.panel1.Controls.Add(this.txtDoneOnce);
			this.panel1.Controls.Add(this.txtWorking);
			this.panel1.Controls.Add(this.lblWorking);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(3, 23);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(228, 407);
			this.panel1.TabIndex = 11;
			// 
			// lblWordsCount
			// 
			this.lblWordsCount.AutoSize = true;
			this.lblWordsCount.Location = new System.Drawing.Point(13, 9);
			this.lblWordsCount.Name = "lblWordsCount";
			this.lblWordsCount.Size = new System.Drawing.Size(63, 20);
			this.lblWordsCount.TabIndex = 0;
			this.lblWordsCount.Text = "Words:";
			// 
			// txtWordsCount
			// 
			this.txtWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWordsCount.Location = new System.Drawing.Point(116, 6);
			this.txtWordsCount.Name = "txtWordsCount";
			this.txtWordsCount.ReadOnly = true;
			this.txtWordsCount.Size = new System.Drawing.Size(100, 27);
			this.txtWordsCount.TabIndex = 1;
			// 
			// txtNew
			// 
			this.txtNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNew.ForeColor = System.Drawing.Color.Peru;
			this.txtNew.Location = new System.Drawing.Point(116, 172);
			this.txtNew.Name = "txtNew";
			this.txtNew.ReadOnly = true;
			this.txtNew.Size = new System.Drawing.Size(100, 27);
			this.txtNew.TabIndex = 6;
			// 
			// lblCompleted
			// 
			this.lblCompleted.AutoSize = true;
			this.lblCompleted.Location = new System.Drawing.Point(13, 42);
			this.lblCompleted.Name = "lblCompleted";
			this.lblCompleted.Size = new System.Drawing.Size(94, 20);
			this.lblCompleted.TabIndex = 2;
			this.lblCompleted.Text = "Completed:";
			// 
			// lblNew
			// 
			this.lblNew.AutoSize = true;
			this.lblNew.Location = new System.Drawing.Point(13, 175);
			this.lblNew.Name = "lblNew";
			this.lblNew.Size = new System.Drawing.Size(47, 20);
			this.lblNew.TabIndex = 5;
			this.lblNew.Text = "New:";
			// 
			// txtCompleted
			// 
			this.txtCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCompleted.ForeColor = System.Drawing.Color.Green;
			this.txtCompleted.Location = new System.Drawing.Point(116, 39);
			this.txtCompleted.Name = "txtCompleted";
			this.txtCompleted.ReadOnly = true;
			this.txtCompleted.Size = new System.Drawing.Size(100, 27);
			this.txtCompleted.TabIndex = 3;
			// 
			// txtWrong
			// 
			this.txtWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWrong.ForeColor = System.Drawing.Color.Red;
			this.txtWrong.Location = new System.Drawing.Point(116, 139);
			this.txtWrong.Name = "txtWrong";
			this.txtWrong.ReadOnly = true;
			this.txtWrong.Size = new System.Drawing.Size(100, 27);
			this.txtWrong.TabIndex = 9;
			// 
			// lblDoneOnce
			// 
			this.lblDoneOnce.AutoSize = true;
			this.lblDoneOnce.Location = new System.Drawing.Point(13, 76);
			this.lblDoneOnce.Name = "lblDoneOnce";
			this.lblDoneOnce.Size = new System.Drawing.Size(95, 20);
			this.lblDoneOnce.TabIndex = 4;
			this.lblDoneOnce.Text = "Done once:";
			// 
			// lblWrong
			// 
			this.lblWrong.AutoSize = true;
			this.lblWrong.Location = new System.Drawing.Point(13, 142);
			this.lblWrong.Name = "lblWrong";
			this.lblWrong.Size = new System.Drawing.Size(63, 20);
			this.lblWrong.TabIndex = 8;
			this.lblWrong.Text = "Wrong:";
			// 
			// txtDoneOnce
			// 
			this.txtDoneOnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDoneOnce.ForeColor = System.Drawing.Color.MediumTurquoise;
			this.txtDoneOnce.Location = new System.Drawing.Point(116, 73);
			this.txtDoneOnce.Name = "txtDoneOnce";
			this.txtDoneOnce.ReadOnly = true;
			this.txtDoneOnce.Size = new System.Drawing.Size(100, 27);
			this.txtDoneOnce.TabIndex = 5;
			// 
			// txtWorking
			// 
			this.txtWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWorking.ForeColor = System.Drawing.Color.Gold;
			this.txtWorking.Location = new System.Drawing.Point(116, 106);
			this.txtWorking.Name = "txtWorking";
			this.txtWorking.ReadOnly = true;
			this.txtWorking.Size = new System.Drawing.Size(100, 27);
			this.txtWorking.TabIndex = 7;
			// 
			// lblWorking
			// 
			this.lblWorking.AutoSize = true;
			this.lblWorking.Location = new System.Drawing.Point(13, 109);
			this.lblWorking.Name = "lblWorking";
			this.lblWorking.Size = new System.Drawing.Size(75, 20);
			this.lblWorking.TabIndex = 6;
			this.lblWorking.Text = "Working:";
			// 
			// panStatistic
			// 
			this.panStatistic.Controls.Add(this.gpbStatistic);
			this.panStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panStatistic.Location = new System.Drawing.Point(200, 0);
			this.panStatistic.Name = "panStatistic";
			this.panStatistic.Padding = new System.Windows.Forms.Padding(10);
			this.panStatistic.Size = new System.Drawing.Size(422, 453);
			this.panStatistic.TabIndex = 4;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 453);
			this.Controls.Add(this.panStatistic);
			this.Controls.Add(this.panButtons);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "frmMain";
			this.Text = "Main";
			this.panButtons.ResumeLayout(false);
			this.gpbStatistic.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panStatistic.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExercise;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnImportData;
		private System.Windows.Forms.Panel panButtons;
		private System.Windows.Forms.GroupBox gpbStatistic;
		private System.Windows.Forms.TextBox txtNew;
		private System.Windows.Forms.Label lblNew;
		private System.Windows.Forms.TextBox txtWrong;
		private System.Windows.Forms.Label lblWrong;
		private System.Windows.Forms.TextBox txtWorking;
		private System.Windows.Forms.Label lblWorking;
		private System.Windows.Forms.TextBox txtDoneOnce;
		private System.Windows.Forms.Label lblDoneOnce;
		private System.Windows.Forms.TextBox txtCompleted;
		private System.Windows.Forms.Label lblCompleted;
		private System.Windows.Forms.TextBox txtWordsCount;
		private System.Windows.Forms.Label lblWordsCount;
		private System.Windows.Forms.Panel panStatistic;
		private LiveCharts.WinForms.CartesianChart cartesianChart1;
		private System.Windows.Forms.Panel panel1;
	}
}