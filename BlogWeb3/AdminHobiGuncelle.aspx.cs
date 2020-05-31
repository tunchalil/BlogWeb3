using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminHobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)   //Guncelledikten sonra sayfayı eski haline dondurme,bilgileri aklında tut
            {

                int id = Convert.ToInt16(Request.QueryString["ID"]);  //ilgili satırın id sini alır

                DataSet1TableAdapters.HobilerimTableAdapter dt = new DataSet1TableAdapters.HobilerimTableAdapter();

                TextBox1.Text = dt.HobiGetirIdYeGore(id)[0].HOBI;


            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(Request.QueryString["ID"]);  //ilgili satırın id sini alır

            DataSet1TableAdapters.HobilerimTableAdapter dt1 = new DataSet1TableAdapters.HobilerimTableAdapter();
            dt1.HobiGuncelle(TextBox1.Text,Convert.ToInt16(id));
            Response.Redirect("AdminHobi.Aspx");  //Ana sayfaya yonlendiriyor


        }

    }
}