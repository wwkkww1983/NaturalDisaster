#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41de090aebad80dfe158d5c1897b872ede6ddd5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Details.cshtml", typeof(AspNetCore.Views_Users_Details))]
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
#line 1 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\_ViewImports.cshtml"
using NaturalDisasterDatabaseWebsite;

#line default
#line hidden
#line 2 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\_ViewImports.cshtml"
using NaturalDisasterDatabaseWebsite.Models;

#line default
#line hidden
#line 5 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\_ViewImports.cshtml"
using NaturalDisasterDatabaseWebsite.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41de090aebad80dfe158d5c1897b872ede6ddd5f", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("头像"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
  
    Layout = "_BackLayout";
    ViewData["Title"] = "用户信息详情";

#line default
#line hidden
            BeginContext(161, 1347, true);
            WriteLiteral(@"<style>
    h2 {
        text-align: center;
    }

    dl {
        margin-top: 18px;
    }

    dt, dd {
        margin-bottom: 10px;
    }

    dt::after {
        content: ""：""
    }

    .table {
        table-layout: fixed;
    }

    th, td {
        text-align: center;
    }

    td {
        overflow: hidden;
        word-wrap: break-word;
        text-align-last: left;
        text-align: justify;
        text-justify: newspaper;
    }

    .nopaleft {
        padding-left: 0px !important;
    }

    .hr {
        margin-top: -20px;
        margin-bottom: 0px;
        border-top: 1px solid #ddd;
    }

    tr td {
        padding: 6px 50px 6px 0px;
        font-size: 15px;
    }

    .icon {
        margin: 0 auto;
        text-align: center;
        border-radius: 50%;
        width: 100px;
        height: auto;
    }

    .icon img {
        border-radius: 50%;
        width: 100%;
        height: 100%;
    }
    .modelforumimg p{
      ");
            WriteLiteral(@"  margin-bottom:0px;
    }
    .modelforumimg p img {
        width: 20px;
        height: 20px;
    }
</style>
<h2>用户信息</h2>

<div>
    <hr />
    <table align=""center"">
        <tr>
            <td colspan=""4"" style=""padding-top:0; padding-right:0;"">
                <div class=""icon"">
                    ");
            EndContext();
            BeginContext(1508, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4179385ceba74cca86c92b73d0cd6446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1527, "~/upfiles/", 1527, 10, true);
#line 85 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
AddHtmlAttributeValue("", 1537, Html.DisplayFor(model => model.img), 1537, 36, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1577, 116, true);
            WriteLiteral("\r\n                </div>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <strong>");
            EndContext();
            BeginContext(1694, 44, false);
#line 91 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 28, true);
            WriteLiteral(":</strong>\r\n                ");
            EndContext();
            BeginContext(1767, 40, false);
#line 92 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
           Write(Html.DisplayFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 63, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <strong>");
            EndContext();
            BeginContext(1871, 44, false);
#line 95 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 28, true);
            WriteLiteral(":</strong>\r\n                ");
            EndContext();
            BeginContext(1944, 40, false);
#line 96 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
           Write(Html.DisplayFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(1984, 63, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <strong>");
            EndContext();
            BeginContext(2048, 39, false);
#line 99 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.sex));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 28, true);
            WriteLiteral(":</strong>\r\n                ");
            EndContext();
            BeginContext(2116, 35, false);
#line 100 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
           Write(Html.DisplayFor(model => model.sex));

#line default
#line hidden
            EndContext();
            BeginContext(2151, 63, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <strong>");
            EndContext();
            BeginContext(2215, 42, false);
#line 103 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(2257, 28, true);
            WriteLiteral(":</strong>\r\n                ");
            EndContext();
            BeginContext(2286, 38, false);
#line 104 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
           Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 104, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <strong>");
            EndContext();
            BeginContext(2429, 45, false);
#line 109 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.telephone));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 28, true);
            WriteLiteral(":</strong>\r\n                ");
            EndContext();
            BeginContext(2503, 41, false);
#line 110 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
           Write(Html.DisplayFor(model => model.telephone));

#line default
#line hidden
            EndContext();
            BeginContext(2544, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td colspan=\"2\">\r\n                <strong>");
            EndContext();
            BeginContext(2620, 41, false);
#line 113 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(2661, 28, true);
            WriteLiteral(":</strong>\r\n                ");
            EndContext();
            BeginContext(2690, 37, false);
#line 114 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
           Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(2727, 104, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"4\">\r\n                <strong>");
            EndContext();
            BeginContext(2832, 46, false);
#line 119 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.occupation));

#line default
#line hidden
            EndContext();
            BeginContext(2878, 28, true);
            WriteLiteral(":</strong>\r\n                ");
            EndContext();
            BeginContext(2907, 42, false);
#line 120 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
           Write(Html.DisplayFor(model => model.occupation));

#line default
#line hidden
            EndContext();
            BeginContext(2949, 104, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"4\">\r\n                <strong>");
            EndContext();
            BeginContext(3054, 45, false);
#line 125 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.workplace));

#line default
#line hidden
            EndContext();
            BeginContext(3099, 28, true);
            WriteLiteral(":</strong>\r\n                ");
            EndContext();
            BeginContext(3128, 41, false);
#line 126 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
           Write(Html.DisplayFor(model => model.workplace));

#line default
#line hidden
            EndContext();
            BeginContext(3169, 104, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"4\">\r\n                <strong>");
            EndContext();
            BeginContext(3274, 43, false);
#line 131 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(3317, 28, true);
            WriteLiteral(":</strong>\r\n                ");
            EndContext();
            BeginContext(3346, 39, false);
#line 132 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
           Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(3385, 108, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3494, 41, false);
#line 138 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.essay));

#line default
#line hidden
            EndContext();
            BeginContext(3535, 229, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th style=\"border-right: 1px solid #DEE1E6;\">文章标题</th>\r\n                    <th style=\"\">状态</th>\r\n                </tr>\r\n");
            EndContext();
#line 146 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                 foreach (var item in Model.essay)
                {

#line default
#line hidden
            BeginContext(3835, 101, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"nopaleft\">\r\n                            ");
            EndContext();
            BeginContext(3937, 40, false);
#line 150 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
            EndContext();
            BeginContext(3977, 102, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"\">\r\n\r\n                            ");
            EndContext();
            BeginContext(4080, 40, false);
#line 154 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.state));

#line default
#line hidden
            EndContext();
            BeginContext(4120, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 157 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(4199, 138, true);
            WriteLiteral("            </table>\r\n            <hr class=\"hr\" />\r\n        </dd>\r\n        <dt style=\"margin-bottom:0px; margin-top:40px;\">\r\n            ");
            EndContext();
            BeginContext(4338, 46, false);
#line 162 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.forum_msgs));

#line default
#line hidden
            EndContext();
            BeginContext(4384, 275, true);
            WriteLiteral(@"
        </dt>
        <dd style=""margin-bottom:0px; margin-top:40px;"">
            <table class=""table"">
                <tr>
                    <th style=""border-right: 1px solid #DEE1E6;"">文章标题</th>
                    <th style="""">评论信息</th>
                </tr>
");
            EndContext();
#line 170 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                 foreach (var item in Model.forum_msgs)
                {

#line default
#line hidden
            BeginContext(4735, 101, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"nopaleft\">\r\n                            ");
            EndContext();
            BeginContext(4837, 46, false);
#line 174 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.essay.title));

#line default
#line hidden
            EndContext();
            BeginContext(4883, 85, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"modelforumimg\">\r\n");
            EndContext();
            BeginContext(5045, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(5074, 55, false);
#line 178 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                       Write(Html.Raw(System.Net.WebUtility.UrlDecode(item.comment)));

#line default
#line hidden
            EndContext();
            BeginContext(5129, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 181 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(5208, 98, true);
            WriteLiteral("            </table>\r\n            <hr class=\"hr\" />\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(5306, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6008ea90802456396ecf4ec696218c0", async() => {
                BeginContext(5352, 2, true);
                WriteLiteral("编辑");
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
#line 188 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(5358, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(5366, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c149e501cc5c49ed9df19827b6eb04d1", async() => {
                BeginContext(5388, 8, true);
                WriteLiteral("返回用户管理列表");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5400, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591