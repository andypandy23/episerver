using Epiprosjektet.Models.Pages;
using StartPage = Epiprosjektet.Models.Pages.StartPage;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epiprosjektet.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        //Get: Startpage
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}