#pragma checksum "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7409e6b501b6762ebe3723de379374bc4de3697"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7409e6b501b6762ebe3723de379374bc4de3697", @"/Areas/Dashboard/Views/Home/Index.cshtml")]
    public class Areas_Dashboard_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1 class=\"mt-4\">Static Navigation</h1>\n<h2>");
#nullable restore
#line 2 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Home\Index.cshtml"
Write(ViewBag.hello);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<ol class=""breadcrumb mb-4"">
    <li class=""breadcrumb-item""><a href=""index.html"">Dashboard</a></li>
    <li class=""breadcrumb-item active"">Static Navigation</li>
</ol>
<div class=""card mb-4"">
    <div class=""card-body"">
        <p class=""mb-0"">
            This page is an example of using static navigation. By removing the
            <code>.sb-nav-fixed</code>
            class from the
            <code>body</code>
            , the top navigation and side navigation will become static on scroll. Scroll down this page to see an example.
        </p>
    </div>
</div>
<div style=""height: 100vh""></div>
<div class=""card mb-4""><div class=""card-body"">When scrolling, the navigation stays at the top of the page. This is the end of the static navigation demo.</div></div>");
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
