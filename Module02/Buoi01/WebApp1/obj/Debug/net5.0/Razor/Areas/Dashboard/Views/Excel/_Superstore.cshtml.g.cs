#pragma checksum "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bce93c0b706c5bcd4644f7d581e03d8d910830d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Excel__Superstore), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Excel/_Superstore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bce93c0b706c5bcd4644f7d581e03d8d910830d2", @"/Areas/Dashboard/Views/Excel/_Superstore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b88d4eee74e5e5ee30f1386c0484a7440d3c48", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_Excel__Superstore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebApp1.Models.Superstore>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-bordered"">
    <thead class=""table-dark"">
        <tr>
            <th>Row Id</th>
            <th>Order Id</th>
            <th>Order Date</th>
            <th>Ship Date</th>
            <th>Customer Id</th>
            <th>Customer Name</th>
            <th>Segment</th>
            <th>Coutry</th>
            <th>State</th>
            <th>Postal Code</th>
            <th>Region</th>
            <th>Product Id</th>
            <th>Category</th>
            <th>Sub Category</th>
            <th>Product name</th>
            <th>Sales</th>
            <th>Quantity</th>
            <th>Discount</th>
            <th>Profit</th>
        </tr>
    </thead>
    <tbody id=""sheet"">
");
#nullable restore
#line 28 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 31 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.RowId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.ShipDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.Segment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.Region);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.SubCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.Sales);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 49 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
           Write(item.Profit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Excel\_Superstore.cshtml"
            
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebApp1.Models.Superstore>> Html { get; private set; }
    }
}
#pragma warning restore 1591
