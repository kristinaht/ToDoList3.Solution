#pragma checksum "C:\Users\Kristina\desktop\To-Do-List-2.Solution\ToDoList\Views\Items\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84e34d5678852830bff7a90d9b79c845bd7b7164"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_New), @"mvc.1.0.view", @"/Views/Items/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/New.cshtml", typeof(AspNetCore.Views_Items_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84e34d5678852830bff7a90d9b79c845bd7b7164", @"/Views/Items/New.cshtml")]
    public class Views_Items_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 22, true);
            WriteLiteral("<h1>Add a new item to ");
            EndContext();
            BeginContext(23, 10, false);
#line 1 "C:\Users\Kristina\desktop\To-Do-List-2.Solution\ToDoList\Views\Items\New.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(33, 14, true);
            WriteLiteral("</h1>\r\n\r\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 47, "\"", 83, 3);
            WriteAttributeValue("", 56, "/categories/", 56, 12, true);
#line 3 "C:\Users\Kristina\desktop\To-Do-List-2.Solution\ToDoList\Views\Items\New.cshtml"
WriteAttributeValue("", 68, Model.Id, 68, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 77, "/items", 77, 6, true);
            EndWriteAttribute();
            BeginContext(84, 71, true);
            WriteLiteral(" method=\"post\">\r\n<input id=\"categoryId\" name=\"categoryId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 155, "\"", 172, 1);
#line 4 "C:\Users\Kristina\desktop\To-Do-List-2.Solution\ToDoList\Views\Items\New.cshtml"
WriteAttributeValue("", 163, Model.Id, 163, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(173, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
            BeginContext(213, 160, true);
            WriteLiteral("  <label for=\"description\">Add a new item</label>\r\n  <input id=\"description\" name=\"description\" type=\"text\">\r\n  <button type=\"submit\">Submit</button>\r\n  </form>");
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
