using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class DeneyimSilMP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.DeneyimlerTableAdapter dt = new DataSet1TableAdapters.DeneyimlerTableAdapter();

            int id = Convert.ToInt32(Request.QueryString["ID"]);

           

            dt.DeneyimSil(id);

            Response.Redirect("AdminDeneyim.aspx");

        }
    }
}