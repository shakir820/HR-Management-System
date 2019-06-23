#pragma checksum "D:\GitHub\ASPNETCORE\HR Management System\HR-Management-System\HR Management System\Pages\LoginPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be897b708f9cb960c467fe9be173df7277a46cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_LoginPage), @"mvc.1.0.razor-page", @"/Pages/LoginPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/LoginPage.cshtml", typeof(AspNetCore.Pages_LoginPage), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be897b708f9cb960c467fe9be173df7277a46cd", @"/Pages/LoginPage.cshtml")]
    public class Pages_LoginPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\GitHub\ASPNETCORE\HR Management System\HR-Management-System\HR Management System\Pages\LoginPage.cshtml"
  
    ViewData["Title"] = "LoginPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 1117, true);
            WriteLiteral(@"
<h1>LoginPage</h1>

<div class=""row"">
    <div class=""col-md-4"">
        <section>
            <form id=""account"" method=""post"">
                <h4>Use a local account to log in.</h4>
                <hr />
                <div asp-validation-summary=""All"" class=""text-danger""></div>
                <div class=""form-group"">
                    <label asp-for=""User.UserName""></label>
                    <input asp-for=""User.UserName"" class=""form-control"" />
                    <span asp-validation-for=""User.Email"" class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <label asp-for=""User.Password""></label>
                    <input asp-for=""User.Password"" class=""form-control"" />
                    <span asp-validation-for=""User.Password"" class=""text-danger""></span>
                </div>
                <div class=""form-group"">
                    <div class=""checkbox"">
                        <label asp-for=""User.RememberMe"">
");
            WriteLiteral("                            <input asp-for=\"User.RememberMe\" />\r\n                            ");
            EndContext();
            BeginContext(1267, 43, false);
#line 31 "D:\GitHub\ASPNETCORE\HR Management System\HR-Management-System\HR Management System\Pages\LoginPage.cshtml"
                       Write(Html.DisplayNameFor(m => m.User.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 237, true);
            WriteLiteral("\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Log in</button>\r\n                </div>\r\n");
            EndContext();
            BeginContext(1938, 97, true);
            WriteLiteral("            </form>\r\n        </section>\r\n    </div>\r\n    <div class=\"col-md-6 col-md-offset-2\">\r\n");
            EndContext();
            BeginContext(3419, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3459, 52, true);
                WriteLiteral("\r\n    <partial name=\"_ValidationScriptsPartial\" />\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.LoginPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.LoginPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.LoginPageModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.LoginPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591