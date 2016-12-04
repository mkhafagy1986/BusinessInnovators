using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGate
{
    public partial class RegisterationSaveContactNumber : System.Web.UI.Page
    {
        private string ContactNumber = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["response"] != null)
                ContactNumber = Request.QueryString["response"];
        }
    }
}