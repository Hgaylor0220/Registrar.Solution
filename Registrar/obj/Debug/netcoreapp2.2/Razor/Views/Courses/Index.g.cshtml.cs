#pragma checksum "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d80bb06f47a04d911aa5b48821d303149c99e1fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Index.cshtml", typeof(AspNetCore.Views_Courses_Index))]
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
#line 5 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml"
using Registrar.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d80bb06f47a04d911aa5b48821d303149c99e1fd", @"/Views/Courses/Index.cshtml")]
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Registrar.Models.Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(91, 19, true);
            WriteLiteral("\n<h1>Courses</h1>\n\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(136, 43, true);
            WriteLiteral("  <h3>No courses have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(182, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml"
 foreach (Course course in Model)
{

#line default
#line hidden
            BeginContext(219, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(226, 80, false);
#line 17 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml"
 Write(Html.ActionLink($"{course.CourseName}", "Details", new { id = course.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(306, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml"
}

#line default
#line hidden
            BeginContext(314, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(319, 43, false);
#line 20 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml"
Write(Html.ActionLink("Add new course", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(362, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(372, 40, false);
#line 22 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(412, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Registrar.Models.Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
