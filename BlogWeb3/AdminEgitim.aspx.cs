using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminEgitim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            DataSet1TableAdapters.EgitimTableAdapter dt = new DataSet1TableAdapters.EgitimTableAdapter();
            Repeater1.DataSource = dt.EgitimListele();
            Repeater1.DataBind();


        }
    }
}