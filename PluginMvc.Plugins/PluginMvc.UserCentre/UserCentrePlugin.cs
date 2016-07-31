using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using PluginMvc.Framework;

namespace PluginMvc.UserCentre
{
    public class UserCentrePlugin : IPlugin
    {
        public string Name
        {
            get
            {
                return "UserCentre";
            }
        }

        public void Initialize()
        {
            RouteTable.Routes.MapRoute(
               name: "user_centre",
               url: "UserCentre/{action}",
               defaults: new { controller = "UserCentre", action = "Index", id = UrlParameter.Optional, pluginName = this.Name }//pluginName = this.Name 视图模版引擎需要,对应的插件在项目下的目录
           );
        }

        public void Unload()
        {
            RouteTable.Routes.Remove(RouteTable.Routes["user_centre"]);
        }
    }
}