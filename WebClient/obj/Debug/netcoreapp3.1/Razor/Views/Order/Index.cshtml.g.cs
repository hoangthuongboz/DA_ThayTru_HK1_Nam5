#pragma checksum "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10f33541b49b3069cf0d3551e9381186793a912d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\user\Downloads\DOAN\WebClient\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10f33541b49b3069cf0d3551e9381186793a912d", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f4b7fc62913b65abf405431ce3e09d1e5ab3cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Orders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/order/process"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
  
    Layout = "LayoutPage";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<br />
    <h2 class=""text-center"" style=""text-transform: uppercase;font-size: 38px;color: #485650;font-weight: bold;
"">
        Đơn hàng
    </h2>

<table>
    <thead>
        <tr>
            <th>Mã đơn hàng</th>
            <th>Ngày đặt</th>
            <th>Người giao hàng</th>
            <th>Số điện thoại người giao</th>
            <th>Trạng thái đơn hàng</th>
            <th></th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
           Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
           Write(item.HOTEN_DL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
           Write(item.SDT_DL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
             if (User.IsInRole("DELIVER"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td hidden><a style=\"text-decoration:none\"");
            BeginWriteAttribute("href", " href=\"", 934, "\"", 961, 2);
            WriteAttributeValue("", 941, "order/items/", 941, 12, true);
#nullable restore
#line 37 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
WriteAttributeValue("", 953, item.Id, 953, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chi tiết đơn hàng</a></td>\r\n");
#nullable restore
#line 38 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td><a style=\"text-decoration:none\"");
            BeginWriteAttribute("href", " href=\"", 1090, "\"", 1117, 2);
            WriteAttributeValue("", 1097, "order/items/", 1097, 12, true);
#nullable restore
#line 41 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
WriteAttributeValue("", 1109, item.Id, 1109, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chi tiết đơn hàng</a></td>\r\n");
#nullable restore
#line 42 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
             if (User.IsInRole("DELIVER"))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
                 if (item.Status_code == "S")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Hoàn tất</td>\r\n");
#nullable restore
#line 48 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10f33541b49b3069cf0d3551e9381186793a912d8171", async() => {
                WriteLiteral("\r\n                            <input hidden");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1523, "\"", 1537, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"S\" type=\"text\" name=\"Status\"");
                BeginWriteAttribute("required", " required=\"", 1574, "\"", 1585, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input hidden");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1632, "\"", 1646, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1647, "\"", 1663, 1);
#nullable restore
#line 54 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
WriteAttributeValue("", 1655, item.Id, 1655, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" name=\"Id\"");
                BeginWriteAttribute("required", " required=\"", 1686, "\"", 1697, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button>Xác nhận giao hàng</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 58 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
                 
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
                 if (item.Status_code == "P" || item.Status_code == "C")
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10f33541b49b3069cf0d3551e9381186793a912d11679", async() => {
                WriteLiteral("\r\n                            <input hidden");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2217, "\"", 2231, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"X\" type=\"text\" name=\"Status\"");
                BeginWriteAttribute("required", " required=\"", 2268, "\"", 2279, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input hidden");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2326, "\"", 2340, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2341, "\"", 2357, 1);
#nullable restore
#line 68 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
WriteAttributeValue("", 2349, item.Id, 2349, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" name=\"Id\"");
                BeginWriteAttribute("required", " required=\"", 2380, "\"", 2391, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button>Hủy đơn hàng</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 72 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"

                }
                else if (item.Status_code == "X")
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10f33541b49b3069cf0d3551e9381186793a912d14786", async() => {
                WriteLiteral("\r\n                            <input hidden");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2807, "\"", 2821, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"P\" type=\"text\" name=\"Status\"");
                BeginWriteAttribute("required", " required=\"", 2858, "\"", 2869, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input hidden");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2916, "\"", 2930, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2931, "\"", 2947, 1);
#nullable restore
#line 80 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
WriteAttributeValue("", 2939, item.Id, 2939, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" name=\"Id\"");
                BeginWriteAttribute("required", " required=\"", 2970, "\"", 2981, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button>Đặt lại hàng</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 84 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Hoàn tất</td>\r\n");
#nullable restore
#line 88 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tr>\r\n");
#nullable restore
#line 93 "C:\Users\user\Downloads\DOAN\WebClient\Views\Order\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    \r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
