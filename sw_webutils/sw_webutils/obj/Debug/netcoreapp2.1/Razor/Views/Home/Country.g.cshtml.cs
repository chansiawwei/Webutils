#pragma checksum "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb08ab8e63ad13f384800b7d44ee40605ba0809"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Country), @"mvc.1.0.view", @"/Views/Home/Country.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Country.cshtml", typeof(AspNetCore.Views_Home_Country))]
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
#line 1 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\_ViewImports.cshtml"
using sw_webutils.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb08ab8e63ad13f384800b7d44ee40605ba0809", @"/Views/Home/Country.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aac0766cd53a5700f8cb6999787a547c2c4bd04f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Country : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CountryData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
  
    ViewData["Title"] = "Country";

#line default
#line hidden
            BeginContext(65, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(69, 679, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe594bfd8eac4d13bab87295e043583e", async() => {
                BeginContext(122, 20, true);
                WriteLiteral("\r\n    <br />\r\n\r\n    ");
                EndContext();
                BeginContext(142, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f825a5d97247dab60144895e769f3f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 11 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(202, 42, true);
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(244, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4aad7a4f7cb40f7861a8daab634b8ef", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 14 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CountryName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(312, 46, true);
                WriteLiteral("\r\n        <div class=\"col-md-5\">\r\n            ");
                EndContext();
                BeginContext(358, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "26fe1b179b7e449e93aed5a177e4170d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 16 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CountryName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(410, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(424, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2679ce88fc1b40598eb10c7a85493df9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 17 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CountryName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(490, 251, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-5\">\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Search Country Info\" />\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(748, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 31 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
 if (@Model?.Capital != null)
{


#line default
#line hidden
            BeginContext(790, 36, true);
            WriteLiteral("    <br />\r\n    <br />\r\n    <hr />\r\n");
            EndContext();
            BeginContext(828, 82, true);
            WriteLiteral("    <p>\r\n        <iframe width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\"");
            EndContext();
            BeginWriteAttribute("src", "\r\n                src=\"", 910, "\"", 1052, 4);
            WriteAttributeValue("", 933, "https://www.google.com/maps/embed/v1/place?q=", 933, 45, true);
#line 40 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
WriteAttributeValue("", 978, Model?.CountryName, 978, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 997, "&key=AIzaSyDRXiFKs4KA0-2PHFdOIKkrYLuwrDYPYYI", 997, 44, true);
            WriteAttributeValue("\r\n\r\n\r\n     ", 1041, "", 1052, 11, true);
            EndWriteAttribute();
            BeginContext(1053, 38, true);
            WriteLiteral(" allowfullscreen></iframe>\r\n    </p>\r\n");
            EndContext();
            BeginContext(1093, 74, true);
            WriteLiteral("    <ul class=\"list-group\">\r\n        <li class=\"list-group-item\">Country: ");
            EndContext();
            BeginContext(1168, 17, false);
#line 47 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                        Write(Model.CountryName);

#line default
#line hidden
            EndContext();
            BeginContext(1185, 52, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Capital: ");
            EndContext();
            BeginContext(1238, 13, false);
#line 48 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                        Write(Model.Capital);

#line default
#line hidden
            EndContext();
            BeginContext(1251, 49, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Area: ");
            EndContext();
            BeginContext(1301, 10, false);
#line 49 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                     Write(Model.Area);

#line default
#line hidden
            EndContext();
            BeginContext(1311, 55, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Population: ");
            EndContext();
            BeginContext(1367, 16, false);
#line 50 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                           Write(Model.Population);

#line default
#line hidden
            EndContext();
            BeginContext(1383, 53, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Currency: ");
            EndContext();
            BeginContext(1437, 18, false);
#line 51 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
                                         Write(Model.CurrencyCode);

#line default
#line hidden
            EndContext();
            BeginContext(1455, 19, true);
            WriteLiteral("</li>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1474, "\"", 1494, 1);
#line 52 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
WriteAttributeValue("", 1480, Model.FalgUrl, 1480, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1495, "\"", 1519, 1);
#line 52 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"
WriteAttributeValue("", 1501, Model.CountryName, 1501, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1520, 45, true);
            WriteLiteral(" width=\"200px\" height=\"200px\" />\r\n    </ul>\r\n");
            EndContext();
#line 54 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"


}
else
{
    if (@Model?.CountryName != null)
    {


#line default
#line hidden
            BeginContext(1628, 107, true);
            WriteLiteral("        <br />\r\n        <br />\r\n        <hr />\r\n        <div><h3>Please enter a valid country.</h3></div>\r\n");
            EndContext();
#line 66 "C:\Swinburne Y2 Sem1\OOP\Custom Project\Latest\sw_webutils_mvc\sw_webutils\sw_webutils\Views\Home\Country.cshtml"

    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountryData> Html { get; private set; }
    }
}
#pragma warning restore 1591