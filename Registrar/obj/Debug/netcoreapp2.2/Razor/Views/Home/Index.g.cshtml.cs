#pragma checksum "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68a1408bf7168db1b097fc676405917c7cf3482d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68a1408bf7168db1b097fc676405917c7cf3482d", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Home/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 50, true);
            WriteLiteral("\r\n<h1>Welcome to the Registrar homepage!</h1>\r\n<p>");
            EndContext();
            BeginContext(81, 54, false);
#line 6 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all courses", "Index", "Courses"));

#line default
#line hidden
            EndContext();
            BeginContext(135, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(145, 55, false);
#line 7 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Home/Index.cshtml"
Write(Html.ActionLink("See all student", "Index", "Students"));

#line default
#line hidden
            EndContext();
            BeginContext(200, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(210, 56, false);
#line 8 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Home/Index.cshtml"
Write(Html.ActionLink("Create an account", "Index", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(266, 4, true);
            WriteLiteral("</p>");
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
