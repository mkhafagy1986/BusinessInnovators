using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharityGate.DonationFiles._57357HospitalFiles
{
    public partial class ConfirmDonation : System.Web.UI.Page
    {
        private string _donationAmount = "";

        public string DonationAmount
        {
            get { return _donationAmount; }
            set { _donationAmount = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["response"] != null)
                _donationAmount = Request.QueryString["response"];
        }
    }
}