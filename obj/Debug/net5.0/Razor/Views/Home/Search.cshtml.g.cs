#pragma checksum "D:\GitP\Gymany\Views\Home\Search.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9b3fc9bb2a02ba7e4033ac8cef8fddca8073cafed31fbe99b4ee6aed140eee0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9b3fc9bb2a02ba7e4033ac8cef8fddca8073cafed31fbe99b4ee6aed140eee0b", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ad82fd099c5ebdb38242de6bf3268e417158293877eb9ddbb3e1fd1759c708e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.ListModels>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Product -->
<div class=""bg0 m-t-23 p-b-140"">
    <div class=""container"">
        <div class=""flex-w flex-sb-m p-b-52"">

            <div class=""flex-w flex-c-m m-tb-10"">
                <div class=""flex-c-m stext-106 cl6 size-104 bor4 pointer hov-btn3 trans-04 m-r-8 m-tb-4 js-show-filter"">
                    <i class=""icon-filter cl2 m-r-6 fs-15 trans-04 zmdi zmdi-filter-list""></i>
                    <i class=""icon-close-filter cl2 m-r-6 fs-15 trans-04 zmdi zmdi-close dis-none""></i>
                    Filter
                </div>

                <div class=""flex-c-m stext-106 cl6 size-105 bor4 pointer hov-btn3 trans-04 m-tb-4 js-show-search"">
                    <i class=""icon-search cl2 m-r-6 fs-15 trans-04 zmdi zmdi-search""></i>
                    <i class=""icon-close-search cl2 m-r-6 fs-15 trans-04 zmdi zmdi-close dis-none""></i>
                    Search
                </div>
            </div>

            <!-- Search product -->
            <div class=""dis-none panel-sear");
            WriteLiteral(@"ch w-full p-t-10 p-b-15"">
                <div class=""bor8 dis-flex p-l-15"">
                    <button class=""size-113 flex-c-m fs-16 cl2 hov-cl1 trans-04"">
                        <i class=""zmdi zmdi-search""></i>
                    </button>

                    <input class=""mtext-107 cl2 size-114 plh2 p-r-15"" type=""text"" name=""search-product""
                        placeholder=""Search"">
                </div>
            </div>

            <!-- Filter -->
            <div class=""dis-none panel-filter w-full p-t-10"">
                <div class=""wrap-filter flex-w bg6 w-full p-lr-40 p-t-27 p-lr-15-sm"">
                    <div class=""filter-col1 p-r-15 p-b-27"">
                        <div class=""mtext-102 cl2 p-b-15"">
                            Sort By
                        </div>

                        <ul>
                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04"">
                                    Def");
            WriteLiteral(@"ault
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04"">
                                    Popularity
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04"">
                                    Average rating
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04 filter-link-active"">
                                    Newness
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04"">
                      ");
            WriteLiteral(@"              Price: Low to High
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04"">
                                    Price: High to Low
                                </a>
                            </li>
                        </ul>
                    </div>

                    <div class=""filter-col2 p-r-15 p-b-27"">
                        <div class=""mtext-102 cl2 p-b-15"">
                            Price
                        </div>

                        <ul>
                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04 filter-link-active"">
                                    All
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                <a href=""#"" class=""filte");
            WriteLiteral(@"r-link stext-106 trans-04"">
                                    $0.00 - $50.00
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04"">
                                    $50.00 - $100.00
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04"">
                                    $100.00 - $150.00
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                <a href=""#"" class=""filter-link stext-106 trans-04"">
                                    $150.00 - $200.00
                                </a>
                            </li>

                            <li class=""p-b-6"">
                                ");
            WriteLiteral(@"<a href=""#"" class=""filter-link stext-106 trans-04"">
                                    $200.00+
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div style=""width: 100%; padding-bottom: 20px"">
            <h2 class=""text-center"" style=""color: #6c757d;"">Search Result</h2>
        </div>
");
#nullable restore
#line 129 "D:\GitP\Gymany\Views\Home\Search.cshtml"
         if (Model.Products.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-center\">\r\n                <p style=\"color: #dc3545;\">No product found</p>\r\n            </div>\r\n");
#nullable restore
#line 134 "D:\GitP\Gymany\Views\Home\Search.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row isotope-grid\">\r\n");
#nullable restore
#line 138 "D:\GitP\Gymany\Views\Home\Search.cshtml"
                 foreach (var item in Model.Products)
                {
                    string CateType = "";
                    foreach (var category in Model.Categories)
                    {
                        if (item.CategoryID == category.CategoryID)
                        {
                            CateType = category.Type;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 6284, "\"", 6348, 6);
            WriteAttributeValue("", 6292, "col-sm-6", 6292, 8, true);
            WriteAttributeValue(" ", 6300, "col-md-4", 6301, 9, true);
            WriteAttributeValue(" ", 6309, "col-lg-3", 6310, 9, true);
            WriteAttributeValue(" ", 6318, "p-b-35", 6319, 7, true);
            WriteAttributeValue(" ", 6325, "isotope-item", 6326, 13, true);
#nullable restore
#line 148 "D:\GitP\Gymany\Views\Home\Search.cshtml"
WriteAttributeValue(" ", 6338, CateType, 6339, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <!-- Block2 -->\r\n                        <div class=\"block2\">\r\n                            <div class=\"block2-pic hov-img0\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 6538, "\"", 6555, 1);
#nullable restore
#line 152 "D:\GitP\Gymany\Views\Home\Search.cshtml"
WriteAttributeValue("", 6544, item.Image, 6544, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""IMG-PRODUCT"">

                                <a href=""#""
                                    class=""block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1"">
                                    Quick View
                                </a>
                            </div>

                            <div class=""block2-txt flex-w flex-t p-t-14"">
                                <div class=""block2-txt-child1 flex-col-l "">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b3fc9bb2a02ba7e4033ac8cef8fddca8073cafed31fbe99b4ee6aed140eee0b12875", async() => {
                WriteLiteral("\r\n                                        ");
#nullable restore
#line 164 "D:\GitP\Gymany\Views\Home\Search.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 162 "D:\GitP\Gymany\Views\Home\Search.cshtml"
                                                                                       WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    <span class=\"stext-105 cl3\">\r\n                                        $");
#nullable restore
#line 168 "D:\GitP\Gymany\Views\Home\Search.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </span>
                                </div>
                                <div class=""block2-txt-child2 flex-r p-t-3"">
                                    <a href=""#"" class=""btn-addwish-b2 dis-block pos-relative js-addwish-b2"">
                                        <img class=""icon-heart1 dis-block trans-04"" src=""/images/icons/icon-heart-01.png""
                                            alt=""ICON"">
                                        <img class=""icon-heart2 dis-block trans-04 ab-t-l"" src=""/images/icons/icon-heart-02.png""
                                            alt=""ICON"">
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 182 "D:\GitP\Gymany\Views\Home\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <!-- Load more -->
            <div class=""flex-c-m flex-w w-full p-t-45"">
                <a href=""#"" class=""flex-c-m stext-101 cl5 size-103 bg2 bor1 hov-btn1 p-lr-15 trans-04"">
                    Load More
                </a>
            </div>
");
#nullable restore
#line 190 "D:\GitP\Gymany\Views\Home\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
