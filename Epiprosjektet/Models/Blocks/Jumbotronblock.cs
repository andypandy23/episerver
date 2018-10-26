using EPiServer.Core;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.DataAnnotations;
using EPiServer.DataAbstraction;
using EPiServer;

namespace Epiprosjektet.Models.Blocks
{
    [ContentType(
        GUID = "77b6a134-0193-485f-a26c-1cb4c8c26cc9",
        DisplayName = "Jumbotron",
        Description = "Jumbotron blocktype with header, description, image and button")]
    [ImageUrl("~/Content/icons/jumbotronblocktype.jpg")]
    public class Jumbotronblock : BlockData
    {
        [Display(
           Name = "Header",
           Description = "Enter a header for the block",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        [Required]
        public virtual string Header { get; set; }

        [Display(
            Name = "Description",
            Description = "Enter a Description for the block",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [Required]
        public virtual XhtmlString Description { get; set; }

        [Display(
            Name = "Image",
            Description = "Chose a image for the block",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [Required]
        public virtual Url Image { get; set; }

        [Display(
            Name = "Button label",
            Description = "Enter a label for the button",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [Required]
        public virtual string Button { get; set; }

        [Display(
            Name = "Url",
            Description = "Enter a Url for the button",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        [Required]
        public virtual Url Url { get; set; }
    }
}