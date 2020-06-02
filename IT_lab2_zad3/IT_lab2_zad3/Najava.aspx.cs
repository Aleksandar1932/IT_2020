using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_lab2_zad3
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["isLogged"] = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(txtLozinka.Text == "mp")
            {
                Session["isLogged"] = true;
                Session["korisnik"] = txtKorisnik.Text;
                Response.Redirect("GlavnaStrana.aspx");
            }
            else
            {
                lblObidi.Text = (Int32.Parse(lblObidi.Text) + 1).ToString();
            }
        }
    }
}