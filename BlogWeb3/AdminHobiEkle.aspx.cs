using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminHobiEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

     

        }

        protected void Button2_Click(object sender, EventArgs e)
        {



            DataSet1TableAdapters.HobilerimTableAdapter dt1 = new DataSet1TableAdapters.HobilerimTableAdapter();
            dt1.HobiEkle(TextBox1.Text);

            Response.Redirect("AdminHobi.Aspx");  //Ana sayfaya yonlendiriyor

        }


    }
}