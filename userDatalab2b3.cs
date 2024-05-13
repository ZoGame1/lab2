using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Bai3
{
	public class userData
	{
		public int Id { get; set; }
		public string UserNmae { get; set; }
		public List<float> Scores { get; set; }
		public userData(int ID, string userName, List<float> scores)
		{
			Id = ID;
			userName = UserNmae;
			Scores = scores;
		}
	}
}
