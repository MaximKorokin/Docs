#pragma checksum "E:\Other\nure\GL\Docs\Docs\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97e4abbbd29f4c569014fea17fa570ad633fec7f"
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
#line 1 "E:\Other\nure\GL\Docs\Docs\Views\_ViewImports.cshtml"
using Docs;

#line default
#line hidden
#line 2 "E:\Other\nure\GL\Docs\Docs\Views\_ViewImports.cshtml"
using Docs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97e4abbbd29f4c569014fea17fa570ad633fec7f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd24a0a0e7c2bcfc86ebec632088364a8aa3512", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Document>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Document", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Other\nure\GL\Docs\Docs\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(75, 103, true);
            WriteLiteral("\r\n<div id=\"docListUpper\">\r\n    <input type=\"button\" class=\"btn btn-default\" value=\"Create new document\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 178, "\"", 235, 5);
            WriteAttributeValue("", 188, "location.href", 188, 13, true);
            WriteAttributeValue(" ", 201, "=", 202, 2, true);
            WriteAttributeValue(" ", 203, "\'", 204, 2, true);
#line 7 "E:\Other\nure\GL\Docs\Docs\Views\Home\Index.cshtml"
WriteAttributeValue("", 205, Url.Action("Create", "Home"), 205, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 234, "\'", 234, 1, true);
            EndWriteAttribute();
            BeginContext(236, 30, true);
            WriteLiteral(">\r\n</div>\r\n<div class=\"row\">\r\n");
            EndContext();
#line 10 "E:\Other\nure\GL\Docs\Docs\Views\Home\Index.cshtml"
     foreach (Document doc in Model)
    {

#line default
#line hidden
            BeginContext(311, 103, true);
            WriteLiteral("        <div class=\"docListPart col-md-8\">\r\n            <div class=\"docListPartName\">\r\n                ");
            EndContext();
            BeginContext(414, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b61622d113cf4e48a43c76fb2531aed7", async() => {
                BeginContext(463, 8, false);
#line 14 "E:\Other\nure\GL\Docs\Docs\Views\Home\Index.cshtml"
                                                           Write(doc.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "E:\Other\nure\GL\Docs\Docs\Views\Home\Index.cshtml"
                                           WriteLiteral(doc.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(475, 117, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"docListPartText\">\r\n                <span style=\"white-space: pre-wrap\">");
            EndContext();
            BeginContext(593, 11, false);
#line 17 "E:\Other\nure\GL\Docs\Docs\Views\Home\Index.cshtml"
                                               Write(doc.Content);

#line default
#line hidden
            EndContext();
            BeginContext(604, 45, true);
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 20 "E:\Other\nure\GL\Docs\Docs\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(656, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Document>> Html { get; private set; }
    }
}
#pragma warning restore 1591
