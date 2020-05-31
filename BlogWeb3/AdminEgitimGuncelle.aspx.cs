using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
                if (Page.IsPostBack == false)   //Guncelledikten sonra sayfayı eski haline dondurme,bilgileri aklında tut
                {

                int id = Convert.ToInt16(Request.QueryString["ID"]);  //ilgili satırın id sini alır

                DataSet1TableAdapters.EgitimTableAdapter dt = new DataSet1TableAdapters.EgitimTableAdapter();

                TextBox1.Text = dt.EgitimGetirIdYeGore(id)[0].BASLIK;
                TextBox2.Text = dt.EgitimGetirIdYeGore(id)[0].ALTBASLIK;
                TextBox3.Text = dt.EgitimGetirIdYeGore(id)[0].ACIKLAMA;
                TextBox4.Text = dt.EgitimGetirIdYeGore(id)[0].GNOT;
                TextBox5.Text = dt.EgitimGetirIdYeGore(id)[0].TARIH;



            }


            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt16(Request.QueryString["ID"]);  //ilgili satırın id sini alır

            DataSet1TableAdapters.EgitimTableAdapter dt1 = new DataSet1TableAdapters.EgitimTableAdapter();
            dt1.EgitimGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text,Convert.ToInt16(id));
            Response.Redirect("AdminEgitim.Aspx");  //Ana sayfaya yonlendiriyor


        }
    }
}