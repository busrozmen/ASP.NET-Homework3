using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

public partial class Books : System.Web.UI.Page
{
    ArrayList cart1;
    ArrayList cart2;
    string url;
    protected void Page_Load(object sender, EventArgs e)
    {
        // eğer session listler boş değilse, bu listleri bi arrayliste atıp son elemanı şu an bulunduğu sayfa mı
        // değil mi diye kontrol ettik, eğer bulunduğu sayfa değilse bu sayfayı sessionliste ekledik.
        // eğer session listler boşsa, bulunduğu sayfanın linkini ve başlığını direk olarak ekledik.
        Page.Title = "List of All Books";

        string sayfaAdi = Page.Title;
        if (Session["sayfa"] != null && Session["link"] != null)
        {
            cart1 = (ArrayList)Session["sayfa"];
            cart2 = (ArrayList)Session["link"];
            if (cart1[cart1.Count - 1].ToString() != sayfaAdi)
            {
                cart1.Add(sayfaAdi);
                Session["sayfa"] = cart1;
                cart2.Add(Path.GetFileName(Request.Url.AbsolutePath));
                Session["link"] = cart2;
            }
        }
        if (cart1 == null && cart2 == null)
        {
            cart1 = new ArrayList();
            cart2 = new ArrayList();
            cart1.Add(sayfaAdi);
            Session["sayfa"] = cart1;
            cart2.Add(Path.GetFileName(Request.Url.AbsolutePath));
            Session["link"] = cart2;
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
}


