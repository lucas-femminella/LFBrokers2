#pragma checksum "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5135e00269b1bc6c400e59c919e8ab9bfb6375b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Polizas_Index), @"mvc.1.0.view", @"/Views/Polizas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Polizas/Index.cshtml", typeof(AspNetCore.Views_Polizas_Index))]
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
#line 1 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\_ViewImports.cshtml"
using LFbrokersV2;

#line default
#line hidden
#line 2 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\_ViewImports.cshtml"
using LFbrokersV2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5135e00269b1bc6c400e59c919e8ab9bfb6375b9", @"/Views/Polizas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8db46b690595120171e9aee37a0de77e3bad8e5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Polizas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LFbrokersV2.Models.Poliza>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(119, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a802daf5b67482c845dd1a76e93ea45", async() => {
                BeginContext(142, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(156, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(249, 42, false);
#line 16 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(291, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(347, 50, false);
#line 19 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadCuotas));

#line default
#line hidden
            EndContext();
            BeginContext(397, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(453, 55, false);
#line 22 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductoAseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(508, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(564, 55, false);
#line 25 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RecargosFinancieros));

#line default
#line hidden
            EndContext();
            BeginContext(619, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(675, 45, false);
#line 28 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Impuestos));

#line default
#line hidden
            EndContext();
            BeginContext(720, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(776, 49, false);
#line 31 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(825, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(881, 45, false);
#line 34 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(926, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(982, 48, false);
#line 37 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1030, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1086, 49, false);
#line 40 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1191, 47, false);
#line 43 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1294, 47, false);
#line 46 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1397, 47, false);
#line 49 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1500, 49, false);
#line 52 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VigenciaDesde));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1605, 49, false);
#line 55 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VigenciaHasta));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1710, 45, false);
#line 58 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1811, 48, false);
#line 61 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1915, 54, false);
#line 64 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MotivoRecotizacion));

#line default
#line hidden
            EndContext();
            BeginContext(1969, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2025, 52, false);
#line 67 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AgenteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2077, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2133, 53, false);
#line 70 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ClienteNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2186, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 76 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2304, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2353, 41, false);
#line 79 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2394, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2450, 49, false);
#line 82 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadCuotas));

#line default
#line hidden
            EndContext();
            BeginContext(2499, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2555, 54, false);
#line 85 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductoAseguradora));

#line default
#line hidden
            EndContext();
            BeginContext(2609, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2665, 54, false);
#line 88 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RecargosFinancieros));

#line default
#line hidden
            EndContext();
            BeginContext(2719, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2775, 44, false);
#line 91 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Impuestos));

#line default
#line hidden
            EndContext();
            BeginContext(2819, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2875, 48, false);
#line 94 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SumaAsegurada));

#line default
#line hidden
            EndContext();
            BeginContext(2923, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2979, 44, false);
#line 97 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrimaBase));

#line default
#line hidden
            EndContext();
            BeginContext(3023, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3079, 47, false);
#line 100 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RecargoPrima));

#line default
#line hidden
            EndContext();
            BeginContext(3126, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3182, 48, false);
#line 103 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ComisionPrima));

#line default
#line hidden
            EndContext();
            BeginContext(3230, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3286, 46, false);
#line 106 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrimaPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(3332, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3388, 46, false);
#line 109 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PremioTotal));

#line default
#line hidden
            EndContext();
            BeginContext(3434, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3490, 46, false);
#line 112 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PremioCuota));

#line default
#line hidden
            EndContext();
            BeginContext(3536, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3592, 48, false);
#line 115 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VigenciaDesde));

#line default
#line hidden
            EndContext();
            BeginContext(3640, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3696, 48, false);
#line 118 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VigenciaHasta));

#line default
#line hidden
            EndContext();
            BeginContext(3744, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3800, 44, false);
#line 121 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(3844, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3900, 47, false);
#line 124 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumeroPoliza));

#line default
#line hidden
            EndContext();
            BeginContext(3947, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4003, 53, false);
#line 127 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MotivoRecotizacion));

#line default
#line hidden
            EndContext();
            BeginContext(4056, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4112, 61, false);
#line 130 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AgenteNavigation.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(4173, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4229, 62, false);
#line 133 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ClienteNavigation.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(4291, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(4346, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a61e1a53185b4500965030084c17e235", async() => {
                BeginContext(4391, 4, true);
                WriteLiteral("Edit");
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
#line 136 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
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
            BeginContext(4399, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4419, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc600892eca344aa9211c170bca19008", async() => {
                BeginContext(4467, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 137 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
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
            BeginContext(4478, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(4498, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "493d8bb3260a47918b2175a20cb52aac", async() => {
                BeginContext(4545, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 138 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
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
            BeginContext(4555, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 141 "C:\Users\Lucas Femminella\source\repos\LFbrokersV2\LFbrokersV2\Views\Polizas\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4594, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LFbrokersV2.Models.Poliza>> Html { get; private set; }
    }
}
#pragma warning restore 1591
