using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminHobiSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.HobilerimTableAdapter dt = new DataSet1TableAdapters.HobilerimTableAdapter();

            short id = Convert.ToInt16(Request.QueryString["ID"]);


            dt.HobiSil(id);

            Response.Redirect("AdminHobi.aspx");


        }
    }
}