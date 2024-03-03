#pragma checksum "D:\GitP\Gymany\Views\Customer\Profile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18a10e440a8046def259d9cbd2382d69d5263787ea1ee40664ee2d566e054b71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Profile), @"mvc.1.0.view", @"/Views/Customer/Profile.cshtml")]
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
#nullable restore
#line 1 "D:\GitP\Gymany\Views\_ViewImports.cshtml"
using Gymany;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitP\Gymany\Views\_ViewImports.cshtml"
using Gymany.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"18a10e440a8046def259d9cbd2382d69d5263787ea1ee40664ee2d566e054b71", @"/Views/Customer/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ad82fd099c5ebdb38242de6bf3268e417158293877eb9ddbb3e1fd1759c708e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.ListModels>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\GitP\Gymany\Views\Customer\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <div class=""row"">
        <div class=""col-xl-4"">
            <!-- Profile picture card-->
            <div class=""card mb-4 mb-xl-0"">
                <div class=""card-header"">Profile Picture</div>
                <div class=""card-body text-center"">
                    <!-- Profile picture image-->
                    <img class=""img-account-profile rounded-circle mb-2"" src=""http://bootdey.com/img/Content/avatar/avatar1.png""");
            BeginWriteAttribute("alt", " alt=\"", 569, "\"", 575, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""margin-right: auto; margin-left: auto;"">
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
                <div class=""card-header"">Account Details</div>
                <div class=""card-body"">
                
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18a10e440a8046def259d9cbd2382d69d5263787ea1ee40664ee2d566e054b715929", async() => {
                WriteLiteral(@"
                        <!-- Form Group (username)-->
                        <div class=""mb-3"">
                            <label class=""small mb-1"">Name</label>                      
                            <input readonly class=""form-control"" id=""inputName"" type=""text"" placeholder=""Enter your username""");
                BeginWriteAttribute("value", " value=\"", 1575, "\"", 1630, 1);
#nullable restore
#line 33 "D:\GitP\Gymany\Views\Customer\Profile.cshtml"
WriteAttributeValue(" ", 1583, Html.DisplayFor(model => model.customer.Name), 1584, 46, false);

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
                BeginWriteAttribute("value", " value=\"", 1981, "\"", 2038, 1);
#nullable restore
#line 38 "D:\GitP\Gymany\Views\Customer\Profile.cshtml"
WriteAttributeValue("", 1989, Html.DisplayFor(model => model.customer.Address), 1989, 49, false);

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
                BeginWriteAttribute("value", " value=\"", 2441, "\"", 2470, 1);
#nullable restore
#line 44 "D:\GitP\Gymany\Views\Customer\Profile.cshtml"
WriteAttributeValue("", 2449, Model.customer.Email, 2449, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <!-- Form Row-->
                        <div class=""row gx-3 mb-3"">
                            <!-- Form Group (phone number)-->
                            <div class=""col-md-6"">
                                <label class=""small mb-1"" for=""inputPhone"">Phone number</label>
                                <input readonly class=""form-control"" id=""inputPhone"" type=""tel"" placeholder=""Enter your phone number""");
                BeginWriteAttribute("value", " value=\"", 2946, "\"", 3001, 1);
#nullable restore
#line 51 "D:\GitP\Gymany\Views\Customer\Profile.cshtml"
WriteAttributeValue("", 2954, Html.DisplayFor(model => model.customer.Phone), 2954, 47, false);

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
                BeginWriteAttribute("value", " value=\"", 3397, "\"", 3466, 1);
#nullable restore
#line 56 "D:\GitP\Gymany\Views\Customer\Profile.cshtml"
WriteAttributeValue("", 3405, Html.DisplayFor(model => model.customer.Age, "{MM/dd/yyyy}"), 3405, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                        <!-- Save changes button-->\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18a10e440a8046def259d9cbd2382d69d5263787ea1ee40664ee2d566e054b7110253", async() => {
                    WriteLiteral("Changes");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            WriteLiteral("                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gymany.Models.ListModels> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
