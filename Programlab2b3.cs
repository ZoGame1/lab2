using lab2Bai3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{


	static void Main(string[] args)
	{
		List<float> ldata = new List<float>() { 10, 9, 8, 7.5f, 2, 1.4f };
		userData userData = new userData(11057,"Phan Van Quoc", ldata);

		Console.WriteLine("ID:" + userData.Id );
		Console.WriteLine("UserName: " + userData.UserNmae);
		Console.WriteLine("Scores:");
		foreach (float score in userData.Scores)
		{
			Console.WriteLine(score);
		}
		Console.ReadLine();
	}




}
