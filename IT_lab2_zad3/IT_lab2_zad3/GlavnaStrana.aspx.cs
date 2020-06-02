using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_lab2_zad3
{
    public partial class GlavnaStrana : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogged"].Equals(false))
            {
                txtUsername.Text = "Неможе да пристапите не сте најавени";
            }
            else
            {
                txtUsername.Text = Session["korisnik"].ToString();
            }
        }
    }
}