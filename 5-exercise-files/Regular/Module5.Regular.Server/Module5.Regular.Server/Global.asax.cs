using System.Web;
using System.Web.Routing;

namespace Module5.Regular.Server
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
