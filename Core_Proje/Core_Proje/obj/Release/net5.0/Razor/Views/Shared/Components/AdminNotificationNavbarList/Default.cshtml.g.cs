#pragma checksum "C:\Users\bedir\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\AdminNotificationNavbarList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14c9037b5a5d7438c5d865dcbd6da73814a95e29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminNotificationNavbarList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminNotificationNavbarList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14c9037b5a5d7438c5d865dcbd6da73814a95e29", @"/Views/Shared/Components/AdminNotificationNavbarList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdminNotificationNavbarList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<li class=""nav-item dropdown border-left"">
    <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
        <i class=""mdi mdi-bell""></i>
        <span class=""count bg-danger""></span>
    </a>
    <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
        <h6 class=""p-3 mb-0"">Bildirimler</h6>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-dark rounded-circle"">
                    <i class=""mdi mdi-calendar text-success""></i>
                </div>
            </div>
            <div class=""preview-item-content"">
                <p class=""preview-subject mb-1"">Bugün yapılacaklar</p>
                <p class=""text-muted ellipsis mb-0""> Bugün yapman gereken işler</p>
            </div>
        </a>
        <div class=""dropdown-divider""></div>
        <a class=");
            WriteLiteral(@"""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-dark rounded-circle"">
                    <i class=""mdi mdi-settings text-danger""></i>
                </div>
            </div>
            <div class=""preview-item-content"">
                <p class=""preview-subject mb-1"">Ayarlar</p>
                <p class=""text-muted ellipsis mb-0""> Dashboard Güncelle </p>
            </div>
        </a>
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item preview-item"">
            <div class=""preview-thumbnail"">
                <div class=""preview-icon bg-dark rounded-circle"">
                    <i class=""mdi mdi-link-variant text-warning""></i>
                </div>
            </div>
            <div class=""preview-item-content"">
                <p class=""preview-subject mb-1"">Duyuru Detayları</p>
                <p class=""text-muted ellipsis mb-0""> Duyuru Paneline Git</p>
            </div>
        </a>
        <div class=""dr");
            WriteLiteral("opdown-divider\"></div>\n        <p class=\"p-3 mb-0 text-center\">Tüm Bildirimleri Gör </p>\n    </div>\n</li>\n");
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
