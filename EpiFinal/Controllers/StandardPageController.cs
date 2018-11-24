using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EpiFinal.Models.Pages;
using EpiFinal.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace EpiFinal.Controllers
{
    public class StandardPageController : PageControllerBase<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            var model = CreateModel(currentPage);
            return View(string.Format("~/Views/{0}/Index.cshtml", currentPage.GetOriginalType().Name), model);
        }

        private static IPageViewModel<SitePageData> CreateModel(SitePageData page)
        {
            var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
            return Activator.CreateInstance(type, page) as IPageViewModel<SitePageData>;
        }
    }
}