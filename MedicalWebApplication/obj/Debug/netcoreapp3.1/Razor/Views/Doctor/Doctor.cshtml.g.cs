#pragma checksum "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\Doctor\Doctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d420e29b87866bb849dfc4d25f2a35cc421ffef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Doctor), @"mvc.1.0.view", @"/Views/Doctor/Doctor.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\_ViewImports.cshtml"
using MedicalWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\_ViewImports.cshtml"
using MedicalWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\_ViewImports.cshtml"
using MedicalWebApplicationService.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\_ViewImports.cshtml"
using MedicalWebApplicationDomain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d420e29b87866bb849dfc4d25f2a35cc421ffef7", @"/Views/Doctor/Doctor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b5d307b97ad356f683455b6a1e01866e7989a61", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Doctor_Doctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\Doctor\Doctor.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n <div class=\"profile-doc\">\r\n   <img");
            BeginWriteAttribute("src", " src=\"", 102, "\"", 123, 1);
#nullable restore
#line 7 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\Doctor\Doctor.cshtml"
WriteAttributeValue("", 108, Model.ImageUrl, 108, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"profile-img-doc\" />\r\n   <div class=\"profile-content-doc\">\r\n       <p class=\"profile-signature\">");
#nullable restore
#line 9 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\Doctor\Doctor.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n       <p class=\"profile-profile-doc\">");
#nullable restore
#line 10 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\Doctor\Doctor.cshtml"
                                 Write(Model.Profile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n   </div>\r\n </div> \r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\hp\source\repos\MedicalWebApplication\MedicalWebApplication\Views\Doctor\Doctor.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
