using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dz1_zad1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "Table.aspx";
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Single single = Single.GetSingle();
            single.Set_User(TextBox1_Log.Text, TextBox2_Pasvord.Text, DropDownList1.SelectedItem.Text);
            TextBox1_Log.Text = null;
            TextBox2_Pasvord.Text = null;
        }
    }
}