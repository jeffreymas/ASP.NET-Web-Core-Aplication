#pragma checksum "C:\Users\Jepri\Documents\Visual Studio 2017\Projects\LearnNetCore\WebClient\Views\Employees\ViewEmp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f61eeaed45d4c433bdf3036c3d552fc040af934"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_ViewEmp), @"mvc.1.0.view", @"/Views/Employees/ViewEmp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/ViewEmp.cshtml", typeof(AspNetCore.Views_Employees_ViewEmp))]
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
#line 1 "C:\Users\Jepri\Documents\Visual Studio 2017\Projects\LearnNetCore\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#line 2 "C:\Users\Jepri\Documents\Visual Studio 2017\Projects\LearnNetCore\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f61eeaed45d4c433bdf3036c3d552fc040af934", @"/Views/Employees/ViewEmp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_ViewEmp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Scripts/Employees.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Jepri\Documents\Visual Studio 2017\Projects\LearnNetCore\WebClient\Views\Employees\ViewEmp.cshtml"
  
    ViewData["Title"] = "ViewEmp";
    Layout = "~/Views/Layout/Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 263, true);
            WriteLiteral(@"
<!-- DataTales Example -->
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <div class=""d-flex flex-row align-content-between justify-content-between"">
            <h5 class=""m-0 font-weight-bold text-primary"">Table Employees</h5>
");
            EndContext();
            BeginContext(703, 2196, true);
            WriteLiteral(@"        </div>
    </div>
    <div class=""card-body"">
        <!-- Modal -->
        <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header no-bd"">
                        <h5 class=""modal-title""><span class=""fw-mediumbold"">Data Employee</span></h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <table class=""table table-bordered table-striped"">
                            <tbody>
                                <tr>
                                    <th width=""30%"">Name</th>
                                    <th>:</th>
                                    <td id=""Name""");
            WriteLiteral(@"> </td>
                                </tr>
                                <tr>
                                    <th>Address</th>
                                    <th width=""10%"">:</th>
                                    <td id=""Address""></td>
                                </tr>
                                <tr>
                                    <th>Phone</th>
                                    <th>:</th>
                                    <td id=""Phone""></td>
                                </tr>
                                <tr>
                                    <th>Hire Date</th>
                                    <th>:</th>
                                    <td id=""HireDate""></td>
                                </tr>
                                <tr>
                                    <th>Hire Time</th>
                                    <th>:</th>
                                    <td id=""HireTime""></td>
                                </tr>
      ");
            WriteLiteral("                      </tbody>\r\n                        </table>\r\n                    </div>\r\n                    <div class=\"modal-footer no-bd\">\r\n");
            EndContext();
            BeginContext(3046, 920, true);
            WriteLiteral(@"                        <button type=""button"" id=""update"" class=""btn btn-outline-danger"" data-dismiss=""modal"" onclick=""Delete();"">Delete</button>
                        <button type=""button"" class=""btn btn-outline-success"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>
        <!-- End Modal -->

        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""Employee"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>No</th>
                        <th>Name</th>
                        <th>Addres</th>
                        <th>Phone</th>
                        <th>JoinDate</th>
                        <th>Action</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3983, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(3991, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9c398a6f806456496f0fd9e11e69a33", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4040, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
