#pragma checksum "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "686437a39df957b2af8308e2a0bbeeaef56c7dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686437a39df957b2af8308e2a0bbeeaef56c7dd8", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1291e31b91ce9ef81dab6f2331e836eaf1ff193a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(48, 17, false);
#line 4 "C:\Users\lucas\OneDrive\Área de Trabalho\projeto mvc novo\mvc_project_aspnet-Core\mvc_project\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 297, true);
            WriteLiteral(@"</h1>

<h4>Social network</h4>
<a>https://www.linkedin.com/in/lucas-mantovani-561339219/</a>
<h4>Repository</h4>
<a>https://github.com/lucas-mantovani/</a>
<hr />
<address>
    <strong>Contact:</strong> <a href=""mailto:lucasm123345@gmail.com"">lucasm123345@gmail.com</a><br />
</address>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591