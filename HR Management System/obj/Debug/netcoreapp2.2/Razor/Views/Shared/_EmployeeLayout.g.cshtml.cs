#pragma checksum "E:\Visual studio\HR-Management-System\HR Management System\Views\Shared\_EmployeeLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d28dc715d2f15ab5e16c5023c9cf9adaf609ba4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmployeeLayout), @"mvc.1.0.view", @"/Views/Shared/_EmployeeLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_EmployeeLayout.cshtml", typeof(AspNetCore.Views_Shared__EmployeeLayout))]
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
#line 1 "E:\Visual studio\HR-Management-System\HR Management System\Views\_ViewImports.cshtml"
using HR_Management_System;

#line default
#line hidden
#line 2 "E:\Visual studio\HR-Management-System\HR Management System\Views\_ViewImports.cshtml"
using HR_Management_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d28dc715d2f15ab5e16c5023c9cf9adaf609ba4f", @"/Views/Shared/_EmployeeLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f36475b84fc0d174977afd05ecfa75611a24b0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EmployeeLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-auto w-100 navbar-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CookieConsentPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 548, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d28dc715d2f15ab5e16c5023c9cf9adaf609ba4f5943", async() => {
                BeginContext(33, 535, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />

    <!-- Custom fonts for this template-->
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"" rel=""stylesheet"">

    <!-- Custom styles for this template-->
    <link href=""css/sb-admin-2.min.css"" rel=""stylesheet"">


    <title>PC LINK IT</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(575, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(581, 11103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d28dc715d2f15ab5e16c5023c9cf9adaf609ba4f7683", async() => {
                BeginContext(601, 4042, true);
                WriteLiteral(@"

        <!-- Page Wrapper -->
        <div id=""wrapper"">

            <!-- Sidebar -->
            <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

                <!-- Sidebar - Brand -->
                <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
                    <div class=""sidebar-brand-icon rotate-n-15"">
                        <i class=""fas fa-user""></i>
                    </div>
                </a>

                <!-- Divider -->
                <hr class=""sidebar-divider my-0"">

                <!-- Nav Item - Dashboard -->
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""Emoloyee_Dashboard.html"">
                        <i class=""fas fa-fw fa-tachometer-alt""></i>
                        <span>Dashboard</span>
                    </a>
                </li>

                <!-- Divider -->
                <hr class=""sidebar-divi");
                WriteLiteral(@"der"">

                <!-- Heading -->
                <!-- Nav Item - Pages Collapse Menu -->
                <!-- Nav Item - Charts -->
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""Leave_Application.html"">
                        <i class=""fa fa-rocket""></i>
                        <span>Leave Application</span>
                    </a>
                </li>

                <li class=""nav-item"">
                    <a class=""nav-link"" href=""Employee_Notice.html"">
                        <i class=""fa fa-flag""></i>
                        <span>Employee Notice</span>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""Events.html"">
                        <i class=""fa fa-bell""></i>
                        <span>Events</span>
                    </a>
                </li>

                <li class=""nav-item"">
                    <a class=""nav-link"" href=""Payment_inf");
                WriteLiteral(@"o.html"">
                        <i class=""fa fa-dollar-sign""></i>
                        <span>Payment Info</span>
                    </a>
                </li>

                <!-- Divider -->
                <hr class=""sidebar-divider d-none d-md-block"">

                <!-- Sidebar Toggler (Sidebar) -->
                <div class=""text-center d-none d-md-inline"">
                    <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
                </div>

            </ul>
            <!-- End of Sidebar -->
            <!-- Content Wrapper -->
            <div id=""content-wrapper"" class=""d-flex flex-column"">

                <!-- Main Content -->
                <div id=""content"">

                    <!-- Topbar -->
                    <nav class=""navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow"">

                        <!-- Sidebar Toggle (Topbar) -->
                        <button id=""sidebarToggleTop"" class=""btn btn-link d-md");
                WriteLiteral(@"-none rounded-circle mr-3"">
                            <i class=""fa fa-bars""></i>
                        </button>

                        <!-- Topbar Search -->
                        <!-- Topbar Navbar -->
                        <ul class=""navbar-nav ml-auto"">

                            <!-- Nav Item - Search Dropdown (Visible Only XS) -->
                            <li class=""nav-item dropdown no-arrow d-sm-none"">
                                <a class=""nav-link dropdown-toggle"" href=""#"" id=""searchDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <i class=""fas fa-search fa-fw""></i>
                                </a>
                                <!-- Dropdown - Messages -->
                                <div class=""dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in"" aria-labelledby=""searchDropdown"">
                                    ");
                EndContext();
                BeginContext(4643, 778, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d28dc715d2f15ab5e16c5023c9cf9adaf609ba4f12320", async() => {
                    BeginContext(4697, 717, true);
                    WriteLiteral(@"
                                        <div class=""input-group"">
                                            <input type=""text"" class=""form-control bg-light border-0 small"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"">
                                            <div class=""input-group-append"">
                                                <button class=""btn btn-primary"" type=""button"">
                                                    <i class=""fas fa-search fa-sm""></i>
                                                </button>
                                            </div>
                                        </div>
                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5421, 2324, true);
                WriteLiteral(@"
                                </div>
                            </li>



                            <div class=""topbar-divider d-none d-sm-block""></div>

                            <!-- Nav Item - User Information -->
                            <li class=""nav-item dropdown no-arrow"">
                                <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                    <span class=""mr-2 d-none d-lg-inline text-gray-600 small"">Valerie Luna</span>
                                    <img class=""img-profile rounded-circle"" src=""https://source.unsplash.com/QAB-WJcbgJk/60x60"">
                                </a>
                                <!-- Dropdown - User Information -->
                                <div class=""dropdown-menu dropdown-menu-right shadow animated--grow-in"" aria-labelledby=""userDropdown"">
                                    <a class=""dropdown-");
                WriteLiteral(@"item"" href=""#"">
                                        <i class=""fas fa-user fa-sm fa-fw mr-2 text-gray-400""></i>
                                        Profile
                                    </a>
                                    <div class=""dropdown-divider""></div>
                                    <a class=""dropdown-item"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
                                        <i class=""fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400""></i>
                                        Logout
                                    </a>
                                </div>
                            </li>

                        </ul>

                    </nav>
                    <!-- End of Topbar -->
                    <!-- Begin Page Content -->
                    <div class=""container-fluid"">

                        <!-- Page Heading -->
                        <div class=""d-sm-flex align-items-center justify-content-between mb-4""");
                WriteLiteral(@">
                            <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
                        </div>

                        <!-- Content Row -->
                        <div class=""row"">

                            <!-- Earnings (Monthly) Card Example -->
");
                EndContext();
                BeginContext(8811, 1819, true);
                WriteLiteral(@"

                            <!-- Footer -->
                            <!-- Scroll to Top Button-->
                            <a class=""scroll-to-top rounded"" href=""#page-top"">
                                <i class=""fas fa-angle-up""></i>
                            </a>

                            <!-- Logout Modal-->
                            <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog"" role=""document"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                                            <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">×</span>
     ");
                WriteLiteral(@"                                       </button>
                                        </div>
                                        <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                                        <div class=""modal-footer"">
                                            <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                                            <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""container-fluid"">
                                ");
                EndContext();
                BeginContext(10630, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d28dc715d2f15ab5e16c5023c9cf9adaf609ba4f19160", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(10670, 103, true);
                WriteLiteral("\r\n                                <main role=\"main\" class=\"pb-3\">\r\n                                    ");
                EndContext();
                BeginContext(10774, 12, false);
#line 209 "E:\Visual studio\HR-Management-System\HR Management System\Views\Shared\_EmployeeLayout.cshtml"
                               Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(10786, 332, true);
                WriteLiteral(@"
                                </main>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <footer class=""border-top footer text-muted"">
            <div class=""container"">
                &copy; 2019 PC LINK IT ");
                EndContext();
                BeginContext(11118, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d28dc715d2f15ab5e16c5023c9cf9adaf609ba4f21328", async() => {
                    BeginContext(11176, 7, true);
                    WriteLiteral("Privacy");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11187, 490, true);
                WriteLiteral(@"
            </div>
        </footer>
        <!-- Bootstrap core JavaScript-->
        <script src=""vendor/jquery/jquery.min.js""></script>
        <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

        <!-- Core plugin JavaScript-->
        <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>

        <!-- Custom scripts for all pages-->
        <script src=""js/sb-admin-2.min.js""></script>

        <!-- Page level plugins -->



    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11684, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
