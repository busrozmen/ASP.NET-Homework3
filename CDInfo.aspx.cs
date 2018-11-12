using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CDInfo : System.Web.UI.Page
{
    DataView view;
    ArrayList cart1;
    ArrayList cart2;
    string url;
    protected void Page_Load(object sender, EventArgs e)
    {
        // eğer session listler boş değilse, bu listleri bi arrayliste atıp son elemanı şu an bulunduğu sayfa mı
        // değil mi diye kontrol ettik, eğer bulunduğu sayfa değilse bu sayfayı sessionliste eklerken parametreleri de ekledik.
        // eğer session listler boşsa, bulunduğu sayfanın linkini ve başlığını direk olarak ekledik.
        if (Session["sayfa"] != null && Session["link"] != null)
        {
            cart1 = (ArrayList)Session["sayfa"];
            cart2 = (ArrayList)Session["link"];
        }
        if (cart1 == null && cart2 == null)
        {
            cart1 = new ArrayList();
            cart2 = new ArrayList();
        }

        DataView view = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);

        if (view != null && view.Table.Rows.Count > 0)
        {
            Page.Title = (string)view.Table.Rows[0]["Title"];
            label1.Text = (string)view.Table.Rows[0]["Title"];

            string sayfaAdi = Page.Title;
            if (cart1[cart1.Count - 1].ToString() != sayfaAdi)
            {
                cart1.Add(sayfaAdi);
                Session["sayfa"] = cart1;
                cart2.Add(Path.GetFileName(Request.Url.AbsolutePath) + "?cdID=" + Request.QueryString["cdID"]);
                Session["link"] = cart2;
            }
        }
        else
        {
            label1.Text = "";
        }
    }
}