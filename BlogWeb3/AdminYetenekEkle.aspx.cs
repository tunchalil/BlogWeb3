using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminYetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {



            DataSet1TableAdapters.YeteneklerimTableAdapter dt1 = new DataSet1TableAdapters.YeteneklerimTableAdapter();
            dt1.YetenekEkle(TextBox1.Text);
       
            Response.Redirect("AdminYeteneklerim.Aspx");  //Ana sayfaya yonlendiriyor

        }


    }
}