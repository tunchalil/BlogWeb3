using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class Yeteneklerim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.YeteneklerimTableAdapter dt = new DataSet1TableAdapters.YeteneklerimTableAdapter();
            Repeater1.DataSource = dt.YeteneklerimDoldur();
            Repeater1.DataBind();

        }
    }
}