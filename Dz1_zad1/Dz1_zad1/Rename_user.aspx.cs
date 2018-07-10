using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dz1_zad1
{
    public partial class Rename_user : System.Web.UI.Page
    {
        public static bool flag_load = true;
        private static int id_table = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink11.NavigateUrl = "Table.aspx";

            
                if (Request.QueryString["value"] != null)
                {
                    Add_id(Request.QueryString["value"].ToString());
                }
            
        }

        private void Add_id(string id)
        {
            //id=id.Trim('*');
            id_table = Convert.ToInt32(id);
            Single single = Single.GetSingle();
            foreach (User VARIABLE in single.GetUsers())
            {
                if (VARIABLE.Id.ToString().Equals(id))
                {
                    TextBox1_Log.Text = VARIABLE.Login;
                    TextBox2_Pasvord.Text = VARIABLE.Pasword;
                    foreach (ListItem V in DropDownList11.Items)
                    {
                        V.Selected = false;
                        if (VARIABLE.Get_role().Name.Equals(V.Text))
                        {
                            V.Selected = true;
                        }
                    }
                }
            }
            flag_load = false;
        }
        protected void Button11_OnClick(object sender, EventArgs e)
        {
            Single single = Single.GetSingle();
            foreach (User VARIABLE in single.GetUsers())
            {
                if (id_table == VARIABLE.Id)
                {
                    VARIABLE.Rename_User(TextBox1_Log.Text,TextBox2_Pasvord.Text,DropDownList11.SelectedItem.Text);
                }
            }

            TextBox1_Log.Text = null;
            TextBox2_Pasvord.Text = null;
            foreach (ListItem VARIABLE in DropDownList11.Items)
            {
                VARIABLE.Selected = false;
            }

            id_table = 0;
        }
    }
}