#pragma checksum "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e74926bea8ad1a1f38fa347b0b27fc4169aea2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e74926bea8ad1a1f38fa347b0b27fc4169aea2", @"/Pages/AdminPages/Notice/ViewNoticeDetails.cshtml")]
    public class Pages_AdminPages_Notice_ViewNoticeDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::HR_Management_System.TagHelpers.RichDescriptionTagHelper __HR_Management_System_TagHelpers_RichDescriptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml"
  
    ViewData["Title"] = "ViewNoticeDetails";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(290, 648, true);
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
            BeginContext(939, 18, false);
#line 29 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml"
                                              Write(Model.Notice.Title);

#line default
#line hidden
            EndContext();
            BeginContext(957, 346, true);
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""col-md-12 notice-details-margin"">
                <div class=""col-sm-4"" style=""margin-top: 8px;"">
                    <label class=""control-label""><strong>Description:</strong></label>
                </div>
                <div class=""col-sm-8"">
                    ");
            EndContext();
            BeginContext(1303, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("rich-description", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99e74926bea8ad1a1f38fa347b0b27fc4169aea24577", async() => {
            }
            );
            __HR_Management_System_TagHelpers_RichDescriptionTagHelper = CreateTagHelper<global::HR_Management_System.TagHelpers.RichDescriptionTagHelper>();
            __tagHelperExecutionContext.Add(__HR_Management_System_TagHelpers_RichDescriptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 37 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml"
                                       WriteLiteral(Model.Notice.Description);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __HR_Management_System_TagHelpers_RichDescriptionTagHelper.Description = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("description", __HR_Management_System_TagHelpers_RichDescriptionTagHelper.Description, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1380, 394, true);
            WriteLiteral(@"

                </div>
             
            </div>
            <div class=""col-md-12 notice-details-margin"">
                <div class=""col-sm-4"">
                    <label class=""control-label""><strong>Published Date:</strong></label>
                </div>
                <div class=""col-sm-8"">
                    <p class=""form-control-static""><span class=""text-danger"">");
            EndContext();
            BeginContext(1775, 44, false);
#line 47 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Notice\ViewNoticeDetails.cshtml"
                                                                        Write(Model.Notice.CreatedDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1819, 272, true);
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
