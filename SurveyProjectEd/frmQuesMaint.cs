using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOCClassLibrary;

namespace SurveyProjectEd
{
	public partial class frmQuesMaint : Form
	{

		public string userInput;
		public int num;

		public frmQuesMaint()
		{
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			GetInput();
			Questions questionRef = new Questions(userInput, num);
			QuestionList.AddToList(questionRef);
			txtQues1.Text = "";
			txtQues1.Focus();
		}

		private void GetInput()
		{
			userInput = txtQues1.Text;
			num++;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSurvey_Click(object sender, EventArgs e)
		{
			frmSurvMaint surveyMaint = new frmSurvMaint();
			surveyMaint.Show();
		}
	}
}
