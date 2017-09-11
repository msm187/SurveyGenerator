namespace SurveyProjectEd
{
	partial class frmQuesMaint
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
			this.lblQues1 = new System.Windows.Forms.Label();
			this.txtQues1 = new System.Windows.Forms.TextBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSurvey = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblQues1
			// 
			this.lblQues1.AutoSize = true;
			this.lblQues1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQues1.Location = new System.Drawing.Point(28, 44);
			this.lblQues1.Name = "lblQues1";
			this.lblQues1.Size = new System.Drawing.Size(106, 20);
			this.lblQues1.TabIndex = 0;
			this.lblQues1.Text = "Question 1:";
			// 
			// txtQues1
			// 
			this.txtQues1.Location = new System.Drawing.Point(144, 44);
			this.txtQues1.Name = "txtQues1";
			this.txtQues1.Size = new System.Drawing.Size(718, 22);
			this.txtQues1.TabIndex = 5;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.Location = new System.Drawing.Point(338, 121);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(93, 32);
			this.btnSubmit.TabIndex = 10;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(552, 121);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(93, 32);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSurvey
			// 
			this.btnSurvey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSurvey.Location = new System.Drawing.Point(124, 121);
			this.btnSurvey.Name = "btnSurvey";
			this.btnSurvey.Size = new System.Drawing.Size(93, 32);
			this.btnSurvey.TabIndex = 12;
			this.btnSurvey.Text = "Survey";
			this.btnSurvey.UseVisualStyleBackColor = true;
			this.btnSurvey.Click += new System.EventHandler(this.btnSurvey_Click);
			// 
			// frmQuesMaint
			// 
			this.AcceptButton = this.btnSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(903, 200);
			this.Controls.Add(this.btnSurvey);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.txtQues1);
			this.Controls.Add(this.lblQues1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmQuesMaint";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Question Maintenance";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblQues1;
		private System.Windows.Forms.TextBox txtQues1;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSurvey;
	}
}