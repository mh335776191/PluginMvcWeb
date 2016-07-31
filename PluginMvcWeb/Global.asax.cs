namespace PluginMvcWeb
{
    using System.Web;
    using System.Web.Routing;
    using App_Start;

    /// <summary>
    /// MVC 应用程序。
    /// </summary>
    public class MvcApplication : HttpApplication
    {
        /// <summary>
        /// 应用程序启动。
        /// </summary>
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
           // RouteDebug.RouteDebugger.RewriteRoutesForTesting(RouteTable.Routes);
        }
    }
}