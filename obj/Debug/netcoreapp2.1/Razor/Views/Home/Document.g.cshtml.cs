#pragma checksum "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfcdcde62e14fea5b3e27fc8b36c7b63d7905213"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Document), @"mvc.1.0.view", @"/Views/Home/Document.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Document.cshtml", typeof(AspNetCore.Views_Home_Document))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfcdcde62e14fea5b3e27fc8b36c7b63d7905213", @"/Views/Home/Document.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cd24a0a0e7c2bcfc86ebec632088364a8aa3512", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Document : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<Document, DocumentMember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Members", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
  
    ViewData["Title"] = "Document";

#line default
#line hidden
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
  
    bool owner = Model.Item2 == null;
    bool canEdit = owner || Model.Item2.Role.Edit;

#line default
#line hidden
            BeginContext(184, 31, true);
            WriteLiteral("\r\n<div class=\"docListPartName\">");
            EndContext();
            BeginContext(216, 16, false);
#line 11 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                        Write(Model.Item1.Name);

#line default
#line hidden
            EndContext();
            BeginContext(232, 85, true);
            WriteLiteral("</div>\r\n<div>\r\n    <textarea id=\"textArea\"\r\n              name=\"text\"\r\n              ");
            EndContext();
#line 15 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
               if (canEdit) { 

#line default
#line hidden
            BeginContext(339, 24, true);
            WriteLiteral(" oninput=\"textChange()\" ");
            EndContext();
#line 15 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                                                    }

#line default
#line hidden
            BeginContext(374, 14, true);
            WriteLiteral("              ");
            EndContext();
#line 16 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
               if (!canEdit) { 

#line default
#line hidden
            BeginContext(411, 9, true);
            WriteLiteral(" disabled");
            EndContext();
#line 16 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                                      }

#line default
#line hidden
            BeginContext(429, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(431, 19, false);
#line 16 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                                   Write(Model.Item1.Content);

#line default
#line hidden
            EndContext();
            BeginContext(450, 133, true);
            WriteLiteral("</textarea>\r\n</div>\r\n<div style=\"visibility: hidden\" id=\"changingWarning\"><span id=\"changingUser\">user_name</span> is typing.</div>\r\n");
            EndContext();
#line 19 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
 if (owner)
{

#line default
#line hidden
            BeginContext(599, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(618, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0684c8deb53345e6aad0a74c1372d2e3", async() => {
                BeginContext(680, 6, true);
                WriteLiteral("Delete");
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
#line 22 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                         WriteLiteral(Model.Item1.Id);

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
            BeginContext(690, 33, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(723, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e41d7d409de4bbeac231a71727f0323", async() => {
                BeginContext(778, 7, true);
                WriteLiteral("Members");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                  WriteLiteral(Model.Item1.Id);

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
            BeginContext(789, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 27 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
}

#line default
#line hidden
            BeginContext(806, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
            BeginContext(910, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(914, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc1a9ce6bb9d41f8a5a810c58284c67f", async() => {
                BeginContext(978, 8, true);
                WriteLiteral("Download");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                                       WriteLiteral(Model.Item1.Id);

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
            BeginContext(990, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1017, 120, true);
                WriteLiteral("\r\n    <script>\r\n        var textarea = $(\"#textArea\");\r\n        var getTextTimer;\r\n        var getTextWaitTime = 1000;\r\n");
                EndContext();
#line 37 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
     if (canEdit)
    {
        

#line default
#line hidden
                BeginContext(1177, 787, true);
                WriteLiteral(@"
        var isChanged = false;
        var changeWaitTime = 500;
        var changeTextTimer;

        function textChange() {
            if (!isChanged) {
                sendStartChange();
                //console.log(""started changing"");
            }
            clearTimeout(changeTextTimer);
            clearTimeout(getTextTimer);
            isChanged = true;
            changeTextTimer = setTimeout(
                function() {
                    isChanged = false;
                    sendText();
                    //console.log(""changes saved"");
                    setGetTextTimer();
                },
                changeWaitTime
            );
        }

        function sendStartChange() {
             $.ajax({
                url: """);
                EndContext();
                BeginContext(1965, 41, false);
#line 65 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                 Write(Url.Action("DocumentStartChange", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(2006, 84, true);
                WriteLiteral("\",\r\n                type: \"POST\",\r\n                data: {\r\n                    id: ");
                EndContext();
                BeginContext(2091, 14, false);
#line 68 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                   Write(Model.Item1.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2105, 126, true);
                WriteLiteral("\r\n                }\r\n            });\r\n        }\r\n\r\n        function sendText() {\r\n            $.ajax({\r\n                url: \"");
                EndContext();
                BeginContext(2232, 36, false);
#line 75 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                 Write(Url.Action("DocumentChange", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(2268, 84, true);
                WriteLiteral("\",\r\n                type: \"POST\",\r\n                data: {\r\n                    id: ");
                EndContext();
                BeginContext(2353, 14, false);
#line 78 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                   Write(Model.Item1.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2367, 103, true);
                WriteLiteral(",\r\n                    content: textarea.val()\r\n                }\r\n            });\r\n        }\r\n        ");
                EndContext();
#line 83 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
               
    }

#line default
#line hidden
                BeginContext(2486, 262, true);
                WriteLiteral(@"
        $(function () {
            setGetTextTimer();
        });
        function setGetTextTimer() {
            getTextTimer = setInterval(getText, getTextWaitTime);
        }
        function getText() {
            $.ajax({
                url: '");
                EndContext();
                BeginContext(2749, 37, false);
#line 94 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                 Write(Url.Action("GetDocumentInfo", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(2786, 62, true);
                WriteLiteral("\',\r\n                type: \'GET\',\r\n                data: { id: ");
                EndContext();
                BeginContext(2849, 14, false);
#line 96 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                       Write(Model.Item1.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2863, 338, true);
                WriteLiteral(@" },
                success: function (data) {
                    if (data.changingUser != null) {
                        textarea.attr(""disabled"", true);
                        $(""#changingWarning"").css(""visibility"", ""visible"");
                        $(""#changingUser"").text(data.changingUser);
                    } else if(""");
                EndContext();
                BeginContext(3202, 7, false);
#line 102 "E:\Other\nure\GL\Docs\Docs\Views\Home\Document.cshtml"
                          Write(canEdit);

#line default
#line hidden
                EndContext();
                BeginContext(3209, 342, true);
                WriteLiteral(@""" == ""True"") {
                        textarea.attr(""disabled"", false);
                        $(""#changingWarning"").css(""visibility"", ""hidden"");
                    }
                    textarea.val(data.content);
                    //console.log(""new text received"");
                }
            });
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<Document, DocumentMember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
