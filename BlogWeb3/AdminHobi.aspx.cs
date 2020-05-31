using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogWeb3
{
    public partial class AdminHobiler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataSet1TableAdapters.HobilerimTableAdapter dt = new DataSet1TableAdapters.HobilerimTableAdapter();
            Repeater1.DataSource = dt.HobilerListele();
            Repeater1.DataBind();


        }
    }
}