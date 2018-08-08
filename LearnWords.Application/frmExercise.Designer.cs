namespace LearnWords.App {
	partial class frmExercise {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercise));
			this.txtTextFrom = new System.Windows.Forms.TextBox();
			this.lblTranslateFrom = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.lblTranslateTo = new System.Windows.Forms.Label();
			this.panButtons = new System.Windows.Forms.Panel();
			this.btnTip = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.lblCorrectAnswere = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panButtons.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTextFrom
			// 
			this.txtTextFrom.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtTextFrom.Enabled = false;
			this.txtTextFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTextFrom.Location = new System.Drawing.Point(10, 25);
			this.txtTextFrom.Margin = new System.Windows.Forms.Padding(5);
			this.txtTextFrom.Name = "txtTextFrom";
			this.txtTextFrom.Size = new System.Drawing.Size(454, 45);
			this.txtTextFrom.TabIndex = 0;
			// 
			// lblTranslateFrom
			// 
			this.lblTranslateFrom.AutoSize = true;
			this.lblTranslateFrom.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTranslateFrom.ForeColor = System.Drawing.Color.DimGray;
			this.lblTranslateFrom.Location = new System.Drawing.Point(10, 0);
			this.lblTranslateFrom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblTranslateFrom.Name = "lblTranslateFrom";
			this.lblTranslateFrom.Size = new System.Drawing.Size(156, 25);
			this.lblTranslateFrom.TabIndex = 1;
			this.lblTranslateFrom.Text = "Translate from {}";
			// 
			// txtAnswer
			// 
			this.txtAnswer.Dock = System.Windows.Forms.DockStyle.Top;
			this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswer.Location = new System.Drawing.Point(10, 25);
			this.txtAnswer.Margin = new System.Windows.Forms.Padding(5);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(464, 45);
			this.txtAnswer.TabIndex = 2;
			// 
			// lblTranslateTo
			// 
			this.lblTranslateTo.AutoSize = true;
			this.lblTranslateTo.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTranslateTo.ForeColor = System.Drawing.Color.DimGray;
			this.lblTranslateTo.Location = new System.Drawing.Point(10, 0);
			this.lblTranslateTo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblTranslateTo.Name = "lblTranslateTo";
			this.lblTranslateTo.Size = new System.Drawing.Size(134, 25);
			this.lblTranslateTo.TabIndex = 3;
			this.lblTranslateTo.Text = "Translate to {}";
			// 
			// panButtons
			// 
			this.panButtons.Controls.Add(this.btnTip);
			this.panButtons.Controls.Add(this.btnNext);
			this.panButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panButtons.Location = new System.Drawing.Point(14, 145);
			this.panButtons.Margin = new System.Windows.Forms.Padding(5);
			this.panButtons.Name = "panButtons";
			this.panButtons.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
			this.panButtons.Size = new System.Drawing.Size(958, 75);
			this.panButtons.TabIndex = 4;
			// 
			// btnTip
			// 
			this.btnTip.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnTip.Location = new System.Drawing.Point(548, 12);
			this.btnTip.Margin = new System.Windows.Forms.Padding(5);
			this.btnTip.Name = "btnTip";
			this.btnTip.Size = new System.Drawing.Size(205, 51);
			this.btnTip.TabIndex = 1;
			this.btnTip.Text = "Tip";
			this.btnTip.UseVisualStyleBackColor = true;
			this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
			// 
			// btnNext
			// 
			this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnNext.Location = new System.Drawing.Point(753, 12);
			this.btnNext.Margin = new System.Windows.Forms.Padding(5);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(205, 51);
			this.btnNext.TabIndex = 0;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// lblCorrectAnswere
			// 
			this.lblCorrectAnswere.AutoSize = true;
			this.lblCorrectAnswere.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCorrectAnswere.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCorrectAnswere.Location = new System.Drawing.Point(10, 70);
			this.lblCorrectAnswere.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblCorrectAnswere.Name = "lblCorrectAnswere";
			this.lblCorrectAnswere.Size = new System.Drawing.Size(285, 38);
			this.lblCorrectAnswere.TabIndex = 5;
			this.lblCorrectAnswere.Text = "lblCorrectAnswere";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtTextFrom);
			this.panel1.Controls.Add(this.lblTranslateFrom);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(14, 15);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.panel1.Size = new System.Drawing.Size(474, 130);
			this.panel1.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblCorrectAnswere);
			this.panel2.Controls.Add(this.txtAnswer);
			this.panel2.Controls.Add(this.lblTranslateTo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(488, 15);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.panel2.Size = new System.Drawing.Size(484, 130);
			this.panel2.TabIndex = 7;
			// 
			// frmExercise
			// 
			this.AcceptButton = this.btnNext;
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(986, 235);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panButtons);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MinimumSize = new System.Drawing.Size(18, 282);
			this.Name = "frmExercise";
			this.Padding = new System.Windows.Forms.Padding(14, 15, 14, 15);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Exercise";
			this.panButtons.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtTextFrom;
		private System.Windows.Forms.Label lblTranslateFrom;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Label lblTranslateTo;
		private System.Windows.Forms.Panel panButtons;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnTip;
		private System.Windows.Forms.Label lblCorrectAnswere;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
	}
}

