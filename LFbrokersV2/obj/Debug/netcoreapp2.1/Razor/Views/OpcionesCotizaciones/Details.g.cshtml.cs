#pragma checksum "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6086d75bb95234cbb47c59710ffab4bd9ee57ab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OpcionesCotizaciones_Details), @"mvc.1.0.view", @"/Views/OpcionesCotizaciones/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OpcionesCotizaciones/Details.cshtml", typeof(AspNetCore.Views_OpcionesCotizaciones_Details))]
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
#line 1 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\_ViewImports.cshtml"
using LFbrokersV2;

#line default
#line hidden
#line 2 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\_ViewImports.cshtml"
using LFbrokersV2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6086d75bb95234cbb47c59710ffab4bd9ee57ab2", @"/Views/OpcionesCotizaciones/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db46b690595120171e9aee37a0de77e3bad8e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_OpcionesCotizaciones_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LFbrokersV2.Models.OpcionesCotizacion>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 132, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>OpcionesCotizacion</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(224, 45, false);
#line 14 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(269, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(313, 41, false);
#line 17 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(354, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(398, 49, false);
#line 20 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(447, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(491, 45, false);
#line 23 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(536, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(580, 48, false);
#line 26 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 44, false);
#line 29 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(716, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(760, 49, false);
#line 32 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(853, 45, false);
#line 35 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(898, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(942, 47, false);
#line 38 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(989, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1033, 43, false);
#line 41 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1120, 47, false);
#line 44 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1211, 43, false);
#line 47 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1298, 47, false);
#line 50 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1389, 43, false);
#line 53 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1476, 45, false);
#line 56 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Condicion));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1565, 41, false);
#line 59 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Condicion));

#line default
#line hidden
            EndContext();
            BeginContext(1606, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1650, 47, false);
#line 62 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Aseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1741, 43, false);
#line 65 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.Aseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1828, 49, false);
#line 68 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OpcionElegida));

#line default
#line hidden
            EndContext();
            BeginContext(1877, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1921, 45, false);
#line 71 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.OpcionElegida));

#line default
#line hidden
            EndContext();
            BeginContext(1966, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2010, 52, false);
#line 74 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PolizaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2062, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2106, 55, false);
#line 77 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
       Write(Html.DisplayFor(model => model.PolizaNavigation.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2208, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "144e7c8a2669453fb52337bce97b4cc4", async() => {
                BeginContext(2254, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\Admin\Desktop\LFbrokersV2\LFbrokersV2\Views\OpcionesCotizaciones\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(2262, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2270, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26651ff7f6994661bb16b8387f526ef7", async() => {
                BeginContext(2292, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2308, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LFbrokersV2.Models.OpcionesCotizacion> Html { get; private set; }
    }
}
#pragma warning restore 1591
