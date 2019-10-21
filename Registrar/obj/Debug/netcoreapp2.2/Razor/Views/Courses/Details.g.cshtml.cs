#pragma checksum "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05dfa3261d223a972dacbb05a1093340cb5927a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Details), @"mvc.1.0.view", @"/Views/Courses/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Details.cshtml", typeof(AspNetCore.Views_Courses_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05dfa3261d223a972dacbb05a1093340cb5927a5", @"/Views/Courses/Details.cshtml")]
    public class Views_Courses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 36, true);
            WriteLiteral("\n<h2>Course Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(97, 46, false);
#line 9 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(143, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(146, 42, false);
#line 9 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
                                                Write(Html.DisplayFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(188, 7, true);
            WriteLiteral("</h3>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
 if(@Model.Students.Count == 0)
{

#line default
#line hidden
            BeginContext(229, 51, true);
            WriteLiteral("  <p>This course does not contain any Students</p>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(289, 48, true);
            WriteLiteral("  <h4>Students the course contains:</h4>\n  <ul>\n");
            EndContext();
#line 19 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
   foreach(var join in Model.Students)
  {

#line default
#line hidden
            BeginContext(380, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(389, 24, false);
#line 21 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
   Write(join.Student.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(413, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 22 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(423, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 24 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
}

#line default
#line hidden
            BeginContext(433, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(438, 43, false);
#line 26 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Back to courses", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(481, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(490, 67, false);
#line 27 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Edit Course", "Edit", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(557, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(566, 71, false);
#line 28 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Courses/Details.cshtml"
Write(Html.ActionLink("Delete Course", "Delete", new { id = Model.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(637, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
