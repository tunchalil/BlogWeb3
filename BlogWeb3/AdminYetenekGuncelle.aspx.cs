using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)   //Guncelledikten sonra sayfayı eski haline dondurme,bilgileri aklında tut
            {

                int id = Convert.ToInt16(Request.QueryString["ID"]);  //ilgili satırın id sini alır

                DataSet1TableAdapters.YeteneklerimTableAdapter dt = new DataSet1TableAdapters.YeteneklerimTableAdapter();

                TextBox1.Text = dt.YetenekGetirIdYeGore(id)[0].Yetenek;




            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(Request.QueryString["ID"]);  //ilgili satırın id sini alır

            DataSet1TableAdapters.YeteneklerimTableAdapter dt1 = new DataSet1TableAdapters.YeteneklerimTableAdapter();
            dt1.YetenekGuncelle(TextBox1.Text, Convert.ToInt16(id));
            Response.Redirect("AdminYeteneklerim.Aspx");  //Ana sayfaya yonlendiriyor


        }

    }
}