using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOCClassLibrary
{
	public class SurveyList
	{
		private List<string> survey = new List<string>();

		public List<string> Survey { get => survey; set => survey = value; }
	}
}
