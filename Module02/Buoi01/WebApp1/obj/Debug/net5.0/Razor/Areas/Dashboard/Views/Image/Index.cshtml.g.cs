#pragma checksum "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Image\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88bf2ce29149374f30b95acc149da4a2d4c00cef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Image_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Image/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88bf2ce29149374f30b95acc149da4a2d4c00cef", @"/Areas/Dashboard/Views/Image/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b88d4eee74e5e5ee30f1386c0484a7440d3c48", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_Image_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Image>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("frm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div>
    <a class=""btn btn-primary"" href=""/dashboard/image/create"">Create</a>
    <a class=""btn btn-primary"" href=""/dashboard/image/multiple"">Multiple</a>
    <a class=""btn btn-primary"" href=""/dashboard/image/Icon"">Icon</a>
    <a class=""btn btn-primary"" href=""/dashboard/image/Ajax"">Ajax</a>
    <a class=""btn btn-primary"" href=""/dashboard/image/Webcam"">Webcam</a>
</div>


<!-- Button to Open the Modal -->
<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"">
    Upload Ajax
</button>

<!-- The Modal -->
<div class=""modal"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88bf2ce29149374f30b95acc149da4a2d4c00cef5353", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Upload Image</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                </div>
                <div class=""modal-body"">
                    <div>
                        <label>Chose Image</label>
                        <input type=""file"" name=""f"" accept=""image/*"" />
                    </div>
                    <div>
                        <button>Save Changes</button>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button  type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"">Save changes</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </div>
    </div>
</div>



<table class=""table table-bordered"">
    <thead class=""table-dark"">
        <tr>
            <th>Id</th>
            <td>Original</td>
            <td>Url</td>
            <td>Type</td>
            <td>Size</td>
            <td>
                Delete
            </td>
            <td>Edit</td>
        </tr>
    </thead>
    <tbody id=""sheet"">
");
#nullable restore
#line 63 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Image\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 66 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Image\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 67 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Image\Index.cshtml"
               Write(item.Original);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88bf2ce29149374f30b95acc149da4a2d4c00cef9118", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2260, "~/images/", 2260, 9, true);
#nullable restore
#line 69 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Image\Index.cshtml"
AddHtmlAttributeValue("", 2269, item.Url, 2269, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 71 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Image\Index.cshtml"
               Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 72 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Image\Index.cshtml"
               Write(item.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2425, "\"", 2464, 2);
            WriteAttributeValue("", 2432, "/dashboard/image/delete/", 2432, 24, true);
#nullable restore
#line 74 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Image\Index.cshtml"
WriteAttributeValue("", 2456, item.Id, 2456, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fa fa-trash\"></i>\r\n                    </a>\r\n                </td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 80 "D:\TrungTamTinHoc_DHKH-TN\Module02\Buoi01\WebApp1\Areas\Dashboard\Views\Image\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>
    $(frm).submit(function (ev) {
        ev.preventDefault();
        var f = this['f'].files[0];
        //console.log(f);
        var fd = new FormData();
        fd.append('f', f);
        $.ajax({
            url: '/dashboard/image/ajax',
            type: 'post',
            data: fd,
            contentType: false,
            processData: false,
            success: (d) => {
                //console.log(d);
                $(sheet).append(`
                                    <tr>
                                          <td>${d['id']}</td>
                                            <td>${d['original']}</td>
                                            <td>
                                                <img width=""70"" src=""/images/${d['url']}"" />
                                            </td>
                                            <td>${d['type']}</td>
                                            <td>${d['size']}</td>
              ");
            WriteLiteral(@"                              <td>
                                                <a href=""/dashboard/image/delete/${d['id']}"">
                                                    <i class=""fas fa-trash""></i>
                                                </a>
                                            </td>

                                    </tr>
                                `);
                $(myModal).modal('hide');
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Image>> Html { get; private set; }
    }
}
#pragma warning restore 1591
