#pragma checksum "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\Component\SubListComponent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f7e2ac18e7ead337027601675834bd19e04357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Component_SubListComponent), @"mvc.1.0.view", @"/Views/Component/SubListComponent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Component/SubListComponent.cshtml", typeof(AspNetCore.Views_Component_SubListComponent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f7e2ac18e7ead337027601675834bd19e04357", @"/Views/Component/SubListComponent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f59df44fbd8b141d4999b8b6eb81299e0e1445f", @"/Views/_ViewImports.cshtml")]
    public class Views_Component_SubListComponent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\Component\SubListComponent.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(103, 208, true);
                WriteLiteral("\r\n\t<script type=\"text/javascript\">\r\n\t\t\r\n\r\n\t\tvar vue = new Vue({\r\n\t\t\tel: \"#vue-app\",\r\n\t\t\tdata: {\r\n\t\t\t\tresult: []\r\n\t\t\t},\r\n\t\t\tcreated() {\r\n\t\t\t\t$get(this, \"/data/productactivity.json\");\r\n\t\t\t}\r\n\t\t});\r\n\t</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
