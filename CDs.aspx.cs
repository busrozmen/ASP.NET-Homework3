using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CDs : System.Web.UI.Page
{
    ArrayList cart1;
    ArrayList cart2;
    string url;
    protected void Page_Load(object sender, EventArgs e)
    {
        // eğer session listler boş değilse, bu listleri bi arrayliste atıp son elemanı şu an bulunduğu sayfa mı
        // değil mi diye kontrol ettik, eğer bulunduğu sayfa değilse bu sayfayı sessionliste ekledik.
        // eğer session listler boşsa, bulunduğu sayfanın linkini ve başlığını direk olarak ekledik.
        Page.Title = "List of All CDs";

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
}