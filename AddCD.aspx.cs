using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCD : System.Web.UI.Page
{
    ArrayList cart1;
    ArrayList cart2;
    string url;
    protected void Page_Load(object sender, EventArgs e)
    {
        // eğer session listler boş değilse, bu listleri bi arrayliste atıp son elemanı şu an bulunduğu sayfa mı
        // değil mi diye kontrol ettik, eğer bulunduğu sayfa değilse bu sayfayı sessionliste ekledik.
        // eğer session listler boşsa, bulunduğu sayfanın linkini ve başlığını direk olarak ekledik.
        Page.Title = "Add New CD";
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

    protected void SaveButton_Click(object sender, EventArgs e)
    {
        OleDbConnection db_baglantim = new OleDbConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionStringBooks"].ConnectionString);
        int year;
        int duration;
        if (int.TryParse(TextBox3.Text, out year) && int.TryParse(TextBox4.Text, out duration))
        {
            // year değeri access db.de reserved olduğu için yazılımda [] gerektiriyor.
            // if koşuluyla year ve duration inputlarının number olup olmadığı kontrol ediliyor.
            // koşul sağlanıyorsa ekleme işlemini gerçekleştiriliyor.
            db_baglantim.Open();
            OleDbCommand db_komutum = new OleDbCommand("Insert INTO CDs ( Title, Artist, [Year], Duration ) VALUES( '" + TextBox5.Text + "','" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", db_baglantim);
            db_komutum.ExecuteNonQuery();
            db_baglantim.Close();
            LabelFail.Text = "CD is added to the list.";
            LabelFail.ForeColor = System.Drawing.Color.Green;
        }
        else
        {
            // number değilse hata bildiriliyor.
            LabelFail.Text = "Connection is fail, enter number to year and duration inputs!";
            LabelFail.ForeColor = System.Drawing.Color.Red;
        }
    }

    protected void ResetButton_Click(object sender, EventArgs e)
    {
        TextBox5.Text = "";
        TextBox1.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
}
