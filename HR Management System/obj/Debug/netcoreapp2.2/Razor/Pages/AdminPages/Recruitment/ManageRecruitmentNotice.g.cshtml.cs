#pragma checksum "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310f65de1ddf5e3fdbf4a0f8cf9375f042816f00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Recruitment_ManageRecruitmentNotice), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Recruitment/ManageRecruitmentNotice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Recruitment/ManageRecruitmentNotice.cshtml", typeof(AspNetCore.Pages_AdminPages_Recruitment_ManageRecruitmentNotice), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310f65de1ddf5e3fdbf4a0f8cf9375f042816f00", @"/Pages/AdminPages/Recruitment/ManageRecruitmentNotice.cshtml")]
    public class Pages_AdminPages_Recruitment_ManageRecruitmentNotice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
  
    ViewData["Title"] = "ManageRecruitmentNotice";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(191, 57, true);
            WriteLiteral("<center><h1>Manage Recruitment Notice</h1></center>\r\n\r\n\r\n");
            EndContext();
            BeginContext(248, 4661, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "310f65de1ddf5e3fdbf4a0f8cf9375f042816f003317", async() => {
                BeginContext(254, 4648, true);
                WriteLiteral(@"
    <div class=""container-fluid"">


        <div class=""wrap-fpanel"">

            <div class=""row"">
                <div class=""col-sm-12"" data-offset=""0"">
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <div class=""panel-title"">
                                <strong>List of All Recruitment Notice</strong>
                            </div>
                        </div>
                        <!-- Table -->

                        <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                            <div class=""row""><div class=""col-sm-6""><div class=""dataTables_length"" id=""dataTables-example_length""><label><select name=""dataTables-example_length"" aria-controls=""dataTables-example"" class=""form-control input-sm""><option value=""10"">10</option><option value=""25"">25</option><option value=""50"">50</option><option value=""100"">100</option></select> <b>Records per p");
                WriteLiteral(@"age</b></label></div></div><div class=""col-sm-6""><div id=""dataTables-example_filter"" class=""dataTables_filter""><label>Search:<input type=""search"" style=""margin:0px 10px;"" class=""form-control input-sm"" aria-controls=""dataTables-example""></label></div></div></div><table class=""table table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                                <thead>
                                    <tr role=""row"">
                                        <th class=""sorting_asc"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""SL: activate to sort column ascending"" style=""width: 62px;"">SL</th>
                                        <th class=""col-sm-1 sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Created Date: activate to sort column ascending"" style=""width: 73px;"">Created Date</th>
                                        <th class=");
                WriteLiteral(@"""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Title: activate to sort column ascending"" style=""width: 84px;"">Title</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Title: activate to sort column ascending"" style=""width: 84px;"">Designation</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Title: activate to sort column ascending"" style=""width: 84px;"">No. of Vacancy</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Title: activate to sort column ascending"" style=""width: 84px;"">Last Date</th>
                                        <th class=""col-sm-5 sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Short Description: activat");
                WriteLiteral(@"e to sort column ascending"" style=""width: 438px;"">Description</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Status: activate to sort column ascending"" style=""width: 167px;"">Status</th>
                                        <th class=""col-sm-2 sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Action: activate to sort column ascending"" style=""width: 164px;"">Action</th>
                                    </tr>
                                </thead>
                                <tbody></tbody>
                            </table><div class=""row""><div class=""col-sm-6""><div class=""dataTables_info"" id=""dataTables-example_info"" role=""alert"" aria-live=""polite"" aria-relevant=""all"">Showing 1 to 1 of 1 entries</div></div><div class=""col-sm-6""><div class=""dataTables_paginate paging_simple_numbers"" id=""dataTables-example_paginate""><ul class=""pagination""><li class=""p");
                WriteLiteral(@"aginate_button previous disabled"" aria-controls=""dataTables-example"" tabindex=""0"" id=""dataTables-example_previous""><a href=""#"">Previous</a></li><li class=""paginate_button active"" aria-controls=""dataTables-example"" tabindex=""0""><a href=""#"">1</a></li><li class=""paginate_button next disabled"" aria-controls=""dataTables-example"" tabindex=""0"" id=""dataTables-example_next""><a href=""#"">Next</a></li></ul></div></div></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
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
            BeginContext(4909, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.ManageRecruitmentNoticeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageRecruitmentNoticeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageRecruitmentNoticeModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.ManageRecruitmentNoticeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
