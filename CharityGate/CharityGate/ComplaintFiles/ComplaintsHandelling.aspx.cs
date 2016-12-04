using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGate.ComplaintFiles
{
    public partial class ComplaintsHandelling : System.Web.UI.Page
    {
        private string ComplaintsType = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["response"] != null)
                ComplaintsType = Request.QueryString["response"];
        }
    }
}