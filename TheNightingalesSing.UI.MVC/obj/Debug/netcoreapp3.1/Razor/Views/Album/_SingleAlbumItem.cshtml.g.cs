#pragma checksum "C:\Users\Ahmet Yavuz\source\repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Views\Album\_SingleAlbumItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e0ab8874a0f1a879b3c25b75edbfa20168483a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album__SingleAlbumItem), @"mvc.1.0.view", @"/Views/Album/_SingleAlbumItem.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Ahmet Yavuz\source\repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Views\_ViewImports.cshtml"
using TheNightingalesSing.UI.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet Yavuz\source\repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Views\_ViewImports.cshtml"
using TheNightingalesSing.UI.MVC.Models.Cart;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e0ab8874a0f1a879b3c25b75edbfa20168483a5", @"/Views/Album/_SingleAlbumItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403e2ca2503d7820372708b58a93d358f36eed9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Album__SingleAlbumItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AlbumGenreVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Album", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ahmet Yavuz\source\repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Views\Album\_SingleAlbumItem.cshtml"
 foreach (AlbumGenreVM item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 col-sm-4 col-md-3 col-lg-2 single-album-item s e q\">\r\n        <div class=\"single-album\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 200, "\"", 218, 1);
#nullable restore
#line 7 "C:\Users\Ahmet Yavuz\source\repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Views\Album\_SingleAlbumItem.cshtml"
WriteAttributeValue("", 206, item.ArtUrl, 206, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 219, "\"", 225, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            \r\n            <div class=\"album-info\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e0ab8874a0f1a879b3c25b75edbfa20168483a54842", async() => {
                WriteLiteral("\r\n                    <h5>");
#nullable restore
#line 11 "C:\Users\Ahmet Yavuz\source\repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Views\Album\_SingleAlbumItem.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\Ahmet Yavuz\source\repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Views\Album\_SingleAlbumItem.cshtml"
                                                                 WriteLiteral(item.AlbumID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p>");
#nullable restore
#line 13 "C:\Users\Ahmet Yavuz\source\repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Views\Album\_SingleAlbumItem.cshtml"
              Write(item.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\Ahmet Yavuz\source\repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Views\Album\_SingleAlbumItem.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AlbumGenreVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
