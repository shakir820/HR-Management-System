#pragma checksum "D:\GitHub\ASPNETCORE\HR Management System\HR-Management-System\HR Management System\Pages\AdminPages\LeaveApplication\Leave_Application_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be9dc4a31711f191352b1b5e5903e342503dd6c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_LeaveApplication_Leave_Application_Details), @"mvc.1.0.razor-page", @"/Pages/AdminPages/LeaveApplication/Leave_Application_Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/LeaveApplication/Leave_Application_Details.cshtml", typeof(AspNetCore.Pages_AdminPages_LeaveApplication_Leave_Application_Details), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be9dc4a31711f191352b1b5e5903e342503dd6c5", @"/Pages/AdminPages/LeaveApplication/Leave_Application_Details.cshtml")]
    public class Pages_AdminPages_LeaveApplication_Leave_Application_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\GitHub\ASPNETCORE\HR Management System\HR-Management-System\HR Management System\Pages\AdminPages\LeaveApplication\Leave_Application_Details.cshtml"
  
    ViewData["Title"] = "Leave_Application_Details";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(223, 3115, true);
            WriteLiteral(@"
<h1>Leave_Application_Details</h1>

<div class=""container-fluid"">
    <div class=""col-md-12"">
        <div class=""wrap-fpanel"">
            <div class=""panel panel-default"">
                <!-- Default panel contents -->


                <form method=""post"" action=""#"" <div ="""" class=""panel-body form-horizontal"">
    <div class=""col-md-12"">
        <div class=""col-sm-4 "">
            <label class=""control-label""><strong>Name : </strong></label>
        </div>
        <div class=""col-sm-8"">
            <p class=""form-control-static"">Ovijit Roy</p>
        </div>
    </div>
    <div class=""col-md-12"">
        <div class=""col-sm-4 "">
            <label class=""control-label""><strong>Leave Date : </strong></label>
        </div>
        <div class=""col-sm-8"">
            <p class=""form-control-static text-justify"">18 Jun 19</p>
        </div>
    </div>
    <div class=""col-md-12"">
        <div class=""col-sm-4 "">
            <label class=""control-label""><strong>Days </strong></label>");
            WriteLiteral(@"
        </div>
        <div class=""col-sm-8"">
            <p class=""form-control-static text-justify"">1</p>
        </div>
    </div>
    <div class=""col-md-12"">
        <div class=""col-sm-4 "">
            <label class=""control-label""><strong>Leave Type :</strong></label>
        </div>
        <div class=""col-sm-8"">
            <p class=""form-control-static text-justify"">sick</p>
        </div>
    </div>
    <div class=""col-md-12"">
        <div class=""col-sm-4 "">
            <label class=""control-label""><strong>Apply On : </strong></label>
        </div>
        <div class=""col-sm-8"">
            <p class=""form-control-static""><span class=""text-danger"">18 Jun 19</span></p>
        </div>
    </div>
    <div class=""col-md-12"">
        <div class=""col-sm-4 "">
            <label class=""control-label""><strong>Reason : </strong></label>
        </div>
        <div class=""col-sm-8"">
            <p class=""form-control-static""></p>
        </div>
    </div>
    <div class=""col-md-12 ma");
            WriteLiteral(@"rgin"">
        <div class=""col-sm-4 "">
            <label class=""control-label""><strong>Action : </strong></label>
        </div>
        <div class=""col-sm-2"">
            <select class=""form-control"" name=""application_status"">
                <option value=""1""> Pending </option>
                <option value=""2"" selected=""""> Accept </option>
                <option value=""3""> Reject </option>
            </select>
        </div>
    </div>
    <div class=""col-md-12"">
        <div class=""col-sm-4"">
            <!-- Hidden Input ---->
            <input type=""hidden"" name=""employee_id"" value=""3"">
            <input type=""hidden"" name=""leave_category_id"" value=""1"">
            <input type=""hidden"" name=""leave_start_date"" value=""2019-06-18"">
            <input type=""hidden"" name=""leave_end_date"" value=""2019-06-18"">
        </div>
        <div class=""col-sm-4 margin"">
            <button type=""submit"" class=""btn btn-primary"">Update</button>
        </div>
    </div>

</form>
           ");
            WriteLiteral(" </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.AdminPages.LeaveApplication.Leave_Application_DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.LeaveApplication.Leave_Application_DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.LeaveApplication.Leave_Application_DetailsModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.AdminPages.LeaveApplication.Leave_Application_DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
