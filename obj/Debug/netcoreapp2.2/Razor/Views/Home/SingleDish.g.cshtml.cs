#pragma checksum "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/Home/SingleDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36bececb69803a26d95821bc62e243883fcc2930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SingleDish), @"mvc.1.0.view", @"/Views/Home/SingleDish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SingleDish.cshtml", typeof(AspNetCore.Views_Home_SingleDish))]
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
#line 1 "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/_ViewImports.cshtml"
using CRUD;

#line default
#line hidden
#line 2 "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/_ViewImports.cshtml"
using CRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36bececb69803a26d95821bc62e243883fcc2930", @"/Views/Home/SingleDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813d028d5e7480ef09b6d196de8cd6b00c3ad294", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SingleDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(12, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(13, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36bececb69803a26d95821bc62e243883fcc29303691", async() => {
                BeginContext(57, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(65, 6, true);
            WriteLiteral("\n\n<h1>");
            EndContext();
            BeginContext(72, 23, false);
#line 5 "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/Home/SingleDish.cshtml"
Write(ViewBag.singleDish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(95, 11, true);
            WriteLiteral("</h1>\n\n<h3>");
            EndContext();
            BeginContext(107, 23, false);
#line 7 "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/Home/SingleDish.cshtml"
Write(ViewBag.singleDish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(130, 10, true);
            WriteLiteral("</h3>\n\n<p>");
            EndContext();
            BeginContext(141, 30, false);
#line 9 "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/Home/SingleDish.cshtml"
Write(ViewBag.singleDish.Description);

#line default
#line hidden
            EndContext();
            BeginContext(171, 19, true);
            WriteLiteral("</p>\n\n<p>Calories: ");
            EndContext();
            BeginContext(191, 27, false);
#line 11 "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/Home/SingleDish.cshtml"
        Write(ViewBag.singleDish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(218, 19, true);
            WriteLiteral("</p>\n<p>Tastiness: ");
            EndContext();
            BeginContext(238, 28, false);
#line 12 "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/Home/SingleDish.cshtml"
         Write(ViewBag.singleDish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(266, 11, true);
            WriteLiteral("</p>\n\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 277, "\"", 318, 2);
            WriteAttributeValue("", 284, "/delete/", 284, 8, true);
#line 14 "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/Home/SingleDish.cshtml"
WriteAttributeValue("", 292, ViewBag.singleDish.DishId, 292, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(319, 21, true);
            WriteLiteral(">Delete</a></p>\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 340, "\"", 379, 2);
            WriteAttributeValue("", 347, "/edit/", 347, 6, true);
#line 15 "/Users/taishekenya/Desktop/C#_stack/CRUD/Views/Home/SingleDish.cshtml"
WriteAttributeValue("", 353, ViewBag.singleDish.DishId, 353, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(380, 15, true);
            WriteLiteral(">Edit</a></p>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591