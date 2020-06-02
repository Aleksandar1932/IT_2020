using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_lab2_zad1
{
    public partial class PlaneTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                populateMonths();
                populateDays();
                populateYears();
                populateTime();
                populateZone();
                populateClass();
                populateServices();
                populateTransportMethod();
            }
        }

        private void populateMonths()
        {
            List<string> months = new List<string>(){
                "Јануари", "Февруари", "Март", "Април", "Мај", "Јуни",
                 "Јули", "Август", "Септември", "Октомври", "Ноември", "Декември"
            };

            foreach (string month in months)
            {
                ddlMesec.Items.Add(month);
            }
        }

        private void populateDays()
        {
            for (int i = 1; i <= 31; i++)
            {
                ddlDen.Items.Add(i.ToString());
            }
        }

        private void populateYears()
        {
            for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 5; i++)
            {
                ddlGodina.Items.Add(i.ToString());
            }
        }

        private void populateTime()
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minute = 0; minute < 60; minute++)
                {
                    string hourString;
                    string minuteString;
                    if (hour <= 9)
                    {
                        hourString = "0" + hour;
                    }
                    else
                    {
                        hourString = "" + hour;
                    }
                    if (minute <= 9)
                    {
                        minuteString = "0" + minute;
                    }
                    else
                    {
                        minuteString = "" + minute;
                    }
                    ddlVreme.Items.Add(hourString + ":" + minuteString);
                }
            }
        }

        private void populateZone()
        {
            List<string> availableZones = new List<string>() { "Пушачи", "Непушачи" };
            availableZones.ForEach(zone => rblZona.Items.Add(zone));
        }

        private void populateClass()
        {
            List<string> availableClasses = new List<string>() { "Економска", "Бизнис" };
            availableClasses.ForEach(classItem => rblKlasa.Items.Add(classItem));
        }

        private void populateServices()
        {
            List<string> availableServices = new List<string>() { "Пијалок", "Кафе", "Оброк" };
            availableServices.ForEach(service => cblPosluga.Items.Add(service));
        }

        private void populateTransportMethod()
        {
            List<string> availableTransportMethods = new List<string>() { "Авион", "Воз" };
            availableTransportMethods.ForEach(transportMethod => lstSredstvo.Items.Add(transportMethod));
        }

        protected void btnPodnesi_Click(object sender, EventArgs e)
        {
            lblPatnik.Text = txtIme.Text + " " + txtPrezime.Text;
            lblSredstvo.Text = lstSredstvo.SelectedValue.ToString();
            lblOd.Text = ddlOd.SelectedValue.ToString();
            lblDo.Text = ddlDo.SelectedValue.ToString();
            lblVreme.Text = ddlDen.SelectedValue.ToString() +
                "/" + ddlMesec.SelectedValue.ToString() +
                "/" + ddlGodina.SelectedValue.ToString() +
                " " + ddlVreme.SelectedValue.ToString();
            lblZona.Text = rblZona.SelectedValue.ToString();
            lblKlasa.Text = rblKlasa.SelectedValue.ToString();
            lblPosluga.Text = "";
            cblPosluga.Items.Cast<ListItem>()
                .Where(li => li.Selected)
                .ToList()
                .ForEach(item => lblPosluga.Text += item + ",");

            imgSredstvo.Width = 200;
            imgSredstvo.Height = 200;
            if (lstSredstvo.SelectedValue.ToString() == "Авион")
            {
                imgSredstvo.ImageUrl = "images/plane_image.png";
            }
            else
            {
                imgSredstvo.ImageUrl = "images/train_image.png";
            }

        }
    }
}