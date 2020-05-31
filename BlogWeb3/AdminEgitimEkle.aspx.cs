using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminEgitimEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

          

            DataSet1TableAdapters.EgitimTableAdapter dt1 = new DataSet1TableAdapters.EgitimTableAdapter();
            dt1.EgitimEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            Response.Redirect("AdminEgitim.Aspx");  //Ana sayfaya yonlendiriyor

        }
    }
}