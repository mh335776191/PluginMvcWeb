namespace PluginMvc.Contents.Controllers
{
    using System.Web.Mvc;

    using PluginMvc.Contents.Models;

    /// <summary>
    /// 内容控制器。
    /// </summary>
    public class ContentController : Controller
    {
        public ActionResult List()
        {
            ContentItem contentItem = new ContentItem { Id = 1, Title = "这里是内容插件信息。" };

            return View(contentItem);
        }
    }
}