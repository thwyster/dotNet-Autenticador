#pragma checksum "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6537c03c92f3bf19eeb3b78f9d6cf115f4e7e2b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/Index.cshtml", typeof(AspNetCore.Views_Consent_Index))]
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
#line 1 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6537c03c92f3bf19eeb3b78f9d6cf115f4e7e2b9", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0d56f10e64312f91a242e1ecb3f3662ecddcc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ScopeListItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-scopecheck"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("consent-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 98, true);
            WriteLiteral("\r\n<div class=\"page-consent\">\r\n    <div class=\"row page-header\">\r\n        <div class=\"col-sm-10\">\r\n");
            EndContext();
#line 6 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
             if (Model.ClientLogoUrl != null)
            {

#line default
#line hidden
            BeginContext(185, 41, true);
            WriteLiteral("            <div class=\"client-logo\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 226, "\"", 252, 1);
#line 8 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
WriteAttributeValue("", 232, Model.ClientLogoUrl, 232, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(253, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 9 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(277, 34, true);
            WriteLiteral("            <h1>\r\n                ");
            EndContext();
            BeginContext(312, 16, false);
#line 11 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
           Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(328, 180, true);
            WriteLiteral("\r\n                <small>is requesting your permission</small>\r\n            </h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(508, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6537c03c92f3bf19eeb3b78f9d6cf115f4e7e2b97040", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(545, 16, true);
            WriteLiteral("\r\n\r\n            ");
            EndContext();
            BeginContext(561, 2504, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6537c03c92f3bf19eeb3b78f9d6cf115f4e7e2b98313", async() => {
                BeginContext(607, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(625, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6537c03c92f3bf19eeb3b78f9d6cf115f4e7e2b98711", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 22 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

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
                BeginContext(668, 84, true);
                WriteLiteral("\r\n\r\n                <div>Uncheck the permissions you do not wish to grant.</div>\r\n\r\n");
                EndContext();
#line 26 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                 if (Model.IdentityScopes.Any())
                {

#line default
#line hidden
                BeginContext(821, 307, true);
                WriteLiteral(@"                <div class=""panel panel-default consent-buttons"">
                    <div class=""panel-heading"">
                        <span class=""glyphicon glyphicon-user""></span>
                        Personal Information
                    </div>
                    <ul class=""list-group"">
");
                EndContext();
#line 34 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                         foreach (var scope in Model.IdentityScopes)
                            {

#line default
#line hidden
                BeginContext(1229, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1253, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6537c03c92f3bf19eeb3b78f9d6cf115f4e7e2b911603", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 36 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1301, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(1334, 51, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n");
                EndContext();
#line 40 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(1404, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 42 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                 if (Model.ResourceScopes.Any())
                {

#line default
#line hidden
                BeginContext(1475, 290, true);
                WriteLiteral(@"                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <span class=""glyphicon glyphicon-tasks""></span>
                        Application Access
                    </div>
                    <ul class=""list-group"">
");
                EndContext();
#line 50 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                         foreach (var scope in Model.ResourceScopes)
                            {

#line default
#line hidden
                BeginContext(1866, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1890, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6537c03c92f3bf19eeb3b78f9d6cf115f4e7e2b914899", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 52 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = scope;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1937, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(1970, 51, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n");
                EndContext();
#line 56 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2040, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 58 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                 if (Model.AllowRememberConsent)
                {

#line default
#line hidden
                BeginContext(2111, 101, true);
                WriteLiteral("                <div class=\"consent-remember\">\r\n                    <label>\r\n                        ");
                EndContext();
                BeginContext(2212, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6537c03c92f3bf19eeb3b78f9d6cf115f4e7e2b917642", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 62 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RememberConsent);

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
                BeginContext(2274, 119, true);
                WriteLiteral("\r\n                        <strong>Remember My Decision</strong>\r\n                    </label>\r\n                </div>\r\n");
                EndContext();
#line 66 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2412, 250, true);
                WriteLiteral("\r\n                <div class=\"consent-buttons\">\r\n                    <button name=\"button\" value=\"yes\" class=\"btn btn-primary\" autofocus>Yes, Allow</button>\r\n                    <button name=\"button\" value=\"no\" class=\"btn\">No, Do Not Allow</button>\r\n");
                EndContext();
#line 71 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                     if (Model.ClientUrl != null)
                    {

#line default
#line hidden
                BeginContext(2736, 73, true);
                WriteLiteral("                    <a class=\"pull-right btn btn-default\" target=\"_blank\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2809, "\"", 2832, 1);
#line 73 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
WriteAttributeValue("", 2816, Model.ClientUrl, 2816, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2833, 112, true);
                WriteLiteral(">\r\n                        <span class=\"glyphicon glyphicon-info-sign\"></span>\r\n                        <strong>");
                EndContext();
                BeginContext(2946, 16, false);
#line 75 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                           Write(Model.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(2962, 37, true);
                WriteLiteral("</strong>\r\n                    </a>\r\n");
                EndContext();
#line 77 "C:\GIT\RONNY\dotNet-Autenticador\dotNet-Autenticador\Views\Consent\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3022, 36, true);
                WriteLiteral("                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
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
            BeginContext(3065, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
