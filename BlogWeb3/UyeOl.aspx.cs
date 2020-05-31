using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class UyeOl : System.Web.UI.Page
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D5HNG4C;Initial Catalog=BlogDB;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {



        }



        protected void btnClk(object sender, EventArgs e)
        {


            Label1.Attributes.Add("style", "color:Red;");

            var email = TextBox3.Text;
            var kullanici = TextBox1.Text;
            var sifre = TextBox2.Text;
            var sifreTekrar = TextBox4.Text;

            if(email=="" || kullanici=="" || sifre=="" || sifreTekrar=="")
            {
                Label1.Text = "Lütfen Boş Alanları Doldurunuz";
                
            }

            else if(sifre!=sifreTekrar)
            {
                Label1.Text = " Girdiğiniz Şifreler Uyuşmuyor Lütfen Kontrol Ediniz ";
            }

            else
            {

       

                DataSet1TableAdapters.TBL_KULLANICILARTableAdapter dt1 = new DataSet1TableAdapters.TBL_KULLANICILARTableAdapter();
                dt1.KullaniciEkle(kullanici, sifre, email);

                Label1.Text = "Kaydınız Başarılıdır";
             


            }

  
          

            
        }
    }
}