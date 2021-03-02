using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsapTestApp
{
	class numgenerator
	{
		static void Main(String[] args)
		{
			Random ranid = new Random();
			int myranid = ranid.Next(100000,999999);
			Console.WriteLine("Number " + myranid);
		}
	}
}