using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOCClassLibrary
{
	public class Surveys
	{
		private int surveysID;
		private int questionListID;
		private int answersID;
		private string name;

		public int SurveysID { get => surveysID; set => surveysID = value; }
		public int QuestionListID { get => questionListID; set => questionListID = value; }
		public int AnswersID { get => answersID; set => answersID = value; }
		public string Name { get => name; set => name = value; }
	}
}
