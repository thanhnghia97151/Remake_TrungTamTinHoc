#pragma checksum "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c61325a2aa6ab2bff34aef062b8ed66852bb019"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Member_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Member/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c61325a2aa6ab2bff34aef062b8ed66852bb019", @"/Areas/Dashboard/Views/Member/Index.cshtml")]
    public class Areas_Dashboard_Views_Member_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp1.Models.Member>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1 class=""mt-4"">Manage member</h1>
<ol class=""breadcrumb mb-4"">
    <li class=""breadcrumb-item""><a href=""/dashboard"">Dashboard</a></li>
    <li class=""breadcrumb-item active"">Member</li>
</ol>
<table class=""table table-bordered"">
    <thead class=""table-dark"">
        <tr>
            <th>Id</th>
            <th>Username</th>
            <th>Email</th>
            <th>Gender</th>
            <th>Roles</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Member\Index.cshtml"
         foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Member\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Member\Index.cshtml"
                   Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Member\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Member\Index.cshtml"
                   Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 797, "\"", 835, 2);
            WriteAttributeValue("", 804, "/dashboard/member/role/", 804, 23, true);
#nullable restore
#line 26 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Member\Index.cshtml"
WriteAttributeValue("", 827, item.Id, 827, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Roles</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 29 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Member\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp1.Models.Member>> Html { get; private set; }
    }
}
#pragma warning restore 1591
