#pragma checksum "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db28472fa40a96428fed4fb370589ed1387aad4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Close), @"mvc.1.0.view", @"/Views/Accounts/Close.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Close.cshtml", typeof(AspNetCore.Views_Accounts_Close))]
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
#line 1 "C:\Users\Yunuo\source\repos\project1_4\Views\_ViewImports.cshtml"
using project1_4;

#line default
#line hidden
#line 2 "C:\Users\Yunuo\source\repos\project1_4\Views\_ViewImports.cshtml"
using project1_4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db28472fa40a96428fed4fb370589ed1387aad4", @"/Views/Accounts/Close.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5e3bb995bf0d60678702be071afaf7ba163b78", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Close : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<project1_4.Models.Account.Account>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Close", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
  
    ViewData["Title"] = "Close";

#line default
#line hidden
            BeginContext(85, 166, true);
            WriteLiteral("\r\n<h2>Close</h2>\r\n\r\n<h3>Are you sure you want to close this?</h3>\r\n<div>\r\n    <h4>Account</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(252, 49, false);
#line 15 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(301, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(345, 45, false);
#line 18 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayFor(model => model.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(390, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(434, 49, false);
#line 21 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayNameFor(model => model.RoutingNumber));

#line default
#line hidden
            EndContext();
            BeginContext(483, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(527, 45, false);
#line 24 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayFor(model => model.RoutingNumber));

#line default
#line hidden
            EndContext();
            BeginContext(572, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(616, 43, false);
#line 27 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(659, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(703, 39, false);
#line 30 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(742, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(786, 44, false);
#line 33 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayNameFor(model => model.Interest));

#line default
#line hidden
            EndContext();
            BeginContext(830, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(874, 40, false);
#line 36 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayFor(model => model.Interest));

#line default
#line hidden
            EndContext();
            BeginContext(914, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(958, 44, false);
#line 39 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1046, 40, false);
#line 42 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1130, 47, false);
#line 45 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountType));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1221, 43, false);
#line 48 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayFor(model => model.AccountType));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1308, 46, false);
#line 51 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1398, 42, false);
#line 54 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1440, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1484, 45, false);
#line 57 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayNameFor(model => model.CloseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1573, 41, false);
#line 60 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayFor(model => model.CloseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1658, 51, false);
#line 63 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayNameFor(model => model.ApplicationUser));

#line default
#line hidden
            EndContext();
            BeginContext(1709, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1753, 50, false);
#line 66 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
       Write(Html.DisplayFor(model => model.ApplicationUser.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1841, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ffd1b2e16894bd4840f62df08414826", async() => {
                BeginContext(1866, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1876, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "431d7516f6cc4fabab04625ebfe0d1ba", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\Close.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1912, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Close\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1995, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87d4e66e707b4fa285f67659b7a9e8c3", async() => {
                    BeginContext(2021, 6, true);
                    WriteLiteral(" BACK ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2031, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2044, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<project1_4.Models.Account.Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
