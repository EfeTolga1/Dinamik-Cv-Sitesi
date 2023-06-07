using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesi_MuratYucedag
{
    public partial class YetenekSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbCVEntityMuratYucedagEntities db = new dbCVEntityMuratYucedagEntities();


            int x = Convert.ToInt32(Request.QueryString["ID"]); //  convert etmiyor !!!!          
            var ytnk = db.TBLYETENEKLER.Find(x);
            db.TBLYETENEKLER.Remove(ytnk);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");
        }
    }
}