#pragma checksum "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51422e2b361e073495222d730013715220fc2d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51422e2b361e073495222d730013715220fc2d26", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c40595f6c62ca92f2dae337dc645f94d2d0c27", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml"
  

    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml"
         if (SignInManager.IsSignedIn(User))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <script>\r\n                        window.location.href = \"");
#nullable restore
#line 19 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml"
                                           Write(Url.Action("index","admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                </script>\r\n");
#nullable restore
#line 21 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <script>\r\n                        window.location.href = \"");
#nullable restore
#line 25 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml"
                                           Write(Url.Action("StudentDetails","Details"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n                </script>\r\n");
#nullable restore
#line 27 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml"



            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Venkatram\OneDrive\Documents\Meena\launchcode\c#practisefolder\Main Project\Studentdatabase management system\Studentdatabase management system\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
