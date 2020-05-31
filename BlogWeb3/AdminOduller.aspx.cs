using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminOduller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.OdullerimTableAdapter dt = new DataSet1TableAdapters.OdullerimTableAdapter();
            Repeater1.DataSource = dt.OdullerimListele();
            Repeater1.DataBind();

        }
    }
}