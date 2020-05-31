using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminOdullerGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)   //Guncelledikten sonra sayfayı eski haline dondurme,bilgileri aklında tut
            {

                int id = Convert.ToInt16(Request.QueryString["ID"]);  //ilgili satırın id sini alır

                DataSet1TableAdapters.OdullerimTableAdapter dt = new DataSet1TableAdapters.OdullerimTableAdapter();

                TextBox1.Text = dt.OdulGetirIdYeGore(id)[0].Odullerim;




            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(Request.QueryString["ID"]);  //ilgili satırın id sini alır

            DataSet1TableAdapters.OdullerimTableAdapter dt1 = new DataSet1TableAdapters.OdullerimTableAdapter();
            dt1.OdulGuncelle(TextBox1.Text, Convert.ToInt16(id));
            Response.Redirect("AdminOduller.Aspx");  //Ana sayfaya yonlendiriyor


        }
    }
}