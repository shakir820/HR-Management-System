#pragma checksum "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Attendence\AttandenceReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbd9f65635c293b9922585215b6a4e8dc599dd16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Attendence_AttandenceReport), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Attendence/AttandenceReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Attendence/AttandenceReport.cshtml", typeof(AspNetCore.Pages_AdminPages_Attendence_AttandenceReport), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbd9f65635c293b9922585215b6a4e8dc599dd16", @"/Pages/AdminPages/Attendence/AttandenceReport.cshtml")]
    public class Pages_AdminPages_Attendence_AttandenceReport : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Attendence\AttandenceReport.cshtml"
  
    ViewData["Title"] = "AttandenceReport";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(177, 47, true);
            WriteLiteral("\r\n<center><h1>Attendence Report</h1></center>\r\n");
            EndContext();
            BeginContext(224, 9648, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbd9f65635c293b9922585215b6a4e8dc599dd163248", async() => {
                BeginContext(230, 9635, true);
                WriteLiteral(@"

    <div class=""col-sm-12"">
        <div class=""wrap-fpanel"">
            <div class=""panel panel-default"" data-collapsed=""0"">
                <div class=""panel-heading"">

                </div>

                <div class=""panel-body"">
                    <form id=""attendance-form"" role=""form"" enctype=""multipart/form-data"" action=""http://localhost/HRMS-FRESH/admin/attendance/get_report"" method=""post"" class=""form-horizontal form-groups-bordered"" novalidate=""novalidate"">
                        <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-3 control-label"">Department Name<span class=""required"" aria-required=""true"">*</span></label>

                            <div class=""col-sm-5"">
                                <select name=""department_id"" class=""form-control"">
                                    <option value="""">Select Department...</option>
                                    <option value=""1"" selected="""">
                                       ");
                WriteLiteral(@" sells
                                    </option>
                                    <option value=""2"">
                                        Marketing
                                    </option>

                                </select>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-3 control-label"">Month &amp; Year <span class=""required"" aria-required=""true"">*</span></label>
                            <div class=""input-group col-sm-5"">
                                <input type=""month"" class=""form-control monthyear"" value=""2019-7"" name=""date"">
                                <div class=""input-group-addon"">
                                    <a href=""#""><i class=""entypo-calendar""></i></a>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
         ");
                WriteLiteral(@"                   <div class=""col-sm-offset-3 col-sm-5 pull-right"">
                                <button type=""submit"" id=""sbtn"" class=""btn btn-primary"">Search</button>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    </div>
    <div id=""EmpprintReport"">

        <br>
        <br>
        <div class=""std_heading"" hidden="""" style=""background-color: rgb(224, 224, 224);margin-bottom: 5px;padding: 5px;"">
            <table style=""margin: 3px 10px 0px 24px; width:100%;"">
                <tbody>
                    <tr>

                        <td style=""font-size: 15px""><strong>Department: </strong>sells</td>
                        <td style=""font-size: 15px""><strong>Date:</strong>July-2019</td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class=""row"">
            <div class=""col-sm-12 std_print"">
               ");
                WriteLiteral(@" <div class=""wrap-fpanel"">
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"" style=""margin-left:50px"">
                            <h4 class=""panel-title"">
                                <strong>Attendance List </strong>
                                <div class=""pull-right hidden-print"" style=""margin-left:950px"">
                                    <a href=""http://localhost/HRMS-FRESH/"" class=""btn btn-primary btn-xs"" title="""" data-toggle=""tooltip"" data-placement=""top"" onclick=""printDiv("" printablearea"")""="""" data-original-title=""Print"">Print</a>
                                </div>
                            </h4>
                        </div>
                        <table id="""" class=""table table-bordered"" style=""margin-right:60px"">

                            <thead style=""font-size:55%"">
                                <tr>
                                    <th style=""width: 100%"" class=""col-sm-1"">Name</th>


                ");
                WriteLiteral(@"                    <th class=""std_p"">1</th>

                                    <th class=""std_p"">2</th>

                                    <th class=""std_p"">3</th>

                                    <th class=""std_p"">4</th>

                                    <th class=""std_p"">5</th>

                                    <th class=""std_p"">6</th>

                                    <th class=""std_p"">7</th>

                                    <th class=""std_p"">8</th>

                                    <th class=""std_p"">9</th>

                                    <th class=""std_p"">10</th>

                                    <th class=""std_p"">11</th>

                                    <th class=""std_p"">12</th>

                                    <th class=""std_p"">13</th>

                                    <th class=""std_p"">14</th>

                                    <th class=""std_p"">15</th>

                                    <th class=""std_p"">16</th>

         ");
                WriteLiteral(@"                           <th class=""std_p"">17</th>

                                    <th class=""std_p"">18</th>

                                    <th class=""std_p"">19</th>

                                    <th class=""std_p"">20</th>

                                    <th class=""std_p"">21</th>

                                    <th class=""std_p"">22</th>

                                    <th class=""std_p"">23</th>

                                    <th class=""std_p"">24</th>

                                    <th class=""std_p"">25</th>

                                    <th class=""std_p"">26</th>

                                    <th class=""std_p"">27</th>

                                    <th class=""std_p"">28</th>

                                    <th class=""std_p"">29</th>

                                    <th class=""std_p"">30</th>

                                    <th class=""std_p"">31</th>


                                </tr>

               ");
                WriteLiteral(@"             </thead>

                            <tbody style=""font-size:65%"">

                                <tr>

                                    <td style=""width: 100%"" class=""col-sm-3"">Al Amin</td>
                                    <td></td>



                                    <td></td>



                                    <td></td>



                                    <td></td>



                                    <td>
                                        <span class=""label label-info std_p"">H</span>
                                    </td>



                                    <td>
                                        <span class=""label label-info std_p"">H</span>
                                    </td>



                                    <td></td>



                                    <td></td>



                                    <td></td>



                                    <td></td>



                           ");
                WriteLiteral(@"         <td></td>



                                    <td>
                                        <span class=""label label-info std_p"">H</span>
                                    </td>



                                    <td>
                                        <span class=""label label-info std_p"">H</span>
                                    </td>



                                    <td></td>



                                    <td></td>



                                    <td></td>



                                    <td></td>



                                    <td></td>



                                    <td>
                                        <span class=""label label-info std_p"">H</span>
                                    </td>



                                    <td>
                                        <span class=""label label-info std_p"">H</span>
                                    </td>



                     ");
                WriteLiteral(@"               <td></td>



                                    <td></td>



                                    <td></td>



                                    <td></td>



                                    <td></td>



                                    <td>
                                        <span class=""label label-info std_p"">H</span>
                                    </td>



                                    <td>
                                        <span class=""label label-info std_p"">H</span>
                                    </td>



                                    <td></td>



                                    <td></td>



                                    <td></td>



                                    <td></td>




                                </tr>

                            </tbody>
                        </table>

                    </div>
                </div>
            </div>
        </div>
    </d");
                WriteLiteral(@"iv>

    <script type=""text/javascript"">
        function printEmp_report(EmpprintReport) {
            var printContents = document.getElementById(EmpprintReport).innerHTML;
            var originalContents = document.body.innerHTML;
            document.body.innerHTML = printContents;
            window.print();
            document.body.innerHTML = originalContents;
        }
    </script>
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
            BeginContext(9872, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.AttandenceReportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AttandenceReportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AttandenceReportModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.AttandenceReportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
