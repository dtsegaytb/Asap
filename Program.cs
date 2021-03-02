using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
namespace AsapTestApp
{
	class Program
	{
		static void Main(String[] args)
		{
			GetRequest("http://www.google.com.pk");
			Console.ReadKey();
		}

		async static void GetRequest(string url)
		{
			using (HttpClient client = new HttpClient())
			{
				using (HttpResponseMessage response = await client.GetAsync("AsapHtml.html")) 
				{
					using (HttpContent content = response.Content)
					{
						string mycontent = await content.ReadAsStringAsync();
						Console.WriteLine(mycontent);
					}
						

				}
			}

		}
	}
}