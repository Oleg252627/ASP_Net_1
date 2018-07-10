using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Dz1_zad1
{
    public partial class Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.HyperLink2.NavigateUrl = "Default.aspx";
            Create_Table();
            Rename_user.flag_load = true;
        }

        public void Create_Table()
        {
            int id_count = 0;
            Single single = Single.GetSingle();
            foreach (User VARIABLE in single.GetUsers())
            {
                TableRow row=new TableRow();

                TableCell cell=new TableCell();
                cell.Text = VARIABLE.Id.ToString();
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = VARIABLE.Login;
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = VARIABLE.Pasword;
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = VARIABLE.Get_role().Name;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                HyperLink link=new HyperLink();
                link.Text = "Редактировать";
                link.CssClass = "link_but";
                link.NavigateUrl = $"Rename_user.aspx?value={VARIABLE.Id}";
                cell4.Controls.Add(link);
                row.Cells.Add(cell4);
  
                TableCell cell5 =new TableCell();
                LinkButton link2 = new LinkButton();
                link2.Text = "Удалить";
                link2.CssClass = "link_but";
                link2.PostBackUrl = $"Delete.ashx?id={VARIABLE.Id}";
                cell5.Controls.Add(link2);
                row.Cells.Add(cell5);
                Table1.Rows.Add(row);
            }
        }
    }
}