using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesi_MuratYucedag
{
    public partial class Istatistik : System.Web.UI.Page
    {
        dbCVEntityMuratYucedagEntities db = new dbCVEntityMuratYucedagEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLYETENEKLER.Count().ToString();
            Label2.Text = db.TBLILETISIM.Count().ToString();
            Label3.Text = db.TBLYETENEKLER.Average(x => x.Derece).ToString();
            Label4.Text = db.TBLYETENEKLER.Max(x => x.Derece).ToString();

        }
    }
}