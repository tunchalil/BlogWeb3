using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Page.IsPostBack==false)
            {

            

                int id = Convert.ToInt32(Request.QueryString["ID"]);

                TxtID.Enabled = false;

                TxtID.Text = id.ToString();

                DataSet1TableAdapters.DeneyimlerTableAdapter dt = new DataSet1TableAdapters.DeneyimlerTableAdapter();

                TextBox1.Text = dt.DeneyimGetirIdyeGore(id)[0].Baslik;
                TextBox2.Text = dt.DeneyimGetirIdyeGore(id)[0].AltBaslik;
                TextBox3.Text = dt.DeneyimGetirIdyeGore(id)[0].Tarih;
                TextBox4.Text = dt.DeneyimGetirIdyeGore(id)[0].Aciklama;
            }




        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["ID"]);

            DataSet1TableAdapters.DeneyimlerTableAdapter dt1 = new DataSet1TableAdapters.DeneyimlerTableAdapter();
            dt1.DeneyimGuncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text,id);
            Response.Redirect("AdminDeneyim.Aspx");  //Ana sayfaya yonlendiriyor


        }
    }
}