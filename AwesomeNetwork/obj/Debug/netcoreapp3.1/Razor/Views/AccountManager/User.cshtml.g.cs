#pragma checksum "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a11e7a29ad4db8ba17ba694992897f28ca46e77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManager_User), @"mvc.1.0.view", @"/Views/AccountManager/User.cshtml")]
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
#nullable restore
#line 1 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\_ViewImports.cshtml"
using AwesomeNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\_ViewImports.cshtml"
using AwesomeNetwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a11e7a29ad4db8ba17ba694992897f28ca46e77", @"/Views/AccountManager/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b62a1a99802d290939197f49ff2b72aab62f401", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManager_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AwesomeNetwork.ViewModels.Account.UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccountManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFriend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"block-reg background-white\">\r\n\r\n    <h4 class=\"center\">");
#nullable restore
#line 5 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                  Write(Model.User.GetFullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"main\">\r\n            <img class=\"main-img\"");
            BeginWriteAttribute("src", " src=\"", 246, "\"", 269, 1);
#nullable restore
#line 10 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
WriteAttributeValue("", 252, Model.User.Image, 252, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"center-align\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a11e7a29ad4db8ba17ba694992897f28ca46e776158", async() => {
                WriteLiteral("\r\n                    <input class=\"enter_submit\" type=\"submit\" value=\"??????????????????????????\" />\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"side\">\r\n            <div class=\"lined-block\">\r\n                <div>\r\n                    <label class=\"gray-text\">????????????:</label>\r\n                    <label> ");
#nullable restore
#line 23 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                       Write(Model.User.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div>\r\n                    <label class=\"gray-text\">???????? ????????????????:</label>\r\n                    <label> ");
#nullable restore
#line 28 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                       Write(Model.User.BirthDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div>\r\n                    <label class=\"gray-text\">?? ????????:</label>\r\n                    <label> ");
#nullable restore
#line 33 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                       Write(Model.User.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n\r\n                <div>\r\n                    <label class=\"gray-text\">Email:</label>\r\n                    <label> ");
#nullable restore
#line 38 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                       Write(Model.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"lined-block\" friendcontainer>\r\n                <label class=\"gray-text\">???????????? ????????????</label>\r\n\r\n                <div class=\"friendbox\">\r\n\r\n");
#nullable restore
#line 50 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                     if (Model.Friends.Count != 0)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                         foreach (var user in @Model.Friends)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"datadiv\">\r\n                                <div class=\"mrgn center-align\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1829, "\"", 1846, 1);
#nullable restore
#line 57 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
WriteAttributeValue("", 1835, user.Image, 1835, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ava\" />\r\n                                </div>\r\n                                <div class=\"mrgn center-align\">\r\n                                    ");
#nullable restore
#line 60 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                               Write(user.GetFullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"mrgn center-align\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a11e7a29ad4db8ba17ba694992897f28ca46e7712056", async() => {
                WriteLiteral("\r\n                                        <button type=\"submit\" class=\"btn btn-sm btn-primary min-width-but\">\r\n                                            ??????\r\n                                        </button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                                                                                              WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"mrgn center-align\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a11e7a29ad4db8ba17ba694992897f28ca46e7715377", async() => {
                WriteLiteral(@"
                                        <button type=""submit"" class=""btn btn-sm btn-primary min-width-but"">
                                            ?????????????? ???? ????????????
                                        </button>
                                    ");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                                                                                                      WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 77 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <label> ?? ?????? ???????? ?????? ????????????.</label>\r\n                        </div>\r\n");
#nullable restore
#line 84 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\User.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AwesomeNetwork.ViewModels.Account.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
