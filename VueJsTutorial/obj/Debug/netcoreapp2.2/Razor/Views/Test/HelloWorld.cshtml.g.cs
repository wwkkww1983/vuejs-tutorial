#pragma checksum "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\Test\HelloWorld.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48d58e9c7fc12c9d95b8f933af0a8e08768074e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_HelloWorld), @"mvc.1.0.view", @"/Views/Test/HelloWorld.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Test/HelloWorld.cshtml", typeof(AspNetCore.Views_Test_HelloWorld))]
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
#line 1 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using VueJsTutorial;

#line default
#line hidden
#line 2 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using VueJsTutorial.Models;

#line default
#line hidden
#line 3 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using Model.Models;

#line default
#line hidden
#line 4 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using Model.ViewModels;

#line default
#line hidden
#line 5 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using Data;

#line default
#line hidden
#line 6 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\_ViewImports.cshtml"
using Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48d58e9c7fc12c9d95b8f933af0a8e08768074e8", @"/Views/Test/HelloWorld.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f59df44fbd8b141d4999b8b6eb81299e0e1445f", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_HelloWorld : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Views/Test/HelloWorld.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\Test\HelloWorld.cshtml"
  
    ViewData["Title"] = "{Test : [1,2,3,4,5]}";

#line default
#line hidden
            BeginContext(56, 4, true);
            WriteLiteral("<h4>");
            EndContext();
            BeginContext(61, 17, false);
#line 4 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\Test\HelloWorld.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(78, 11, true);
            WriteLiteral("</h4>\r\n<h3>");
            EndContext();
            BeginContext(90, 19, false);
#line 5 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\Test\HelloWorld.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 331, true);
            WriteLiteral(@"</h3>

<div id=""view"">
    <span>One way binding message:{{message}}</span>
    <br /><hr />
    <span>2-way binding msg: {{twoWayBindingMessage}}</span><br />
    <br>
    <input type=""text"" v-model=""twoWayBindingMessage"">

    <highcharts :options=""chartOptions""></highcharts>

</div>
<script>
    window.testData = ");
            EndContext();
            BeginContext(441, 27, false);
#line 18 "C:\Projects\GitHub\vuejs-tutorial\VueJsTutorial\Views\Test\HelloWorld.cshtml"
                 Write(Html.Raw(ViewData["Title"]));

#line default
#line hidden
            EndContext();
            BeginContext(468, 15, true);
            WriteLiteral("\r\n\r\n</script>\r\n");
            EndContext();
            BeginContext(483, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48d58e9c7fc12c9d95b8f933af0a8e08768074e85650", async() => {
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
            BeginContext(544, 2, true);
            WriteLiteral("\r\n");
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
