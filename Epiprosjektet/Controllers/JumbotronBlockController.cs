using System.Web.Mvc;
using Epiprosjektet.Models.Blocks;
using EPiServer.Web.Mvc;

namespace Epiprosjekte.Controllers
{
    public class JumbotronBlockController : BlockController<Jumbotronblock>
    {
        public override ActionResult Index(Jumbotronblock currentblock)
        {
            return PartialView(currentblock);
        }

    }
}