using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;

namespace HRIS.Web.Framework.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString AdminHeader(this HtmlHelper htmlHelper, string title)
        {
            string html = @"
                <div class='content-header'>
                    <span class='title'>" + title + @"</span>
                    <div class='clearfix'></div>
                    <hr />
                </div>
            ";

            return MvcHtmlString.Create(html);
        }

        public static MvcHtmlString AdminHeader(this HtmlHelper htmlHelper, string title, Func<object, HelperResult> template)
        {
            string additional = template.Invoke(null).ToHtmlString();

            string html = @"
                <div class='content-header'>
                    <span class='title'>" + title + @"</span>" + additional + @"
                    <div class='clearfix'></div>
                    <hr />
                </div>
            ";

            return MvcHtmlString.Create(html);
        }

        public static MvcHtmlString BootstrapClearFix(this HtmlHelper htmlHelper)
        {
            string html = @"<div class='clearfix'></div>";
            return MvcHtmlString.Create(html);
        }

        public static void ClientHeader(this WebViewPage wvp, string header)
        {
            wvp.ViewBag.ClientHeader = header;
        }

        #region File Version


        public static string GetFileUrl(this HtmlHelper helper, string filename, string fileOptionIfNotExist)
        {

            if (!File.Exists(helper.ViewContext.HttpContext.Server.MapPath(filename)))
            {
                filename = fileOptionIfNotExist;
            }

            string newfile = "";
            string version = GetVersion(helper, filename, out newfile);
            return newfile + version;
        }

        public static string GetFileUrl(this HtmlHelper helper, string filename)
        {
            string newfile = "";
            string version = GetVersion(helper, filename, out newfile);
            return newfile + version;
        }

        public static MvcHtmlString IncludeVersionedCss(this HtmlHelper helper, string filename)
        {
            string newfile = "";
            string version = GetVersion(helper, filename, out newfile);
            return MvcHtmlString.Create("<link href='" + newfile + version + "' rel='stylesheet' type='text/css' />");
        }

        public static MvcHtmlString IncludeVersionedJs(this HtmlHelper helper, string filename)
        {
            string newfile = "";
            string version = GetVersion(helper, filename, out newfile);
            return MvcHtmlString.Create("<script type='text/javascript' src='" + newfile + version + "'></script>");
        }

        private static string GetVersion(this HtmlHelper helper, string filename, out string newfile)
        {
            var context = helper.ViewContext.HttpContext;
            var url = new UrlHelper(helper.ViewContext.RequestContext);

            filename = url.Content(filename);
            newfile = filename;

            if (context.Cache[filename] == null)
            {
                var physicalPath = context.Server.MapPath(filename);
                var version = "?v=" + new System.IO.FileInfo(physicalPath).LastWriteTime.ToString("yyyyMMddhhmmss");
                context.Cache.Add(physicalPath, version, null, DateTime.Now.AddMinutes(1), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Normal, null);
                context.Cache[physicalPath] = version;
                return version;
            }
            else
            {
                return context.Cache[filename] as string;
            }
        }

        #endregion File Version
    }
}