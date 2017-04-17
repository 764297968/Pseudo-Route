using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Context.Request.FilePath == "/")
                Context.RewritePath("index.html");
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Application_Error()
        {
            Exception err = HttpContext.Current.Error;
            string str = err.Message + err.StackTrace+ "\r\n------------------------------------\r\n";
            System.IO.File.AppendAllText(Server.MapPath("/Logs")+"/"+DateTime.Now.ToString("yyyyMMdd")+".txt",str);
        }
    }
}
