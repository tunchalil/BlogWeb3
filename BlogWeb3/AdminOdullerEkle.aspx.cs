using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdmınOdullerEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            DataSet1TableAdapters.OdullerimTableAdapter dt1 = new DataSet1TableAdapters.OdullerimTableAdapter();
            dt1.OdulEkle(TextBox1.Text);

            Response.Redirect("AdminOduller.Aspx");  //Ana sayfaya yonlendiriyor

        }


    }



}