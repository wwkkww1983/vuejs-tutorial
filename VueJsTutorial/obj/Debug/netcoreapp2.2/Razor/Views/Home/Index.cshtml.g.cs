#pragma checksum "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0256a7fbe2b5087c86c2a8a8749ac8e318852c78"
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
#line 1 "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using VueJsTutorial;

#line default
#line hidden
#line 2 "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using VueJsTutorial.Models;

#line default
#line hidden
#line 3 "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using Model.Models;

#line default
#line hidden
#line 4 "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using Model.ViewModels;

#line default
#line hidden
#line 5 "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using Data;

#line default
#line hidden
#line 6 "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0256a7fbe2b5087c86c2a8a8749ac8e318852c78", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f59df44fbd8b141d4999b8b6eb81299e0e1445f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VueJsTutorial.Models.UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/component/tableRecordComponent.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/view/indexpage/tableRecords.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\Home\Index.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(80, 234, true);
            WriteLiteral("\r\n<div v-if=\"typeof result.model !== \'undefined\'\">\r\n\t<otable ref=\"otable\" title=\"List of Software Developers\" v-bind:list=\"result.model\" v-bind:headers=\"result.headers\" v-bind:header-filters=\"result.tableFilters\"></otable>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(331, 1112, true);
                WriteLiteral(@"
	<script type=""text/javascript"">
		var localUrl = ""https://localhost:44328"";

		/*
var searchInputs = document.getElementsByClassName(""search-input""),
sortElements = document.getElementsByClassName(""fa-filter"");

Array.from(searchInputs).forEach(function (element) {
element.addEventListener(""keypress"", search);
});

Array.from(sortElements).forEach(function (element) {
element.addEventListener(""click"", click);
});

function search(event) {
//TODO: get all search parameters and generate search array
console.log(""keypress: "" + event.keyCode);

if (event.keyCode == 13) {
console.log(event);
}
}

function click(event) {
var clickedElement = event.target;

if (typeof clickedElement !== ""undefined"" && clickedElement != null) {
var column = clickedElement.attributes[""data-column""].value,
searchInput = document.querySelector("".search-input[data-column='"" + column + ""']"");

if (typeof searchInput !== ""undefined"" && searchInput != null) {
clickedElement.parentNode.parentNode.previousEl");
                WriteLiteral("ementSibling.classList.remove(\"hide\");\r\nsearchInput.focus();\r\n}\r\n}\r\n}\r\n*/\r\n\t</script>\r\n\t");
                EndContext();
                BeginContext(1443, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0256a7fbe2b5087c86c2a8a8749ac8e318852c786404", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1505, 3, true);
                WriteLiteral("\r\n\t");
                EndContext();
                BeginContext(1508, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0256a7fbe2b5087c86c2a8a8749ac8e318852c787657", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1567, 2, true);
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VueJsTutorial.Models.UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
