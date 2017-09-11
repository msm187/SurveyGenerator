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
	public partial class frmSurvMaint : Form
	{
		//hooking up classes
		frmQuesMaint getQuestions = new frmQuesMaint();
		frmSurvey pubSurvey = new frmSurvey();
		Questions ques = new Questions();
		QuestionList quesList = new QuestionList();

		//this Class Variables
		
		List<string> questionAdds = new List<string>();
		private Questions question;

		//Variables for published survey
		private string quesOne;
		private string quesTwo;
		private string quesThree;
		private string quesfour;
		private string quesFive;
		private string surveyName;


		public frmSurvMaint()
		{
			InitializeComponent();
		}


		private void frmSurvMaint_Load(object sender, EventArgs e)
		{
			
		}
		

		//Method to call when adding questions list to combo boxes.
		private void GetList()
		{
			foreach (Questions question in QuestionList.QuestionsList)
			{
				
			}
			
		}

		private void btnSwapToQM_Click(object sender, EventArgs e)
		{
			frmQuesMaint questionMaint = new frmQuesMaint();
			questionMaint.Show();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		
	}
}
