using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dz1_zad1
{
    /// <summary>
    /// Summary description for Delete
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            int id;
            if (context.Request.QueryString["id"] != null)
            {
                id = Convert.ToInt32(context.Request.QueryString["id"]);
                var Fin_id = Single.GetSingle().GetUsers().Find(User => User.Id == id);
                if (Fin_id != null)
                {
                    Single.GetSingle().GetUsers().Remove(Fin_id);
                }
            }
            context.Server.Transfer("Table.aspx",true);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}