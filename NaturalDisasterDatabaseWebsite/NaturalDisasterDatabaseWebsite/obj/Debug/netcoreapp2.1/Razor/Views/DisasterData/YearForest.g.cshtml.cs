#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23fab0957e1595438fc951f331cecb92e1b82176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisasterData_YearForest), @"mvc.1.0.view", @"/Views/DisasterData/YearForest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DisasterData/YearForest.cshtml", typeof(AspNetCore.Views_DisasterData_YearForest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23fab0957e1595438fc951f331cecb92e1b82176", @"/Views/DisasterData/YearForest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_DisasterData_YearForest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DisasterData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YearCreateForest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YearEditForest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YearDeleteForest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 20, true);
            WriteLiteral("<div style=\"\">\r\n    ");
            EndContext();
            BeginContext(20, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e543bef7f98473f8e4066e26b40d83e", async() => {
                BeginContext(83, 68, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i><span>添加年度灾害数据：森林生物灾害</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(155, 1278, true);
            WriteLiteral(@"
    <button onclick=""downloadyearforest();"" class=""btn btn-success"" style=""float:right; padding:3px 6px; border-radius:0px; font-size:14px;"">导出EXCEL</button>
</div>
<table class=""table"" id=""recordyearforest"">
    <thead>
        <tr>
            <th style=""width:4%;"">序号</th>
            <th style=""width:4%;"">年份</th>
            <th style=""width:5%;"">总发生面积(万公顷次)</th>
            <th style=""width:5%;"">总防治面积(万公顷次)</th>
            <th style=""width:5%;"">总防治率(%)</th>
            <th style=""width:5%;"">病害发生面积(公顷)</th>
            <th style=""width:5%;"">病害防治面积(公顷)</th>
            <th style=""width:5%;"">病害防治率(%)</th>
            <th style=""width:5%;"">虫害发生面积(公顷)</th>
            <th style=""width:5%;"">虫害防治面积(公顷)</th>
            <th style=""width:5%;"">虫害防治率(%)</th>
            <th style=""width:5%;"">鼠害发生面积(公顷)</th>
            <th style=""width:5%;"">鼠害防治面积(公顷)</th>
            <th style=""width:5%;"">鼠害防治率(%)</th>
            <th style=""width:5%;"">有害植物发生面积(公顷)</th>
            <th style=""width:5%;"">有害植物防");
            WriteLiteral("治面积(公顷)</th>\r\n            <th style=\"width:5%;\">有害防治率(%)</th>\r\n            <th style=\"width:5%;\">经济损失(万元)</th>\r\n            <th style=\"width:8%;\">备注</th>\r\n            <th style=\"width:4%;\" class=\"noExl\">操作</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
          
            var i = 1;
            var count = 0;
            

#line default
#line hidden
#line 34 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
             foreach (var forestyear in ViewBag.forestyear)
            {

#line default
#line hidden
            BeginContext(1573, 63, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"t_center\">");
            EndContext();
            BeginContext(1637, 1, false);
#line 37 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                                    Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1638, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1670, 18, false);
#line 38 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbYears);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1720, 27, false);
#line 39 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbTotalOccurArea);

#line default
#line hidden
            EndContext();
            BeginContext(1747, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1779, 29, false);
#line 40 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbTotalControlArea);

#line default
#line hidden
            EndContext();
            BeginContext(1808, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1840, 29, false);
#line 41 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbTotalControlRate);

#line default
#line hidden
            EndContext();
            BeginContext(1869, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1901, 30, false);
#line 42 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbDiseasesOccurArea);

#line default
#line hidden
            EndContext();
            BeginContext(1931, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1963, 32, false);
#line 43 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbDiseasesControlArea);

#line default
#line hidden
            EndContext();
            BeginContext(1995, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2027, 32, false);
#line 44 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbDiseasesControlRate);

#line default
#line hidden
            EndContext();
            BeginContext(2059, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2091, 26, false);
#line 45 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbPestOccurArea);

#line default
#line hidden
            EndContext();
            BeginContext(2117, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2149, 28, false);
#line 46 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbPestControlArea);

#line default
#line hidden
            EndContext();
            BeginContext(2177, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2209, 28, false);
#line 47 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbPestControlRate);

#line default
#line hidden
            EndContext();
            BeginContext(2237, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2269, 27, false);
#line 48 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbMouseOccurArea);

#line default
#line hidden
            EndContext();
            BeginContext(2296, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2328, 29, false);
#line 49 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbMouseControlArea);

#line default
#line hidden
            EndContext();
            BeginContext(2357, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2389, 29, false);
#line 50 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbMouseControlRate);

#line default
#line hidden
            EndContext();
            BeginContext(2418, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2450, 32, false);
#line 51 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbHarmPlantsOccurArea);

#line default
#line hidden
            EndContext();
            BeginContext(2482, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2514, 34, false);
#line 52 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbHarmPlantsControlArea);

#line default
#line hidden
            EndContext();
            BeginContext(2548, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2580, 35, false);
#line 53 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbHarmlPlantsControlRate);

#line default
#line hidden
            EndContext();
            BeginContext(2615, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2647, 27, false);
#line 54 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                   Write(forestyear.fbEconomicLosses);

#line default
#line hidden
            EndContext();
            BeginContext(2674, 191, true);
            WriteLiteral("</td>\r\n                    <td class=\"newsInfo\" style=\"text-align:justify; text-align-last:left;\">\r\n                        <div class=\"newInfoTruncation newInfoTruncation3 boxId\" id=\"boxId\">");
            EndContext();
            BeginContext(2866, 64, false);
#line 56 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                                                                                      Write(Html.Raw(System.Net.WebUtility.UrlDecode(@forestyear.fbRemarks)));

#line default
#line hidden
            EndContext();
            BeginContext(2930, 38, true);
            WriteLiteral("</div>\r\n                        <span>");
            EndContext();
            BeginContext(2969, 64, false);
#line 57 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                         Write(Html.Raw(System.Net.WebUtility.UrlDecode(@forestyear.fbRemarks)));

#line default
#line hidden
            EndContext();
            BeginContext(3033, 100, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td class=\"noExl\">\r\n                        ");
            EndContext();
            BeginContext(3133, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb595d9094b428aba3952c0b4d4d111", async() => {
                BeginContext(3224, 2, true);
                WriteLiteral("编辑");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                                                                                       WriteLiteral(forestyear.ID);

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
            BeginContext(3230, 66, true);
            WriteLiteral("\r\n                        <span>—</span>\r\n                        ");
            EndContext();
            BeginContext(3296, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5111215bfef48cb9caf3c8e152ec58b", async() => {
                BeginContext(3389, 2, true);
                WriteLiteral("删除");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                                                                                         WriteLiteral(forestyear.ID);

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
            BeginContext(3395, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 65 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearForest.cshtml"
                i++;
                count = i - 1;
            }

#line default
#line hidden
            BeginContext(3552, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(3589, 511, true);
            WriteLiteral(@"<script>
    function downloadyearforest() {
        $("".boxId"").html("""");
        $.noConflict(); //请务必加上这一句，否则无法下载excel，因为$符号与其他jq版本冲突了
        $(""#recordyearforest"").table2excel({
            exclude: "".noExl"",
            name: new Date().getTime(),
            filename: new Date().getTime(),
            exclude_img: true,
            exclude_links: true,
            exclude_inputs: true
        });
        window.location.reload(); //强制刷新，因为 table2excel只执行一次，如果不刷新就不能再下载数据
    }
</script>");
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
