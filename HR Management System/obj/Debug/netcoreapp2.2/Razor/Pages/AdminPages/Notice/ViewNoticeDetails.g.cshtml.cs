#pragma checksum "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b7ebdef8d46e703fc984c64fc58964f91424880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Notice_ViewNoticeDetails), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Notice/ViewNoticeDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Notice/ViewNoticeDetails.cshtml", typeof(AspNetCore.Pages_AdminPages_Notice_ViewNoticeDetails), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b7ebdef8d46e703fc984c64fc58964f91424880", @"/Pages/AdminPages/Notice/ViewNoticeDetails.cshtml")]
    public class Pages_AdminPages_Notice_ViewNoticeDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml"
  
    ViewData["Title"] = "ViewNoticeDetails";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(251, 652, true);
            WriteLiteral(@"


<div class=""col-md-12"">

    <div class=""panel panel-info"">
        <!-- Default panel contents -->

        <div class=""panel-heading"">
            <div class=""panel-title"">
                <strong>Notice Details</strong>
            </div>
        </div>
        <div>

        </div>
        <div class=""panel-body form-horizontal"">
            <div class=""col-md-12 notice-details-margin"">
                <div class=""col-sm-4"">
                    <label class=""control-label""><strong>Title:</strong></label>
                </div>
                <div class=""col-sm-8"">
                    <p class=""form-control-static"">");
            EndContext();
            BeginContext(904, 18, false);
#line 30 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml"
                                              Write(Model.Notice.Title);

#line default
#line hidden
            EndContext();
            BeginContext(922, 390, true);
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""col-md-12 notice-details-margin"">
                <div class=""col-sm-4"" style=""margin-top: 8px;"">
                    <label class=""control-label""><strong>Description:</strong></label>
                </div>
                <div class=""col-sm-8"">
                    <p class=""form-control-static text-justify"">");
            EndContext();
            BeginContext(1313, 24, false);
#line 38 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml"
                                                           Write(Model.Notice.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1337, 381, true);
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""col-md-12 notice-details-margin"">
                <div class=""col-sm-4"">
                    <label class=""control-label""><strong>Published Date:</strong></label>
                </div>
                <div class=""col-sm-8"">
                    <p class=""form-control-static""><span class=""text-danger"">");
            EndContext();
            BeginContext(1719, 44, false);
#line 46 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml"
                                                                        Write(Model.Notice.CreatedDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1763, 272, true);
            WriteLiteral(@"</span></p>
                </div>
            </div>
        </div>
    </div>
</div>
<td class="" ""><a href='javascript:history.go(-1)' class=""btn btn-info btn-xs"" data-toggle=""tooltip"" data-placement=""top"" title="""" data-original-title=""View"">Go Back</a></td>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.AdminPages.Notice.ViewNoticeDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.Notice.ViewNoticeDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.Notice.ViewNoticeDetailsModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.AdminPages.Notice.ViewNoticeDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
