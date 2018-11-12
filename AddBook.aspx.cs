using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddBook : System.Web.UI.Page
{
    ArrayList cart1;
    ArrayList cart2;
    string url;
    protected void Page_Load(object sender, EventArgs e)
    {
        // eğer session listler boş değilse, bu listleri bi arrayliste atıp son elemanı şu an bulunduğu sayfa mı
        // değil mi diye kontrol ettik, eğer bulunduğu sayfa değilse bu sayfayı sessionliste ekledik.
        // eğer session listler boşsa, bulunduğu sayfanın linkini ve başlığını direk olarak ekledik.
        Page.Title = "Add New Book";

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
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Images/") + FileUpload1.FileName);
            OleDbConnection db_baglanti = new OleDbConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnectionStringBooks"].ConnectionString);
            int pagenumber;
            if (int.TryParse(TextBox4.Text, out pagenumber))
            {
                // burada page number inputuna girilen değerin number olup olmadığını kontrol ediyor ve
                // eğer numbersa if koşulunun içine girip ekleme işlemini gerçekleştiriyor
                db_baglanti.Open();
                OleDbCommand db_komut = new OleDbCommand("Insert INTO Books ( Title, Author, Publisher, PageNumber,CoverImage ) Values( '" + TextBox5.Text + "','" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + "~/Images/" + FileUpload1.FileName.ToString() + "')", db_baglanti);
                db_komut.ExecuteNonQuery();
                db_baglanti.Close();
                LabelFail.Text = "Book is added to the list.";
                LabelFail.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                // eğer değilse ekrana hata mesajı yazıyor
                LabelFail.Text = "Connection is fail, enter number to page number input!";
                LabelFail.ForeColor = System.Drawing.Color.Red;
            }
        }
        else
        {
            // eğer cover image girilmediyse bu hatayı bildiriyor
            LabelFail.Text = "Connection is fail, enter a cover image!";
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