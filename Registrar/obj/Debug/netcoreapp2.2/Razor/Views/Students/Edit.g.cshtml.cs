#pragma checksum "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b3b6c6963b9175520b3b54aa6974609d4db3aa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Edit), @"mvc.1.0.view", @"/Views/Students/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Edit.cshtml", typeof(AspNetCore.Views_Students_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3b6c6963b9175520b3b54aa6974609d4db3aa3", @"/Views/Students/Edit.cshtml")]
    public class Views_Students_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 34, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit Student: ");
            EndContext();
            BeginContext(95, 43, false);
#line 9 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
             Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(138, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(178, 40, false);
#line 13 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
Write(Html.HiddenFor(model => model.StudentId));

#line default
#line hidden
            EndContext();
            BeginContext(225, 41, false);
#line 15 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
Write(Html.LabelFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(272, 42, false);
#line 16 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
Write(Html.EditorFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(320, 40, false);
#line 17 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
Write(Html.LabelFor(model => model.Enrollment));

#line default
#line hidden
            EndContext();
            BeginContext(366, 74, false);
#line 18 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
Write(Html.EditorFor(model => model.Enrollment, new { @student = "enrollment" }));

#line default
#line hidden
            EndContext();
            BeginContext(448, 27, false);
#line 21 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
Write(Html.Label("Select course"));

#line default
#line hidden
            EndContext();
            BeginContext(481, 29, false);
#line 22 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
Write(Html.DropDownList("CourseId"));

#line default
#line hidden
            EndContext();
            BeginContext(512, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 25 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(555, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(560, 40, false);
#line 27 "/Users/Guest/Desktop/Registrar.Solution/Registrar/Views/Students/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(600, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
