#pragma checksum "D:\GitHub\ASPNETCORE\HR Management System\HR-Management-System\HR Management System\Pages\CareerPages\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8970a360943604d21c23dd7a735215b5fee7884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_CareerPages_Profile), @"mvc.1.0.razor-page", @"/Pages/CareerPages/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CareerPages/Profile.cshtml", typeof(AspNetCore.Pages_CareerPages_Profile), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8970a360943604d21c23dd7a735215b5fee7884", @"/Pages/CareerPages/Profile.cshtml")]
    public class Pages_CareerPages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\GitHub\ASPNETCORE\HR Management System\HR-Management-System\HR Management System\Pages\CareerPages\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_CareerLayout.cshtml";

#line default
#line hidden
            BeginContext(163, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(167, 10568, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8970a360943604d21c23dd7a735215b5fee78843086", async() => {
                BeginContext(173, 10555, true);
                WriteLiteral(@"
    <script language=""javascript"" type=""text/javascript"">
        function getXMLHTTP() { //fuction to return the xml http object
            var xmlhttp = false;
            try {
                xmlhttp = new XMLHttpRequest();
            }
            catch (e) {
                try {
                    xmlhttp = new ActiveXObject(""Microsoft.XMLHTTP"");
                }
                catch (e) {
                    try {
                        xmlhttp = new ActiveXObject(""Msxml2.XMLHTTP"");
                    }
                    catch (e1) {
                        xmlhttp = false;
                    }
                }
            }

            return xmlhttp;
        }

        function check_duplicate_emp_id(val) {
            var base_url = 'http://localhost/HRMS-FRESH/';
            var strURL = base_url + ""admin/global_controller/check_duplicate_emp_id/"" + val;
            var req = getXMLHTTP();
            if (req) {
                req.onreadystatechange = fun");
                WriteLiteral(@"ction () {
                    if (req.readyState == 4) {
                        // only if ""OK""
                        if (req.status == 200) {
                            var result = req.responseText;
                            if (result) {
                                $(""#id_error_msg"").append(result);
                                document.getElementById('btn_emp').disabled = true;
                            } else {
                                document.getElementById('btn_emp').disabled = false;
                            }

                        } else {
                            alert(""There was a problem while using XMLHTTP:\n"" + req.statusText);
                        }
                    }
                }
                req.open(""POST"", strURL, true);
                req.send(null);
            }

        }
        ;
        function get_employee_by_designations_id(designation_id) {
            var base_url = 'http://localhost/HRMS-FRESH/';
         ");
                WriteLiteral(@"   var strURL = base_url + ""admin/global_controller/get_employee_by_designations_id/"" + designation_id;
            var req = getXMLHTTP();
            if (req) {
                req.onreadystatechange = function () {
                    if (req.readyState == 4) {
                        // only if ""OK""
                        if (req.status == 200) {
                            var result = req.responseText;

                            $(""#employee"").html(""<option value='' >Select Employee...</option>"");
                            $(""#employee"").append(result);

                        } else {
                            alert(""There was a problem while using XMLHTTP:\n"" + req.statusText);
                        }
                    }
                }
                req.open(""POST"", strURL, true);
                req.send(null);
            }

        }
        ;
        function check_current_password(val) {
            var base_url = 'http://localhost/HRMS-FRESH/';
         ");
                WriteLiteral(@"   var strURL = base_url + ""admin/global_controller/check_current_password/"" + val;
            var req = getXMLHTTP();
            if (req) {
                req.onreadystatechange = function () {
                    if (req.readyState == 4) {
                        // only if ""OK""
                        if (req.status == 200) {
                            var result = req.responseText;
                            if (result) {
                                $(""#id_error_msg"").css(""display"", ""block"");
                                document.getElementById('sbtn').disabled = true;
                            } else {
                                $(""#id_error_msg"").css(""display"", ""none"");
                                document.getElementById('sbtn').disabled = false;
                            }

                        } else {
                            alert(""There was a problem while using XMLHTTP:\n"" + req.statusText);
                        }
                    }
        ");
                WriteLiteral(@"        }
                req.open(""POST"", strURL, true);
                req.send(null);
            }

        }
        function check_employee_password(val) {

            var base_url = 'http://localhost/HRMS-FRESH/';
            var strURL = base_url + ""employee/dashboard/check_employee_password/"" + val;

            var req = getXMLHTTP();
            if (req) {
                req.onreadystatechange = function () {
                    if (req.readyState == 4) {
                        // only if ""OK""
                        if (req.status == 200) {
                            var result = req.responseText;
                            if (result) {
                                $(""#id_error_msg"").css(""display"", ""block"");
                                document.getElementById('sbtn').disabled = true;
                            } else {
                                $(""#id_error_msg"").css(""display"", ""none"");
                                document.getElementById('sbtn').disa");
                WriteLiteral(@"bled = false;
                            }

                        } else {
                            alert(""There was a problem while using XMLHTTP:\n"" + req.statusText);
                        }
                    }
                }
                req.open(""POST"", strURL, true);
                req.send(null);
            }

        }
        ;



/**/</script>

    <div class=""container-fluid"">

        <form role=""form"" id=""update_profile"" action=""http://localhost/HRMS-FRESH/admin/settings/profile_updated"" method=""post"" class=""form-horizontal form-groups-bordered"" novalidate=""novalidate"">
            <div class=""col-sm-12 wrap-fpanel"">
                <div class=""panel panel-default"" data-collapsed=""0"">
                    <div class=""panel-heading"">
                        <div class=""panel-title"">
                            <strong>Update Profile</strong>
                        </div>
                    </div>
                    <div class=""panel-body"">

      ");
                WriteLiteral(@"                  <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-4 control-label"">First Name <span class=""required"" aria-required=""true""> *</span></label>
                            <div class=""col-sm-7"">
                                <input type=""text"" name=""first_name"" value=""Al"" class=""form-control"" placeholder=""Enter Your First Name"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-4 control-label"">Last Name <span class=""required"" aria-required=""true""> *</span></label>
                            <div class=""col-sm-7"">
                                <input type=""text"" name=""last_name"" value=""Amin"" class=""form-control"" placeholder=""Enter Your Last Name"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""field-1"" class=");
                WriteLiteral(@"""col-sm-4 control-label"">User Name <span class=""required"" aria-required=""true""> *</span></label>
                            <div class=""col-sm-7"">
                                <input type=""text"" name=""user_name"" value=""admin"" class=""form-control"" placeholder=""Enter Your User Name"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-4 col-sm-5"">
                                <button type=""submit"" class=""btn btn-primary"">Update</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
        <form role=""form"" id=""change_password"" action=""http://localhost/HRMS-FRESH/admin/settings/set_password"" method=""post"" class=""form-horizontal form-groups-bordered"" novalidate=""novalidate"">
            <div class=""col-sm-12 wrap-fpanel"">
                <div class=""panel panel-default"" d");
                WriteLiteral(@"ata-collapsed=""0"">
                    <div class=""panel-heading"">
                        <div class=""panel-title"">
                            <strong>Change Password</strong>
                        </div>
                    </div>
                    <div class=""panel-body"">

                        <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-4 control-label"">Old Password <span class=""required"" aria-required=""true""> *</span></label>
                            <div class=""col-sm-7"">
                                <input type=""password"" name=""old_password"" value="""" class=""form-control"" placeholder=""Enter Your Old Password"" onchange=""check_current_password(this.value)"">
                                <span id=""id_error_msg""><small style=""padding-left:10px;color:red;font-size:10px"">Your Entered Password Do Not Match !</small></span>
                            </div>
                        </div>
                        <div class=""form-group"">
");
                WriteLiteral(@"                            <label for=""field-1"" class=""col-sm-4 control-label"">New Password <span class=""required"" aria-required=""true""> *</span></label>
                            <div class=""col-sm-7"">
                                <input type=""password"" name=""new_password"" id=""new_password"" value="""" class=""form-control"" placeholder=""Enter Your New Password"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-4 control-label"">Confirm Password <span class=""required"" aria-required=""true""> *</span></label>
                            <div class=""col-sm-7"">
                                <input type=""password"" name=""confirm_password"" value="""" class=""form-control"" placeholder=""Enter Your Retype Password"">
                            </div>
                        </div>

                        <div class=""form-group"">
                            <div class=""col-sm-offs");
                WriteLiteral(@"et-4 col-sm-5"">
                                <button type=""submit"" id=""sbtn"" class=""btn btn-primary"">Update</button>
                            </div>
                        </div>
                    </div>
                </div>
                <br>
            </div>
        </form>
    </div>

");
                EndContext();
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
            EndContext();
            BeginContext(10735, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.CareerPages.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.CareerPages.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.CareerPages.ProfileModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.CareerPages.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
