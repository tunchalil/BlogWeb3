using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class GirisYapKullanici : System.Web.UI.Page
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D5HNG4C;Initial Catalog=BlogDB;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
           


        }

        protected void btnClk(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D5HNG4C;Initial Catalog=BlogDB;Integrated Security=True");

            Label1.Attributes.Add("style", "color:Red;");

            var ad = TextBox1.Text;
            var sifre = TextBox2.Text;

            if (ad == "" || sifre == "")
            {
                Label1.Text = "Lütfen Tüm Alanları Doldurunuz.";
            }

            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From TBL_KULLANICILAR where KULLANICI_ADI=@P1 and SIFRE=@P2", baglanti);
                komut.Parameters.AddWithValue("@P1", TextBox1.Text);
                komut.Parameters.AddWithValue("@P2", TextBox2.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    Response.Redirect("default.Aspx");
                }

                else
                {
                    Label1.Text = "Kullanıcı Adı veya Şifre Hatalı";
                }


                baglanti.Close();
            }


        }
    }
}