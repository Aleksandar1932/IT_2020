using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_lab1_zadaca2
{
    public partial class Default3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack && txtPoraka.Text != "")
            {
                btnPrvaStrana.Enabled = true;
            }
        }

        protected void btnProveri_Click(object sender, EventArgs e)
        {
            string attemptPassword = txtLozinka.Text;

            if (attemptPassword == "мрежно програмирање")
            {
                txtPoraka.ReadOnly = false;
                txtPoraka.Focus();
               
            }
            else
            {
                string myStringVariable = "Грешка лозинка!";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);

            }
        }

        protected void btnPrvaStrana_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Default.aspx");
        }
    }
}