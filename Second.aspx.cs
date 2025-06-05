using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWeb
{
	public partial class Second : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			Response.Write("<h1>Second Page</h1>");
			Response.Write($"Sever Date:{DateTime.Now.ToShortDateString()}");
            Response.Write("<br/>");
			Response.Write($"Sever Time:{DateTime.Now.ToLongTimeString()}");
            Response.Write("<br/>");
            Response.Write("<br/>");

			Response.Write($"Sever Date:{DateTime.Now.ToLongDateString()}");
            Response.Write("<br/>");
            Response.Write($"Sever Time:{DateTime.Now.ToShortTimeString()}");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write($"Sever Date:{DateTime.Now.ToString("yyyy-MM-dd")}");
            Response.Write("<br/>");
            Response.Write($"Sever Time:{DateTime.Now.ToString("HH:mm:ss")}");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write($"Sever Date:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
            Response.Write("<br/>");


        }
    }
}