using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace VitalWeb.Helpers
{
    // Crée le Tag-Helper <my-first></my-first>
    // Voir également les modifications dans le _ViewImport.cshtml
    public class MyHelper : TagHelper
    {
        public string MyLink { get; set; }

        public override void Init(TagHelperContext context)
        {
            base.Init(context);
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            output.Attributes.SetAttribute("href", MyLink);
            // ou
            output.Attributes.Add("class", "btn btn-primary");

            output.Content.SetContent("Mon lien");
            // output.Content.SetHtmlContent();
        }
    }
}