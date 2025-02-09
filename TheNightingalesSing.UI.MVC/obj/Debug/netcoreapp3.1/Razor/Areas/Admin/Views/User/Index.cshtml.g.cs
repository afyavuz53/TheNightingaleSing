#pragma checksum "C:\Users\Ahmet Yavuz\Source\Repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27afb55ea7a8a5d6f62566f697f46610166c2042"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 2 "C:\Users\Ahmet Yavuz\Source\Repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Areas\Admin\Views\_ViewImports.cshtml"
using TheNightingalesSing.UI.MVC.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27afb55ea7a8a5d6f62566f697f46610166c2042", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e17ba1ef25555857545f374c67ddc2102b49e2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ahmet Yavuz\Source\Repos\TheNightingaleSing\TheNightingalesSing.UI.MVC\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_adminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcumb-area bg-img bg-overlay"" style=""background-image: url(../../img/bg-img/breadcumb.jpg);"">
    <div class=""bradcumbContent"">
        <p>Kullanıcılar</p>
        <h2>Users Page</h2>
    </div>
</section>

<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Kullanıcı Adı</th>
            <th scope=""col"">E-Mail</th>
            <th scope=""col"">Rolü</th>
            <th scope=""col"">Aktiflik</th>
        </tr>
    </thead>
    <tbody id=""tableBody"">
    </tbody>
</table>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $.ajax({
                type: ""GET"",
                url: ""http://localhost:53177/api/user"",
                success: function (veri) {
                    $.ajax({
                        type: ""POST"",
                        url: ""http://localhost:53234/Admin/user/LoadUserTable"",
                        data: JSON.stringify(veri),
                        contentType: ""application/Json; charset=UTF-8"",
                        success: function (response) {
                            $(""#tableBody"").html(response)
                        }
                    })
                }
            })
        })
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
