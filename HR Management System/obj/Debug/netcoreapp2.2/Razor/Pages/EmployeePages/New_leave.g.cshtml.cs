#pragma checksum "E:\Github\HR-Management-System\HR Management System\Pages\EmployeePages\New_leave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e80201138586efdb866990c1e493be1a100a837f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_EmployeePages_New_leave), @"mvc.1.0.razor-page", @"/Pages/EmployeePages/New_leave.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmployeePages/New_leave.cshtml", typeof(AspNetCore.Pages_EmployeePages_New_leave), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e80201138586efdb866990c1e493be1a100a837f", @"/Pages/EmployeePages/New_leave.cshtml")]
    public class Pages_EmployeePages_New_leave : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Github\HR-Management-System\HR Management System\Pages\EmployeePages\New_leave.cshtml"
  
    ViewData["Title"] = "New_leave";
    Layout = "~/Views/Shared/_EmployeeLayout.cshtml";

#line default
#line hidden
            BeginContext(171, 2132, true);
            WriteLiteral(@"

<center><h1>New Leave Application</h1></center>
<div class=""panel_controls"">
    <div class=""form-group"">
        <label for=""field-1"" class=""col-sm-3 control-label"">Leave Category<span class=""required"" aria-required=""true""> *</span></label>

        <div class=""col-sm-5"">
            <select name=""leave_category_id"" class=""form-control"" required="""" aria-required=""true"">
                <option value="""">Select Leave Category</option>

            </select>
        </div>
    </div>

    <div class=""form-group"">
        <label class=""col-sm-3 control-label"">Start Date <span class=""required"" aria-required=""true""> *</span></label>

        <div class=""col-sm-5"">
            <div class=""input-group"">
                <input type=""text"" name=""leave_start_date"" required="""" class=""form-control datepicker"" value="""" data-format=""dd-mm-yyyy"" aria-required=""true"">
                <div class=""input-group-addon"">
                    <a href=""#""><i class=""entypo-calendar""></i></a>
                </");
            WriteLiteral(@"div>
            </div>
        </div>
    </div>
    <div class=""form-group"">
        <label class=""col-sm-3 control-label"">End Date <span class=""required"" aria-required=""true""> *</span></label>

        <div class=""col-sm-5"">
            <div class=""input-group"">
                <input type=""text"" name=""leave_end_date"" required="""" class=""form-control datepicker"" value="""" data-format=""dd-mm-yyyy"" aria-required=""true"">
                <div class=""input-group-addon"">
                    <a href=""#""><i class=""entypo-calendar""></i></a>
                </div>
            </div>
        </div>
    </div>

    <div class=""form-group"">
        <label for=""field-1"" class=""col-sm-3 control-label"">Reason</label>

        <div class=""col-sm-5"">
            <textarea id=""present"" name=""reason"" class=""form-control"" rows=""6""></textarea>
        </div>
    </div>


    <div class=""form-group"">
        <div class=""col-sm-offset-3 col-sm-5"">
            <button type=""submit"" id=""sbtn"" name=""sbtn"" v");
            WriteLiteral("alue=\"1\" class=\"btn btn-primary\">Submit</button>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.EmployeePages.New_leaveModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.EmployeePages.New_leaveModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.EmployeePages.New_leaveModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.EmployeePages.New_leaveModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
