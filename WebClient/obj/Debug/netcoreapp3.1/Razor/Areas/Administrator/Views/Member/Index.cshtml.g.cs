#pragma checksum "C:\Users\user\Downloads\DOAN\WebClient\Areas\Administrator\Views\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05795480471cf7663b410dd2ce1d2954bb10333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Member_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Member/Index.cshtml")]
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
#line 1 "C:\Users\user\Downloads\DOAN\WebClient\Areas\Administrator\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05795480471cf7663b410dd2ce1d2954bb10333", @"/Areas/Administrator/Views/Member/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f9e30f068eca4a4f95ecaef724208d83a99b9c", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Member_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Account>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Downloads\DOAN\WebClient\Areas\Administrator\Views\Member\Index.cshtml"
  
    Layout = "_LayoutHome";
    ViewData["Title"] = "ManagerMember";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""/css/style.css"" rel=""stylesheet"" />

<div class=""table-area"">
    <h1>Danh sách tài khoản</h1>
    <button class=""create-btn"">
        <a href=""/administrator/member/create"">Tạo mới</a>
    </button>
    <table>
        <thead>
            <tr>
                <th>Tên người dùng</th>
                <th>Địa chỉ Email</th>
                <th>Quản lý vai trò</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\user\Downloads\DOAN\WebClient\Areas\Administrator\Views\Member\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\user\Downloads\DOAN\WebClient\Areas\Administrator\Views\Member\Index.cshtml"
                   Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\user\Downloads\DOAN\WebClient\Areas\Administrator\Views\Member\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 762, "\"", 804, 2);
            WriteAttributeValue("", 769, "/administrator/member/role/", 769, 27, true);
#nullable restore
#line 28 "C:\Users\user\Downloads\DOAN\WebClient\Areas\Administrator\Views\Member\Index.cshtml"
WriteAttributeValue("", 796, item.Id, 796, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Roles</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\user\Downloads\DOAN\WebClient\Areas\Administrator\Views\Member\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591
