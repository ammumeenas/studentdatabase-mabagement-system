#pragma checksum "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Details\StudentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bc09d1dbd44bf76656d582f402d0cef5dcbac88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details_StudentDetails), @"mvc.1.0.view", @"/Views/Details/StudentDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\_ViewImports.cshtml"
using Studentdatabase_management_system;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\_ViewImports.cshtml"
using Studentdatabase_management_system.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bc09d1dbd44bf76656d582f402d0cef5dcbac88", @"/Views/Details/StudentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c40595f6c62ca92f2dae337dc645f94d2d0c27", @"/Views/_ViewImports.cshtml")]
    public class Views_Details_StudentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Details\StudentDetails.cshtml"
 if (ViewBag.Students.Count == 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No Students added</p>\r\n");
#nullable restore
#line 6 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Details\StudentDetails.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class="" table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"" width=""10%"">
                    Students Name

                </th>
               
            </tr>
        </thead>


        <tbody>


");
#nullable restore
#line 24 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Details\StudentDetails.cshtml"
             foreach (Student student in ViewBag.Students)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bc09d1dbd44bf76656d582f402d0cef5dcbac885420", async() => {
#nullable restore
#line 27 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Details\StudentDetails.cshtml"
                                                                                                    Write(student.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Details\StudentDetails.cshtml"
                                                                                WriteLiteral(student.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                   \r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Details\StudentDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n");
#nullable restore
#line 36 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Details\StudentDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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