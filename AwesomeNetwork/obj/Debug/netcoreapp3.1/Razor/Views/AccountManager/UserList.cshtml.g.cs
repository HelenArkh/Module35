#pragma checksum "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "370e3c8d5b67eabf8a4b32302f8c777731657784"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManager_UserList), @"mvc.1.0.view", @"/Views/AccountManager/UserList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"370e3c8d5b67eabf8a4b32302f8c777731657784", @"/Views/AccountManager/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b62a1a99802d290939197f49ff2b72aab62f401", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManager_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AwesomeNetwork.ViewModels.Account.SearchViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AccountManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFriend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"block-reg background-white\">\r\n\r\n");
#nullable restore
#line 6 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
     if (Model.UserList.Count != 0)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
         foreach (var user in @Model.UserList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <label>");
#nullable restore
#line 12 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
                  Write(user.GetFullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 13 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
                 if (!@user.IsFriendWithCurrent)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "370e3c8d5b67eabf8a4b32302f8c7777316577845622", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-sm btn-primary\">\r\n                            Добавить в друзья\r\n                        </button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
                                                                                   WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 22 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <label> Поиск не дал результатов.</label>\r\n        </div>\r\n");
#nullable restore
#line 29 "H:\Courses\C#\SKILLFACTORY C#\Projects\Module35_Project\Agile_DevelopDima\AwesomeNetwork\Views\AccountManager\UserList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AwesomeNetwork.ViewModels.Account.SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
