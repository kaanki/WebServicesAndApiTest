using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServisDevam
{
    public partial class PisagorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.MyServiceSoapClient servis = new ServiceReference1.MyServiceSoapClient();
        protected void Button1_Click(object sender, EventArgs e)
        {
            //simple object access protocol
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            lblSonuc.Text = servis.Pisagor(sayi1, sayi2).ToString();
        }
    }
}