using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOCClassLibrary
{
    public class Questions
    {
		private static int questionsID;
		private static string questionContent;

		public static int QuestionsID1 { get => questionsID; set => questionsID = value; }
		public static string QuestionContent1 { get => questionContent; set => questionContent = value; }

		public Questions()
		{

		}

		public Questions(string questionRef, int idTag)
		{
			QuestionContent1 = questionRef;
			QuestionsID1 = idTag;
		}
	}

}
