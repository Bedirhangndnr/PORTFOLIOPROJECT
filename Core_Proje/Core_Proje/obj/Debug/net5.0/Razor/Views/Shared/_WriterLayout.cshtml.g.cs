#pragma checksum "C:\Users\bedir\source\repos\PORTFOLIOPROJECT\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fea4f220feb408376386ca7e7d247231c86af53b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__WriterLayout), @"mvc.1.0.view", @"/Views/Shared/_WriterLayout.cshtml")]
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
#line 1 "C:\Users\bedir\source\repos\PORTFOLIOPROJECT\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bedir\source\repos\PORTFOLIOPROJECT\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea4f220feb408376386ca7e7d247231c86af53b", @"/Views/Shared/_WriterLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__WriterLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
#nullable restore
#line 4 "C:\Users\bedir\source\repos\PORTFOLIOPROJECT\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/HeadPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fea4f220feb408376386ca7e7d247231c86af53b3492", async() => {
                WriteLiteral("\n    <div class=\"container-scroller\">\n        <!-- partial:~/skydash/partials/_navbar.html -->\n        ");
#nullable restore
#line 9 "C:\Users\bedir\source\repos\PORTFOLIOPROJECT\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
   Write(await Html.PartialAsync("/Areas/Writer/Views/Default/NavBarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n        <!-- partial -->\n        <div class=\"container-fluid page-body-wrapper\">\n            <!-- partial:~/skydash/partials/_sidebar.html -->\n            ");
#nullable restore
#line 13 "C:\Users\bedir\source\repos\PORTFOLIOPROJECT\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
       Write(await Html.PartialAsync("/Areas/Writer/Views/Default/_SideBarPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n            <!-- partial -->\n            <div class=\"main-panel\">\n                <div class=\"content-wrapper\">\n                        ");
#nullable restore
#line 18 "C:\Users\bedir\source\repos\PORTFOLIOPROJECT\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n                <!-- content-wrapper ends -->\n                <!-- partial:~/skydash/partials/_footer.html -->\n                ");
#nullable restore
#line 22 "C:\Users\bedir\source\repos\PORTFOLIOPROJECT\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
           Write(await Html.PartialAsync("/Areas/Writer/Views/Default/FooterPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                <!-- partial -->\n            </div>\n            <!-- main-panel ends -->\n        </div>\n        <!-- page-body-wrapper ends -->\n    </div>\n    ");
#nullable restore
#line 30 "C:\Users\bedir\source\repos\PORTFOLIOPROJECT\Core_Proje\Core_Proje\Views\Shared\_WriterLayout.cshtml"
Write(await Html.PartialAsync("/Areas/Writer/Views/Default/ScriptPartial.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n");
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
