#pragma checksum "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfd2a1172dcfb12a339265da9176d7e133128bcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Ward_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Ward/Index.cshtml")]
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
#line 2 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\_ViewImports.cshtml"
using WebApp1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfd2a1172dcfb12a339265da9176d7e133128bcf", @"/Areas/Dashboard/Views/Ward/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b88d4eee74e5e5ee30f1386c0484a7440d3c48", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_Ward_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp1.Models.Ward>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"pagination\">\r\n");
#nullable restore
#line 3 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
       int p = ViewContext.RouteData.Values["id"] != null ? Convert.ToInt32(ViewContext.RouteData.Values["id"]) : 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
     for (int i = 1; i <= ViewBag.total; i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
         if (p==i)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active \" >\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 344, "\"", 375, 2);
            WriteAttributeValue("", 351, "/dashboard/ward/index/", 351, 22, true);
#nullable restore
#line 9 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
WriteAttributeValue("", 373, i, 373, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 11 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
        }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"page-item\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 526, "\"", 557, 2);
            WriteAttributeValue("", 533, "/dashboard/ward/index/", 533, 22, true);
#nullable restore
#line 15 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
WriteAttributeValue("", 555, i, 555, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </li>\r\n");
#nullable restore
#line 17 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
                 
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<table class=\"table table-bordered\">\r\n    <thead class=\"table-dark\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Name</th>\r\n            <th>District Id</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
               Write(item.DistrictId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Ward\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp1.Models.Ward>> Html { get; private set; }
    }
}
#pragma warning restore 1591
