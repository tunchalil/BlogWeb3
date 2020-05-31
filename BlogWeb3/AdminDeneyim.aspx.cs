using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.DeneyimlerTableAdapter dt = new DataSet1TableAdapters.DeneyimlerTableAdapter();
            Repeater1.DataSource = dt.DeneyimListesi();
            Repeater1.DataBind();

        }

        protected void btnClk(object sender, EventArgs e)
        {

                var id = SearchBox.Text.Trim();

                Response.Redirect("AdminDeneyimGuncelle.Aspx?ID=" + id);

        }

    }
}