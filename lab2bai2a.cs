using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


	internal class Program
	{
		static void Main(string[] args)
		{
		var userInfp = new
		{
			id = "124",
			name = " Fake",
			isDispay = false,
			
			bag= new
			{
				skins = 0,
				cups = 20,
			}

		};
		Console.WriteLine("Id:" + userInfp .id);
		Console.WriteLine("Name:" + userInfp.name);
		Console.WriteLine("IsDispay:" + userInfp.isDispay);
		Console.WriteLine("bagSkins:" + userInfp.bag.skins);
		Console.WriteLine("bagCups:" + userInfp.bag.cups);
	}
}

