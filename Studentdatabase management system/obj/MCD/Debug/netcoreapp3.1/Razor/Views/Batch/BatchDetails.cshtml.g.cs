#pragma checksum "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Batch\BatchDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc0fedb9177f9d52d209a74ea0477ba778c8f026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Batch_BatchDetails), @"mvc.1.0.view", @"/Views/Batch/BatchDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc0fedb9177f9d52d209a74ea0477ba778c8f026", @"/Views/Batch/BatchDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c40595f6c62ca92f2dae337dc645f94d2d0c27", @"/Views/_ViewImports.cshtml")]
    public class Views_Batch_BatchDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Studentdatabase_management_system.ViewModels.AddBatchDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Batch\BatchDetails.cshtml"
Write(Model.BatchName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Batch Id</th>\r\n        <td>");
#nullable restore
#line 8 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Batch\BatchDetails.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Batch Name</th>\r\n        <td>");
#nullable restore
#line 12 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Batch\BatchDetails.cshtml"
       Write(Model.BatchName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n  \r\n    <tr>\r\n        <th>Class Schedule</th>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Batch\BatchDetails.cshtml"
       Write(Model.ClassSchedule);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <th>Announcement</th>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Batch\BatchDetails.cshtml"
       Write(Model.Announcements);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Studentdatabase_management_system.ViewModels.AddBatchDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
