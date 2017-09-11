using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOCClassLibrary
{
	public class QuestionList
	{
		private static List<Questions> questionList = new List<Questions>();

		public static List<Questions> QuestionsList
		{
			get
			{
				return questionList;
			}
		}
			

		public static void AddToList(Questions newQuestion)
		{
			questionList.Add(newQuestion); 
		}

		public static void RemoveFromList(int indexRemove)
		{
			questionList.RemoveAt(indexRemove);
		}


	}




}
