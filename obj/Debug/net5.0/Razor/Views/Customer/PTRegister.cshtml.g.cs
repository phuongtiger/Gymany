#pragma checksum "E:\SE1707_Ky5\Project\project_G\Gymany\Views\Customer\PTRegister.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8a0a7e44105ce96cf20a59702b6534b93b5f5d3d469e170b40a86d5e3ae49bd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_PTRegister), @"mvc.1.0.view", @"/Views/Customer/PTRegister.cshtml")]
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
#line 1 "E:\SE1707_Ky5\Project\project_G\Gymany\Views\_ViewImports.cshtml"
using Gymany;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SE1707_Ky5\Project\project_G\Gymany\Views\_ViewImports.cshtml"
using Gymany.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8a0a7e44105ce96cf20a59702b6534b93b5f5d3d469e170b40a86d5e3ae49bd5", @"/Views/Customer/PTRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ad82fd099c5ebdb38242de6bf3268e417158293877eb9ddbb3e1fd1759c708e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_PTRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PTRegister", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PTLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\SE1707_Ky5\Project\project_G\Gymany\Views\Customer\PTRegister.cshtml"
  
    ViewData["Title"] = "PTRegister";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    
</style>

<div class=""container"">
    <div class=""row justify-content-center"">
        <div class=""col-md-6"">
            <!-- Phần form -->
            <div class=""form-container"">
                <h1>PT REGISTER</h1>
                <div class=""row"">
                                        <div class=""col-md-4"">
                        <!-- Hình ảnh của người tập gym -->
                        <img src=""gym_image.jpg"" alt=""Gym Image"" class=""img-fluid"">
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a0a7e44105ce96cf20a59702b6534b93b5f5d3d469e170b40a86d5e3ae49bd55240", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""username"">Username:</label>
                        <input type=""text"" class=""form-control"" id=""username"" name=""username"">
                    </div>
                    <div class=""form-group"">
                        <label for=""password"">Password:</label>
                        <input type=""password"" class=""form-control"" id=""password"" name=""password"">
                    </div>
                    <div class=""form-group"">
                        <label for=""confirmPassword"">Confirm Password:</label>
                        <input type=""password"" class=""form-control"" id=""confirmPassword"" name=""confirmPassword"">
                    </div>
                    <div class=""form-group"">
                        <label for=""fullName"">Full Name:</label>
                        <input type=""text"" class=""form-control"" id=""Name"" name=""fullName"">
                    </div>
                    <div class=""form-group"">
  ");
                WriteLiteral(@"                      <label for=""address"">Address:</label>
                        <input type=""text"" class=""form-control"" id=""address"" name=""address"">
                    </div>
                    <div class=""form-group"">
                        <label for=""age"">Age:</label>
                        <input type=""text"" class=""form-control"" id=""age"" name=""age"">
                    </div>
                    <div class=""form-group"">
                        <label for=""phone"">Phone:</label>
                        <input type=""text"" class=""form-control"" id=""phone"" name=""phone"">
                    </div>
                    <div class=""form-group"">
                        <label for=""email"">Email:</label>
                        <input type=""email"" class=""form-control"" id=""email"" name=""email"">
                    </div>
                    <div class=""form-group"">
                        <label for=""certification"">Certification:</label>
                        <input type=""file"" class=""form-con");
                WriteLiteral("trol\" id=\"certification\" name=\"certification\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <button type=\"submit\" class=\"btn btn-primary\">REGISTER</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                \r\n                <hr>\r\n                <div class=\"text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a0a7e44105ce96cf20a59702b6534b93b5f5d3d469e170b40a86d5e3ae49bd59327", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
