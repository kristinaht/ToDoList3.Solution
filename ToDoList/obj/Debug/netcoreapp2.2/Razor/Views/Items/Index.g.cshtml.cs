#pragma checksum "C:\Users\Kristina\desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83112c090fb57c74013be228d67d9f68817dac09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
#line 1 "C:\Users\Kristina\desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83112c090fb57c74013be228d67d9f68817dac09", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 25, true);
            WriteLiteral("\r\n<h1>To Do List</h1>\r\n\r\n");
            EndContext();
#line 6 "C:\Users\Kristina\desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
 if(Model.Count == 0)
{

#line default
#line hidden
            BeginContext(117, 42, true);
            WriteLiteral("  <p>There are no items in the list.</p>\r\n");
            EndContext();
#line 9 "C:\Users\Kristina\desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
}

#line default
#line hidden
            BeginContext(162, 6, true);
            WriteLiteral("<ul>\r\n");
            EndContext();
#line 11 "C:\Users\Kristina\desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
   foreach(Item item in Model)
  {

#line default
#line hidden
            BeginContext(205, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(214, 16, false);
#line 13 "C:\Users\Kristina\desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
   Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(230, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\Users\Kristina\desktop\ToDoList.Solution\ToDoList\Views\Items\Index.cshtml"
  }

#line default
#line hidden
            BeginContext(242, 49, true);
            WriteLiteral("</ul>\r\n\r\n<a href=\"/items/new\">Add a new item.</a>");
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
