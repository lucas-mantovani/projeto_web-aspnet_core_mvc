#pragma checksum "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dcb201cd91a0a376547a4576b772e00b556a9c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\_ViewImports.cshtml"
using mvc_project;

#line default
#line hidden
#line 2 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\_ViewImports.cshtml"
using mvc_project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dcb201cd91a0a376547a4576b772e00b556a9c5", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1291e31b91ce9ef81dab6f2331e836eaf1ff193a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mvc_project.Models.ViewModels.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Shared\Error.cshtml"
  
    ViewData["title"] = "Error";

#line default
#line hidden
            BeginContext(96, 26, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">");
            EndContext();
            BeginContext(123, 17, false);
#line 7 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Shared\Error.cshtml"
                   Write(ViewData["title"]);

#line default
#line hidden
            EndContext();
            BeginContext(140, 32, true);
            WriteLiteral(".</h1>\r\n<h2 class=\"text-danger\">");
            EndContext();
            BeginContext(173, 13, false);
#line 8 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Shared\Error.cshtml"
                   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(186, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(225, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(278, 15, false);
#line 13 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(293, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 15 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(315, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mvc_project.Models.ViewModels.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
