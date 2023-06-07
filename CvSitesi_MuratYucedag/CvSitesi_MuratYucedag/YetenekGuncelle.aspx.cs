﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvSitesi_MuratYucedag
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        dbCVEntityMuratYucedagEntities db = new dbCVEntityMuratYucedagEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            int x = int.Parse(Request.QueryString["ID"]);
            if(Page.IsPostBack == false)
            {
                var deger = db.TBLYETENEKLER.Find(x);
                TextBox1.Text = deger.Yetenek;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var deger = db.TBLYETENEKLER.Find(x);
            deger.Yetenek = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");
        }
    }
}