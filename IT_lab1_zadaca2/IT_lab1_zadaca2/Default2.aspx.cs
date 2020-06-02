using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_lab1_zadaca2
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSoberi_Click(object sender, EventArgs e)
        {
            lblRezultat.Text = (Int32.Parse(txtOperand1.Text) + Int32.Parse(txtOperand2.Text)).ToString();
        }

        protected void chbVidlivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVidlivo.Checked)
            {
                pnlPanela1.Visible = true;
            }
            else
            {
                pnlPanela1.Visible = false;
            }
        }
    }
}