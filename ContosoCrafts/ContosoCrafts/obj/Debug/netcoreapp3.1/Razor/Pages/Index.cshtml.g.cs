#pragma checksum "/Users/Manqi/Desktop/TTS_FullStack/ContosoCrafts/ContosoCrafts/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e741b844dcb059dc1aec2a2591fa445e8eb043e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoCrafts.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContosoCrafts.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/Manqi/Desktop/TTS_FullStack/ContosoCrafts/ContosoCrafts/Pages/_ViewImports.cshtml"
using ContosoCrafts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e741b844dcb059dc1aec2a2591fa445e8eb043e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f365603219ce5452108752223134ec3e9a62f2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/Manqi/Desktop/TTS_FullStack/ContosoCrafts/ContosoCrafts/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Contoso Crafts</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n</div>\n\n<div class=\"card-columns\">\n");
#nullable restore
#line 13 "/Users/Manqi/Desktop/TTS_FullStack/ContosoCrafts/ContosoCrafts/Pages/Index.cshtml"
     foreach (var product in Model.products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\n            <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 398, "\"", 446, 4);
            WriteAttributeValue("", 406, "background-image:", 406, 17, true);
            WriteAttributeValue(" ", 423, "url(\'", 424, 6, true);
#nullable restore
#line 16 "/Users/Manqi/Desktop/TTS_FullStack/ContosoCrafts/ContosoCrafts/Pages/Index.cshtml"
WriteAttributeValue("", 429, product.Image, 429, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 443, "\');", 443, 3, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
#nullable restore
#line 18 "/Users/Manqi/Desktop/TTS_FullStack/ContosoCrafts/ContosoCrafts/Pages/Index.cshtml"
                                  Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            </div>\n        </div>\n");
#nullable restore
#line 21 "/Users/Manqi/Desktop/TTS_FullStack/ContosoCrafts/ContosoCrafts/Pages/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591