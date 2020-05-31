using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class defaultAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HakkimdaTableAdapter dt = new DataSet1TableAdapters.HakkimdaTableAdapter();
            Repeater1.DataSource = dt.HakkimdaListele();
            Repeater1.DataBind();


            DataSet1TableAdapters.DeneyimlerTableAdapter dt2 = new DataSet1TableAdapters.DeneyimlerTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.EgitimTableAdapter dt3 = new DataSet1TableAdapters.EgitimTableAdapter();
            Repeater3.DataSource = dt3.EgitimListele();
            Repeater3.DataBind();

            DataSet1TableAdapters.OdullerimTableAdapter dt4 = new DataSet1TableAdapters.OdullerimTableAdapter();
            Repeater4.DataSource = dt4.OdullerimListele();
            Repeater4.DataBind();

            DataSet1TableAdapters.HobilerimTableAdapter dt5 = new DataSet1TableAdapters.HobilerimTableAdapter();
            Repeater5.DataSource = dt5.HobilerListele();
            Repeater5.DataBind();

            DataSet1TableAdapters.YeteneklerimTableAdapter dt6 = new DataSet1TableAdapters.YeteneklerimTableAdapter();
            Repeater6.DataSource = dt6.YeteneklerimDoldur();
            Repeater6.DataBind();



        }
    }
}