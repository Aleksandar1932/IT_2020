using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_AV2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListaGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelektiraniGradovi.Text = "";

            foreach (ListItem item in ListaGradovi.Items)
            {
                if (item.Selected)
                {
                    SelektiraniGradovi.Text += item.Text + " ";
                }
            }

        }
    }
}