using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    ArrayList cart1;
    ArrayList cart2;
    string url;
    protected void Page_Load(object sender, EventArgs e)
    {
        // sayfalar arasında geçiş yapıldıkça sayfa linkini ve başlığını iki ayrı session liste ekledik.
        // master pagede bu session listleri çekerek counta göre yazdırma işlemi yaptık.
        // eğer count 5'i geçerse ilk eklenenin üzerine queue mantığıyla yazdırdık.
        cart1 = (ArrayList)Session["sayfa"];
        cart2 = (ArrayList)Session["link"];
        if (cart1.Count == 1)   
        {
            HyperLink1.Text = cart1[0].ToString();
            HyperLink1.NavigateUrl = cart2[0].ToString();
        }
        else if (cart1.Count == 2)
        {
            HyperLink1.Text = cart1[1].ToString();
            HyperLink1.NavigateUrl = cart2[1].ToString();
            HyperLink2.Text = cart1[0].ToString();
            HyperLink2.NavigateUrl = cart2[0].ToString();
        }
        else if (cart1.Count == 3)
        {
            HyperLink1.Text = cart1[2].ToString();
            HyperLink1.NavigateUrl = cart2[2].ToString();
            HyperLink2.Text = cart1[1].ToString();
            HyperLink2.NavigateUrl = cart2[1].ToString();
            HyperLink3.Text = cart1[0].ToString();
            HyperLink3.NavigateUrl = cart2[0].ToString();
        }
        else if (cart1.Count == 4)
        {
            HyperLink1.Text = cart1[3].ToString();
            HyperLink1.NavigateUrl = cart2[3].ToString();
            HyperLink2.Text = cart1[2].ToString();
            HyperLink2.NavigateUrl = cart2[2].ToString();
            HyperLink3.Text = cart1[1].ToString();
            HyperLink3.NavigateUrl = cart2[1].ToString();
            HyperLink4.Text = cart1[0].ToString();
            HyperLink4.NavigateUrl = cart2[0].ToString();
        }
        else if (cart1.Count == 5)
        {
            HyperLink1.Text = cart1[4].ToString();
            HyperLink1.NavigateUrl = cart2[4].ToString();
            HyperLink2.Text = cart1[3].ToString();
            HyperLink2.NavigateUrl = cart2[3].ToString();
            HyperLink3.Text = cart1[2].ToString();
            HyperLink3.NavigateUrl = cart2[2].ToString();
            HyperLink4.Text = cart1[1].ToString();
            HyperLink4.NavigateUrl = cart2[1].ToString();
            HyperLink5.Text = cart1[0].ToString();
            HyperLink5.NavigateUrl = cart2[0].ToString();
        }
        if (cart1.Count > 5)
        {
            HyperLink1.Text = cart1[cart1.Count - 1].ToString();
            HyperLink1.NavigateUrl = cart2[cart1.Count - 1].ToString();
            HyperLink2.Text = cart1[cart1.Count - 2].ToString();
            HyperLink2.NavigateUrl = cart2[cart1.Count - 2].ToString();
            HyperLink3.Text = cart1[cart1.Count - 3].ToString();
            HyperLink3.NavigateUrl = cart2[cart1.Count - 3].ToString();
            HyperLink4.Text = cart1[cart1.Count - 4].ToString();
            HyperLink4.NavigateUrl = cart2[cart1.Count - 4].ToString();
            HyperLink5.Text = cart1[cart1.Count - 5].ToString();
            HyperLink5.NavigateUrl = cart2[cart1.Count - 5].ToString();
        }
    }
}