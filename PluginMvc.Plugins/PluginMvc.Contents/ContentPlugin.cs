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
            get { return "Contents"; }//项目下查找页面的路径
        }

        public void Initialize()
        {
            RouteTable.Routes.MapRoute(
                name: "content_list",
                url: "content/{action}",
                defaults: new { controller = "Content", action = "List", id = UrlParameter.Optional, pluginName = this.Name }//pluginName = this.Name 视图模版引擎需要,对应的插件在项目下的目录
            );
        }

        public void Unload()
        {
            RouteTable.Routes.Remove(RouteTable.Routes["content_list"]);
        }
    }
}