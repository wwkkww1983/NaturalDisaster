#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9222a6b8fdec39bf33978511980222f2489ed98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisasterData_EditCrop), @"mvc.1.0.view", @"/Views/DisasterData/EditCrop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DisasterData/EditCrop.cshtml", typeof(AspNetCore.Views_DisasterData_EditCrop))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9222a6b8fdec39bf33978511980222f2489ed98", @"/Views/DisasterData/EditCrop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_DisasterData_EditCrop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ueditor-1.4.3.3/ueditor.parse.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DisasterData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right; padding-top:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCrop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
  
    Layout = "_BackLayout";
    ViewData["Title"] = "编辑农作物生物灾害时刻数据";

#line default
#line hidden
            BeginContext(78, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(80, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6ea17b543094d97950ee7008c6184ad", async() => {
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
            BeginContext(142, 406, true);
            WriteLiteral(@"

<style>
    .content_nav {
        font-size: 16px;
        font-weight: 500;
        margin-top: 10px;
    }

    .form-control {
        display: inline-block;
        width: auto;
    }

    .diflex {
        display: flex;
        justify-content: space-between;
    }

    label {
        width: 100px;
        text-align: center;
    }
</style>
<p class=""content_nav"">
    ");
            EndContext();
            BeginContext(549, 17, false);
#line 31 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(566, 84, true);
            WriteLiteral("\r\n    <input type=\"submit\" value=\"保 存\" class=\"btn btn-warning\" form=\"form1\" />\r\n    ");
            EndContext();
            BeginContext(650, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5199a1da4b2d430595d6e6ae3aa7c650", async() => {
                BeginContext(740, 10, true);
                WriteLiteral("返回灾害数据管理列表");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(754, 139, true);
            WriteLiteral("\r\n</p>\r\n<hr style=\"margin-top:12px;\" />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\" style=\"margin:0 auto; text-align:center;\">\r\n        ");
            EndContext();
            BeginContext(893, 3339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "176540fa8586428984e9e34994b24202", async() => {
                BeginContext(975, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(989, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab03b6130654eaaa1dd0d3f46181f86", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 39 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1055, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
             foreach (var cropedit in ViewBag.cropedit)
            {

#line default
#line hidden
                BeginContext(1129, 46, true);
                WriteLiteral("                <input name=\"ID\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1175, "\"", 1195, 1);
#line 42 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
WriteAttributeValue("", 1183, cropedit.ID, 1183, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1196, 140, true);
                WriteLiteral(" />\r\n                <div class=\"form-group\">\r\n                    <label>时&emsp;&emsp;间</label>\r\n                    <input name=\"croptime\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1336, "\"", 1422, 1);
#line 45 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
WriteAttributeValue("", 1344, DateTime.Parse(@cropedit.croptime.ToString()).ToString("yyyy-MM-dd HH:mm:ss"), 1344, 78, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1423, 199, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group right\">\r\n                    <label>经&emsp;&emsp;度(°)</label>\r\n                    <input name=\"croplongitude\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1622, "\"", 1653, 1);
#line 49 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
WriteAttributeValue("", 1630, cropedit.croplongitude, 1630, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1654, 193, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>维&emsp;&emsp;度(°)</label>\r\n                    <input name=\"cropdimension\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1847, "\"", 1878, 1);
#line 53 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
WriteAttributeValue("", 1855, cropedit.cropdimension, 1855, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1879, 182, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group right\">\r\n                    <label>灾害类型</label>\r\n                    <input name=\"cropstyle\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2061, "\"", 2088, 1);
#line 57 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
WriteAttributeValue("", 2069, cropedit.cropstyle, 2069, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2089, 176, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>参考位置</label>\r\n                    <input name=\"cropplace\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2265, "\"", 2292, 1);
#line 61 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
WriteAttributeValue("", 2273, cropedit.cropplace, 2273, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2293, 185, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group right\">\r\n                    <label>经济损失(万元)</label>\r\n                    <input name=\"croploss\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2478, "\"", 2504, 1);
#line 65 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
WriteAttributeValue("", 2486, cropedit.croploss, 2486, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2505, 179, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>受灾范围(公顷)</label>\r\n                    <input name=\"croparea\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2684, "\"", 2710, 1);
#line 69 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
WriteAttributeValue("", 2692, cropedit.croparea, 2692, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2711, 383, true);
                WriteLiteral(@" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <span style=""font-weight: 600;"">详&emsp;&emsp;情</span>
                    <input name=""cropdetails"" type=""hidden"" class=""form-control"" id=""content"" />

                    <script id=""editor"" type=""text/plain"" style=""width:100%;height:auto;"">
                        ");
                EndContext();
                BeginContext(3095, 64, false);
#line 76 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
                   Write(Html.Raw(System.Net.WebUtility.UrlDecode(@cropedit.cropdetails)));

#line default
#line hidden
                EndContext();
                BeginContext(3159, 1041, true);
                WriteLiteral(@"
                    </script>
                    <script type=""text/javascript"">
                        $(function () {
                            UE.delEditor('editor');
                            var ue = UE.getEditor('editor', {
                                allowDivTransToP: false,//阻止div标签自动转换为p标签
                                autoHeightEnabled: true,
                                autoFloatEnabled: true
                            });
                            ue.ready(function () {
                                $("".edui-editor-messageholder.edui-default"").css({ ""visibility"": ""hidden"" });
                            })
                        });
                        function cc() {
                            document.getElementById('content').value = UE.getEditor('editor').getContent();
                        }
                        setInterval(function () {
                            cc();
                        }, 100);
                    </script>
       ");
                WriteLiteral("         </div>\r\n");
                EndContext();
#line 98 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
            }

#line default
#line hidden
                BeginContext(4215, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4232, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4274, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 105 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditCrop.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
