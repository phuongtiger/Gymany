#pragma checksum "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a8f87d6750b4e32d9721d46abf1c9598ab0cb44f63f440728ffb598941ee511e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PT_Views_WorkOut_Delete), @"mvc.1.0.view", @"/Areas/PT/Views/WorkOut/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a8f87d6750b4e32d9721d46abf1c9598ab0cb44f63f440728ffb598941ee511e", @"/Areas/PT/Views/WorkOut/Delete.cshtml")]
    #nullable restore
    public class Areas_PT_Views_WorkOut_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.WorkoutPlan>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
  
    Layout = "PTLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-4 shadow-sm\">\r\n    <div class=\"card-header\">\r\n        <h2 class=\"my-0 font-weight-normal\">");
#nullable restore
#line 11 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <p class=\"card-text\">");
#nullable restore
#line 14 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                        Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <p><strong>Start Date:</strong> ");
#nullable restore
#line 17 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                           Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>End Date:</strong> ");
#nullable restore
#line 18 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Session:</strong> ");
#nullable restore
#line 19 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                        Write(Html.DisplayFor(model => model.Session));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <p><strong>Activity:</strong> ");
#nullable restore
#line 22 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.Activity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Member ID:</strong> ");
#nullable restore
#line 23 "E:\chuyên ngành kì 5\PRN211\project_group_5\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.MemberID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8f87d6750b4e32d9721d46abf1c9598ab0cb44f63f440728ffb598941ee511e6326", async() => {
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gymany.Models.WorkoutPlan> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
