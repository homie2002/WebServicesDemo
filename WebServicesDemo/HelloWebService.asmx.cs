using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicesDemo
{
	/// <summary>
	/// Summary description for HelloWebService
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class HelloWebService : System.Web.Services.WebService
	{
		public int F1(int x, int y)
		{
			return 4*x+y;
		}
		public int F2(int x, int y)
		{
			return 2 * (4 * x + y) + 8;
		}
		public int F3(int x, int y)
		{
			return (4 * x + y) * (4 * x + y) + 3 * (2 * (4 * x + y) + 8);
		}

		[WebMethod]
		public int F4(int x, int y)
		{
			return (5 * (2 * (4 * x + y) + 8) + 2) * ((4 * x + y) * (4 * x + y) + 3 * (2 * (4 * x + y) + 8));
		}

		[WebMethod]

		public string GetAllElements()
		{
			SqlConnection sqlConnection = new SqlConnection();
			sqlConnection = new SqlConnection("Data Source=FILIPOV\\FILIPOV;Initial Catalog=ateliemod;Integrated Security=True");
			sqlConnection.Open();

		}
	}
}
