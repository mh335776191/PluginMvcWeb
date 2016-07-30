namespace PluginMvc.Contents
{
    using System.Web.Mvc;
    using System.Web.Routing;

    using PluginMvc.Framework;

    /// <summary>
    /// 内容插件。
    /// </summary>
    public class ContentPlugin : IPlugin
    {
        public string Name
        {
            get { return "Contents"; }
        }

        public void Initialize()
        {
            RouteTable.Routes.MapRoute(
                name: "content_list",
                url: "content/list",
                defaults: new { controller = "Content", action = "List", id = UrlParameter.Optional, pluginName = this.Name }
            );
        }

        public void Unload()
        {
            RouteTable.Routes.Remove(RouteTable.Routes["content_list"]);
        }
    }
}