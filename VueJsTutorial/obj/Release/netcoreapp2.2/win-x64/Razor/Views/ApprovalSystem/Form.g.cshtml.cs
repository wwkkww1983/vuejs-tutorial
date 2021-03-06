#pragma checksum "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\ApprovalSystem\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7381fd995e9d6f2c8b25dbce7bc47937fe076394"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApprovalSystem_Form), @"mvc.1.0.view", @"/Views/ApprovalSystem/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ApprovalSystem/Form.cshtml", typeof(AspNetCore.Views_ApprovalSystem_Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7381fd995e9d6f2c8b25dbce7bc47937fe076394", @"/Views/ApprovalSystem/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f59df44fbd8b141d4999b8b6eb81299e0e1445f", @"/Views/_ViewImports.cshtml")]
    public class Views_ApprovalSystem_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Development\Tutorials\VueJsTutorial\VueJsTutorial\Views\ApprovalSystem\Form.cshtml"
  
	ViewData["Title"] = "Form";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(81, 145, true);
            WriteLiteral("\r\n<h1>Form</h1>\r\n\r\n<div id=\"form-ex\">\r\n\t<p>\r\n\t\t<input v-model=\"question\" />\r\n\t</p>\r\n\t<p>{{answer}}</p>\r\n</div>\r\n\r\n<div id=\"vue-form\">\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(243, 1502, true);
                WriteLiteral(@"
	<script>
		var watchExampleVM = new Vue({
			el: '#form-ex',
			data: {
				question: '',
				answer: 'I cannot give you an answer until you ask a question!'
			},
			watch: {
				// whenever question changes, this function will run
				question: function (newQuestion, oldQuestion) {
					this.answer = 'Waiting for you to stop typing...'
					this.debouncedGetAnswer()
				}
			},
			created: function () {
				// _.debounce is a function provided by lodash to limit how
				// often a particularly expensive operation can be run.
				// In this case, we want to limit how often we access
				// yesno.wtf/api, waiting until the user has completely
				// finished typing before making the ajax request. To learn
				// more about the _.debounce function (and its cousin
				// _.throttle), visit: https://lodash.com/docs#debounce
				this.debouncedGetAnswer = _.debounce(this.getAnswer, 500)
			},
			methods: {
				getAnswer: function () {
					if (this.question.indexOf('?') === -1) {
				");
                WriteLiteral(@"		this.answer = 'Questions usually contain a question mark. ;-)'
						return
					}
					this.answer = 'Thinking...'
					var vm = this
					axios.get('https://yesno.wtf/api')
						.then(function (response) {
							vm.answer = _.capitalize(response.data.answer)
						})
						.catch(function (error) {
							vm.answer = 'Error! Could not reach the API. ' + error
						})
				}
			}
		});

		//var vm = new Vue({
		//	el: '#vue-form'
		//});
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
