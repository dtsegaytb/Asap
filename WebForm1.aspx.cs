using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsapTestApp
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Details Details1 = new Details
			{
				firstname = "Jose",
				lastname = "Vasconselos",
				dob = "01/01/1961",
				country = "MX"
			};
			List<Details> listDetails = new List<Details>();
			listDetails.Add(Details1);

			JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
			string jsonString = javaScriptSerializer.Serialize(listDetails);

			Response.Write(jsonString);








		}
	}
}