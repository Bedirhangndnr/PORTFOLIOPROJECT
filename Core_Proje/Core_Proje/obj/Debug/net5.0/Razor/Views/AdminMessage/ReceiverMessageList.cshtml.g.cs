#pragma checksum "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a6dabe52a51073e04fdec35a7be828a32787684"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_ReceiverMessageList), @"mvc.1.0.view", @"/Views/AdminMessage/ReceiverMessageList.cshtml")]
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
#line 1 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a6dabe52a51073e04fdec35a7be828a32787684", @"/Views/AdminMessage/ReceiverMessageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminMessage_ReceiverMessageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
  
    ViewData["Title"] = "ReceiverMessageList";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar Admin Gelen Kutusu</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Gönderen</th>
                            <th>Konu</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Mesajı Gör</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
                           Write(item.WriterMessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
                           Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 32 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
                           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1202, "\"", 1263, 2);
            WriteAttributeValue("", 1209, "/AdminMessage/AdminMessageDelete/", 1209, 33, true);
#nullable restore
#line 33 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
WriteAttributeValue("", 1242, item.WriterMessageID, 1242, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">SİL</a></td>\r\n                            <td><a");
            BeginWriteAttribute("href", " href=\"", 1344, "\"", 1406, 2);
            WriteAttributeValue("", 1351, "/AdminMessage/AdminMessageDetails/", 1351, 34, true);
#nullable restore
#line 34 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
WriteAttributeValue("", 1385, item.WriterMessageID, 1385, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">DETAY</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\AdminMessage\ReceiverMessageList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <br />\r\n                <a asp-for=\"AdminMessageDelete\" class=\"btn btn-outline-primary\">Yeni Mesaj Oluştur</a>\r\n                <br />\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
