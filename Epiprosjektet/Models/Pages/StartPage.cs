using EPiServer.Core;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epiprosjektet.Models.Pages
{
    [ContentType]
    public class StartPage : PageData
    {
        public virtual string Heading { get; set; }
        public virtual XhtmlString MainBody { get; set; }
        public virtual ContentArea MainContentArea { get; set; }
    }
}