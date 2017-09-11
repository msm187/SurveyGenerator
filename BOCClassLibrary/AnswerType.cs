using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOCClassLibrary
{
	public class AnswerType
	{
		private int answerTypeID;
		private string choice;

		public int AnswerTypeID { get => answerTypeID; set => answerTypeID = value; }
		public string Choice { get => choice; set => choice = value; }
	}
}
