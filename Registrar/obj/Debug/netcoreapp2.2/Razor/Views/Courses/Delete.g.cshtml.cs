#pragma checksum "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86f4dde8e8fc90ac87d7ebe3e223d0bfe30b187d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Delete), @"mvc.1.0.view", @"/Views/Courses/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Delete.cshtml", typeof(AspNetCore.Views_Courses_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f4dde8e8fc90ac87d7ebe3e223d0bfe30b187d", @"/Views/Courses/Delete.cshtml")]
    public class Views_Courses_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(109, 46, false);
#line 9 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(155, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(158, 42, false);
#line 9 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(200, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(229, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(275, 43, false);
#line 14 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Delete.cshtml"
Write(Html.ActionLink("Back to courses", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
