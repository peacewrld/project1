#pragma checksum "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f4d2eebacd7f6968b61d2c5f9b87c821e83b9b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_OperationsLoanAccount), @"mvc.1.0.view", @"/Views/Accounts/OperationsLoanAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/OperationsLoanAccount.cshtml", typeof(AspNetCore.Views_Accounts_OperationsLoanAccount))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4d2eebacd7f6968b61d2c5f9b87c821e83b9b8", @"/Views/Accounts/OperationsLoanAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5e3bb995bf0d60678702be071afaf7ba163b78", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_OperationsLoanAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<project1_4.Models.Account.Account>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button-operate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payloan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("button-back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Operations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:25px; font-family: \'Open Sans Condensed\', sans-serif;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
  
    ViewData["Title"] = "OperationsLoanAccount";

#line default
#line hidden
            BeginContext(114, 954, true);
            WriteLiteral(@"
<style>
    body{
        background-image: url('https://images.pexels.com/photos/62693/pexels-photo-62693.jpeg?cs=srgb&dl=-62693.jpg&fm=jpg');
    }
    th,td {
        font-family: 'Open Sans Condensed', sans-serif;
    }
    th{
        background-color:cadetblue;
        opacity: 0.8;   
    }
    .table{
        margin-top: 20px;
        border: 1px solid cadetblue;
        background-color: white;
    }

    #button-operate{
        color: cadetblue;
        opacity: 0.8;
        border-radius: 10px;
        padding-left: 5px;
        padding-right: 5px;
    }
    #button-operate:hover{
        opacity: 1;
        color: black;
        text-decoration: none;
        font-weight: 500;
    }
</style>

<h2 style=""margin-top: 50px; margin-bottom: 20px; font-family: 'Open Sans Condensed', sans-serif;"">Loan Accounts</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(1069, 49, false);
#line 45 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1174, 49, false);
#line 48 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
           Write(Html.DisplayNameFor(model => model.RoutingNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1279, 43, false);
#line 51 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
           Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1378, 44, false);
#line 54 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
           Write(Html.DisplayNameFor(model => model.Interest));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1478, 44, false);
#line 57 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
           Write(Html.DisplayNameFor(model => model.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(1522, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1578, 47, false);
#line 60 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountType));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1681, 46, false);
#line 63 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 157, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Term/Payoff Date\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 72 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1933, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1994, 48, false);
#line 76 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2110, 48, false);
#line 79 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoutingNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 68, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    $");
            EndContext();
            BeginContext(2227, 42, false);
#line 82 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
                Write(Html.DisplayFor(modelItem => item.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(2269, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2337, 43, false);
#line 85 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.Interest));

#line default
#line hidden
            EndContext();
            BeginContext(2380, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2448, 43, false);
#line 88 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.isActive));

#line default
#line hidden
            EndContext();
            BeginContext(2491, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2559, 46, false);
#line 91 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.AccountType));

#line default
#line hidden
            EndContext();
            BeginContext(2605, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2673, 45, false);
#line 94 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(2718, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2786, 44, false);
#line 97 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
               Write(Html.DisplayFor(modelItem => item.CloseDate));

#line default
#line hidden
            EndContext();
            BeginContext(2830, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2897, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d541bd9488b34bda8dcf7f728d30ac39", async() => {
                BeginContext(2965, 8, true);
                WriteLiteral("Pay Loan");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
                                                                  WriteLiteral(item.Id);

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
            BeginContext(2977, 45, true);
            WriteLiteral(" \r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 103 "C:\Users\Yunuo\source\repos\project1_4\Views\Accounts\OperationsLoanAccount.cshtml"
        }

#line default
#line hidden
            BeginContext(3033, 91, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div style=\"margin-top: 80px\">\r\n    <p style=\"text-align:center\">");
            EndContext();
            BeginContext(3124, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aafe43d3fde44f21ba026a7358fbf241", async() => {
                BeginContext(3240, 6, true);
                WriteLiteral(" BACK ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3250, 12, true);
            WriteLiteral("</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<project1_4.Models.Account.Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591
