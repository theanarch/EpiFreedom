using System;
using System.ComponentModel.DataAnnotations;
using EpiFinal.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiFinal.Models.Pages
{
    [SiteContentType(
        DisplayName = "Name Page in Controller",
        GUID = "acd826ee-340c-44b8-9b91-92aa397be65d",
        GroupName = Global.GroupNames.Default)]
    public class NamePage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "The name",
            Description = "Description of name",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string UserName { get; set; }

        //[Display(GroupName = SystemTabNames.Content)]
        //public virtual EditorialBlock DogShit { get; set; }
    }
}