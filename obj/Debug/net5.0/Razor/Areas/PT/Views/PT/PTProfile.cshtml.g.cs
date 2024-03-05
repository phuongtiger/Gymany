#pragma checksum "D:\Gymany\Areas\PT\Views\PT\PTProfile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02d6527e107da529020b79ca6a42c9945340c2dbcfb576998ee669bb94875f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PT_Views_PT_PTProfile), @"mvc.1.0.view", @"/Areas/PT/Views/PT/PTProfile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"02d6527e107da529020b79ca6a42c9945340c2dbcfb576998ee669bb94875f5f", @"/Areas/PT/Views/PT/PTProfile.cshtml")]
    #nullable restore
    public class Areas_PT_Views_PT_PTProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.PersonalTrainer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "PT", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteSession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Gymany\Areas\PT\Views\PT\PTProfile.cshtml"
  
    ViewData["Title"] = "PTProfile";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Gymany\Areas\PT\Views\PT\PTProfile.cshtml"
  
    Layout="PTLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"" style=""padding-top: 50px;"">
        <div class=""col-xl-4"">
            <!-- Profile picture card-->
            <div class=""card mb-4 mb-xl-0"">
                <div class=""card-header"" style=""background-color: #ff9500;color: white;"">Profile Picture</div>
                <div class=""card-body text-center"">
                    <!-- Profile picture image-->
                    <img class=""img-account-profile rounded-circle mb-2"" src=""http://bootdey.com/img/Content/avatar/avatar1.png""");
            BeginWriteAttribute("alt", " alt=\"", 677, "\"", 683, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""margin-left: auto; margin-right:auto;"">
                    <!-- Profile picture help block-->
                    <div class=""small font-italic text-muted mb-4"">JPG or PNG no larger than 5 MB</div>
                    <!-- Profile picture upload button-->
                    <button class=""btn btn-primary"" type=""button"">Upload new image</button>
                </div>
            </div>
        </div>
        <div class=""col-xl-8"">
            <!-- Account details card-->
            <div class=""card mb-4"">
                <div class=""card-header"" style=""background-color: #ff9500;color: white;"">Account Details</div>
                <div class=""card-body"">
                
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d6527e107da529020b79ca6a42c9945340c2dbcfb576998ee669bb94875f5f6025", async() => {
                WriteLiteral(@"
                        <!-- Form Group (username)-->
                        <div class=""mb-3"">
                            <label class=""small mb-1"">Name</label>                      
                            <input readonly class=""form-control"" id=""inputName"" type=""text"" placeholder=""Enter your username""");
                BeginWriteAttribute("value", " value=\"", 1730, "\"", 1776, 1);
#nullable restore
#line 34 "D:\Gymany\Areas\PT\Views\PT\PTProfile.cshtml"
WriteAttributeValue(" ", 1738, Html.DisplayFor(model => model.Name), 1739, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <!-- Form Group (Address)-->
                        <div class=""mb-3"">
                            <label class=""small mb-1"" for=""inputAddress"">Address</label>
                            <input readonly class=""form-control"" id=""inputAddress"" type=""text"" placeholder=""Enter your address""");
                BeginWriteAttribute("value", " value=\"", 2127, "\"", 2175, 1);
#nullable restore
#line 39 "D:\Gymany\Areas\PT\Views\PT\PTProfile.cshtml"
WriteAttributeValue("", 2135, Html.DisplayFor(model => model.Address), 2135, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" >
                        </div>
                    
                        <!-- Form Group (email address)-->
                        <div class=""mb-3"">
                            <label class=""small mb-1"" for=""inputEmailAddress"">Email address</label>
                            <input readonly class=""form-control"" id=""inputEmailAddress"" type=""email"" placeholder=""Enter your email address""");
                BeginWriteAttribute("value", " value=\"", 2578, "\"", 2598, 1);
#nullable restore
#line 45 "D:\Gymany\Areas\PT\Views\PT\PTProfile.cshtml"
WriteAttributeValue("", 2586, Model.Email, 2586, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <!-- Form Row-->
                        <div class=""row gx-3 mb-3"">
                            <!-- Form Group (salary)-->
                            <div class=""col-md-6"">
                                <label class=""small mb-1"" for=""salary"">Salary</label>
                                <input readonly class=""form-control"" id=""salary"" type=""tel"" placeholder=""Enter your phone number""");
                BeginWriteAttribute("value", " value=\"", 3054, "\"", 3101, 1);
#nullable restore
#line 52 "D:\Gymany\Areas\PT\Views\PT\PTProfile.cshtml"
WriteAttributeValue("", 3062, Html.DisplayFor(model => model.Salary), 3062, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                            <!-- Form Group (birthday)-->
                            <div class=""col-md-6"">
                                <label class=""small mb-1"" for=""inputBirthday"">Birthday</label>
                                <input readonly class=""form-control"" id=""inputBirthday"" type=""text"" name=""birthday"" placeholder=""Enter your birthday""");
                BeginWriteAttribute("value", " value=\"", 3497, "\"", 3557, 1);
#nullable restore
#line 57 "D:\Gymany\Areas\PT\Views\PT\PTProfile.cshtml"
WriteAttributeValue("", 3505, Html.DisplayFor(model => model.Age, "{MM/dd/yyyy}"), 3505, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <!-- LOGOUT btn-->\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d6527e107da529020b79ca6a42c9945340c2dbcfb576998ee669bb94875f5f10276", async() => {
                    WriteLiteral("LOGOUT");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02d6527e107da529020b79ca6a42c9945340c2dbcfb576998ee669bb94875f5f13003", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gymany.Models.PersonalTrainer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
