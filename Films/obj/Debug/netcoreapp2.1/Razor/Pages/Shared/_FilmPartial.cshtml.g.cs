#pragma checksum "C:\Users\alekh\Downloads\New folder\Films\Films\Pages\Shared\_FilmPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a73662f01ac76c3227c3574b806efb4219b09618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Films.Pages.Shared.Pages_Shared__FilmPartial), @"mvc.1.0.view", @"/Pages/Shared/_FilmPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_FilmPartial.cshtml", typeof(Films.Pages.Shared.Pages_Shared__FilmPartial))]
namespace Films.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\alekh\Downloads\New folder\Films\Films\Pages\_ViewImports.cshtml"
using Films;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73662f01ac76c3227c3574b806efb4219b09618", @"/Pages/Shared/_FilmPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c538de9f724811c4a56ffd8148aab183ba5e602", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__FilmPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pages.Models.FilmsModal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 81, true);
            WriteLiteral("    <div class=\"bg-info center\">\r\n        <h1 class=\"alert-danger\">\r\n            ");
            EndContext();
            BeginContext(114, 11, false);
#line 4 "C:\Users\alekh\Downloads\New folder\Films\Films\Pages\Shared\_FilmPartial.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(125, 42, true);
            WriteLiteral("\r\n        </h1>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(168, 17, false);
#line 7 "C:\Users\alekh\Downloads\New folder\Films\Films\Pages\Shared\_FilmPartial.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(185, 44, true);
            WriteLiteral("\r\n        </p>\r\n        <time>\r\n            ");
            EndContext();
            BeginContext(230, 14, false);
#line 10 "C:\Users\alekh\Downloads\New folder\Films\Films\Pages\Shared\_FilmPartial.cshtml"
       Write(Model.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(244, 33, true);
            WriteLiteral(" Min\r\n        </time>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages.Models.FilmsModal> Html { get; private set; }
    }
}
#pragma warning restore 1591