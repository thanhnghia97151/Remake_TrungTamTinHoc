#pragma checksum "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Room\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56a002f8fd399eadf80393bf5b612f05ed728537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Index), @"mvc.1.0.view", @"/Views/Room/Index.cshtml")]
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
#line 1 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\_ViewImports.cshtml"
using WebApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\_ViewImports.cshtml"
using WebApp1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56a002f8fd399eadf80393bf5b612f05ed728537", @"/Views/Room/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb8f415ee837e403ed49c567f4539b4c654de94d", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp1.Models.Room>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Room\Index.cshtml"
Write(Html.ActionLink("Create", "Create", "Room"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead class=""table-dark"">
        <tr>
            <th>
                Room Id
            </th>
            <th>Room Number</th>
            <th>Capacity</th>
            <th>&nbsp;</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Room\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Room\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Room\Index.cshtml"
               Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Room\Index.cshtml"
               Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 592, "\"", 620, 2);
            WriteAttributeValue("", 599, "/Room/Delete/", 599, 13, true);
#nullable restore
#line 24 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Room\Index.cshtml"
WriteAttributeValue("", 612, item.Id, 612, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash\"></i>|</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 679, "\"", 705, 2);
            WriteAttributeValue("", 686, "/Room/Edit/", 686, 11, true);
#nullable restore
#line 25 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Room\Index.cshtml"
WriteAttributeValue("", 697, item.Id, 697, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Views\Room\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp1.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
