namespace SurveyProjectEd
{
	partial class frmWelcome
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnQuesMaint = new System.Windows.Forms.Button();
			this.btnSurvMaint = new System.Windows.Forms.Button();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnQuesMaint
			// 
			this.btnQuesMaint.Location = new System.Drawing.Point(12, 74);
			this.btnQuesMaint.Name = "btnQuesMaint";
			this.btnQuesMaint.Size = new System.Drawing.Size(154, 67);
			this.btnQuesMaint.TabIndex = 0;
			this.btnQuesMaint.Text = "Question Maintenance";
			this.btnQuesMaint.UseVisualStyleBackColor = true;
			this.btnQuesMaint.Click += new System.EventHandler(this.btnQuesMaint_Click);
			// 
			// btnSurvMaint
			// 
			this.btnSurvMaint.Location = new System.Drawing.Point(222, 74);
			this.btnSurvMaint.Name = "btnSurvMaint";
			this.btnSurvMaint.Size = new System.Drawing.Size(154, 67);
			this.btnSurvMaint.TabIndex = 1;
			this.btnSurvMaint.Text = "Survey Maintenance";
			this.btnSurvMaint.UseVisualStyleBackColor = true;
			this.btnSurvMaint.Click += new System.EventHandler(this.btnSurvMaint_Click);
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(101, 21);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(161, 16);
			this.lblWelcome.TabIndex = 2;
			this.lblWelcome.Text = "Please choose below:";
			// 
			// frmWelcome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(388, 175);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.btnSurvMaint);
			this.Controls.Add(this.btnQuesMaint);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmWelcome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Survey Gorrila ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnQuesMaint;
		private System.Windows.Forms.Button btnSurvMaint;
		private System.Windows.Forms.Label lblWelcome;
	}
}

