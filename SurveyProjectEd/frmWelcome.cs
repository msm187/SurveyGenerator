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
	public partial class frmWelcome : Form
	{
		public frmWelcome()
		{
			InitializeComponent();
		}

		private void btnQuesMaint_Click(object sender, EventArgs e)
		{
			frmQuesMaint questionMaint = new frmQuesMaint();
			questionMaint.Show();

		}

		private void btnSurvMaint_Click(object sender, EventArgs e)
		{
			frmSurvMaint surveyMaint = new frmSurvMaint();
			surveyMaint.Show();
		}
	}
}
