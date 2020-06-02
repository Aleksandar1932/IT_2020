using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_lab1_zadaca2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblVreme1.Text = DateTime.Now.ToString();
            }
        }

        protected void btnVreme_Click(object sender, EventArgs e)
        {
            lblVreme2.Text = DateTime.Now.ToString();
        }
    }
}