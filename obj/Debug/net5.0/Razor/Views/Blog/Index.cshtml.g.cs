#pragma checksum "D:\Gymany\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "D:\Gymany\Views\_ViewImports.cshtml"
using Gymany;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Gymany\Views\_ViewImports.cshtml"
using Gymany.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83fd1c6784a19a4a90ccc00bb6bd0691a00ef57", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd2daf746351e1b25467b5be6f3116a2ee2c55df", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wrap-search-header flex-w p-l-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "blogdetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hov-img0 how-pos5-parent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ltext-108 cl2 hov-cl1 trans-04"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stext-101 cl2 hov-cl1 trans-04 m-tb-10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Gymany\Views\Blog\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	<!-- Modal Search -->
	<div class=""modal-search-header flex-c-m trans-04 js-hide-modal-search"">
		<div class=""container-search-header"">
			<button class=""flex-c-m btn-hide-modal-search trans-04 js-hide-modal-search"">
				<img src=""images/icons/icon-close2.png"" alt=""CLOSE"">
			</button>

			");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef575449", async() => {
                WriteLiteral("\r\n\t\t\t\t<button class=\"flex-c-m trans-04\">\r\n\t\t\t\t\t<i class=\"zmdi zmdi-search\"></i>\r\n\t\t\t\t</button>\r\n\t\t\t\t<input class=\"plh3\" type=\"text\" name=\"search\" placeholder=\"Search...\">\r\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
		</div>
	</div>
	</header>



	<!-- Title page -->
	<section class=""bg-img1 txt-center p-lr-15 p-tb-92"" style=""background-image: url('images/Blog/blogbanner.jpg');"">
		<h2 class=""ltext-105 cl0 txt-center"">
			Blog
		</h2>
	</section>


	<!-- Content page -->
	<section class=""container bg0 p-t-62 p-b-60"">
		<div>
			<div class=""row"">
				<div class=""col-md-8 col-lg-9 p-b-80"">
					<div class=""p-r-45 p-r-0-lg"">
						<!-- item blog 1 -->
						<div class=""p-b-63"">
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef577488", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<img src=\"images/Blog/blog1.jpg\" alt=\"IMG-BLOG\">\r\n\t\t\t\t\t\t\t");
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"p-t-32\">\r\n\t\t\t\t\t\t\t\t<h4 class=\"p-b-15\">\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef578909", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\tTHE BEST GYM WORKOUT PLAN FOR GAINING MUSCLE\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</h4>

								<p class=""stext-117 cl6"">
									Spencer Cartwright is a personal trainer at PureGym Bristol Brislington. Here, he
									shares his top advice for creating the perfect muscle-gaining workout routine.
								</p>

								<div class=""flex-w flex-sb-m p-t-18"">
									<span class=""flex-w flex-m stext-111 cl2 p-r-30 m-tb-10"">
										<span>
											<span class=""cl4"">By</span> Admin
										</span>
									</span>

									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef5710714", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\tContinue Reading\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-long-arrow-right m-l-9\"></i>\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<!-- item blog 2-->\r\n\t\t\t\t\t\t<div class=\"p-b-63\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef5712242", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<img src=\"images/Blog/blog2.jpg\" alt=\"IMG-BLOG\">\r\n\t\t\t\t\t\t\t");
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"p-t-32\">\r\n\t\t\t\t\t\t\t\t<h4 class=\"p-b-15\">\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef5713664", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\tCALORIES AND WEIGHT LOSS - WHAT YOU NEED TO KNOW\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</h4>

								<p class=""stext-117 cl6"">
									If you’re looking to lose weight, the huge number of diet plans and nutritional
									guidance available can seem overwhelming, with many competing ideas and eating
									styles on offer.
								</p>

								<div class=""flex-w flex-sb-m p-t-18"">
									<span class=""flex-w flex-m stext-111 cl2 p-r-30 m-tb-10"">
										<span>
											<span class=""cl4"">By</span> Admin
										</span>
									</span>

									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef5715499", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\tContinue Reading\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-long-arrow-right m-l-9\"></i>\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<!-- item blog 3 -->\r\n\t\t\t\t\t\t<div class=\"p-b-63\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef5717028", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<img src=\"images/Blog/blog3.jpg\" alt=\"IMG-BLOG\">\r\n\t\t\t\t\t\t\t");
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"p-t-32\">\r\n\t\t\t\t\t\t\t\t<h4 class=\"p-b-15\">\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef5718450", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t5 OF THE BEST BOXING WORKOUT ROUTINES FOR AT HOME AND THE GYM\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</h4>

								<p class=""stext-117 cl6"">
									Whether you’re wanting to take your boxing career to the next level, or simply
									looking for fun ways to get fit, boxing workouts are a great way to improve your
									strength, speed, and coordination.
								</p>

								<div class=""flex-w flex-sb-m p-t-18"">
									<span class=""flex-w flex-m stext-111 cl2 p-r-30 m-tb-10"">
										<span>
											<span class=""cl4"">By</span> Admin
										</span>
									</span>

									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e83fd1c6784a19a4a90ccc00bb6bd0691a00ef5720317", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\tContinue Reading\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-long-arrow-right m-l-9\"></i>\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
								</div>
							</div>
						</div>

						<!-- Pagination -->
						<div class=""flex-l-m flex-w w-full p-t-10 m-lr--7"">
							<a href=""#"" class=""flex-c-m how-pagination1 trans-04 m-all-7 active-pagination1"">
								1
							</a>

							<a href=""#"" class=""flex-c-m how-pagination1 trans-04 m-all-7"">
								2
							</a>
						</div>
					</div>
				</div>

				<div class=""col-md-4 col-lg-3 p-b-80"">
					<div class=""side-menu"">
						<div class=""bor17 of-hidden pos-relative"">
							<input class=""stext-103 cl2 plh4 size-116 p-l-28 p-r-55"" type=""text"" name=""search""
								placeholder=""Search"">

							<button class=""flex-c-m size-122 ab-t-r fs-18 cl4 hov-cl1 trans-04"">
								<i class=""zmdi zmdi-search""></i>
							</button>
						</div>

						<div class=""p-t-55"">
							<h4 class=""mtext-112 cl2 p-b-33"">
								Categories
							</h4>

							<ul>
								<li class=""bor18"">
									<a href=""#"" class=""dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4"">
			");
            WriteLiteral(@"							Fashion
									</a>
								</li>

								<li class=""bor18"">
									<a href=""#"" class=""dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4"">
										Beauty
									</a>
								</li>

								<li class=""bor18"">
									<a href=""#"" class=""dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4"">
										Street Style
									</a>
								</li>

								<li class=""bor18"">
									<a href=""#"" class=""dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4"">
										Life Style
									</a>
								</li>

								<li class=""bor18"">
									<a href=""#"" class=""dis-block stext-115 cl6 hov-cl1 trans-04 p-tb-8 p-lr-4"">
										DIY & Crafts
									</a>
								</li>
							</ul>
						</div>

						<div class=""p-t-65"">
							<h4 class=""mtext-112 cl2 p-b-33"">
								Featured Products
							</h4>

							<ul>
								<li class=""flex-w flex-t p-b-30"">
									<a href=""#"" class=""wrao-pic-w size-214 hov-ovelay1 m-r-20"">
										<img width=90 , height=""110");
            WriteLiteral(@""" , src=""images/Product/whey1.jpg"" alt=""PRODUCT"">
									</a>

									<div class=""size-215 flex-col-t p-t-8"">
										<a href=""#"" class=""stext-116 cl8 hov-cl1 trans-04"">
											White Shirt With Pleat Detail Back
										</a>

										<span class=""stext-116 cl6 p-t-20"">
											$19.00
										</span>
									</div>
								</li>

								<li class=""flex-w flex-t p-b-30"">
									<a href=""#"" class=""wrao-pic-w size-214 hov-ovelay1 m-r-20"">
										<img width=90 , height=""110"" src=""images/Product/acc1.jpg"" alt=""PRODUCT"">
									</a>

									<div class=""size-215 flex-col-t p-t-8"">
										<a href=""#"" class=""stext-116 cl8 hov-cl1 trans-04"">
											Converse All Star Hi Black Canvas
										</a>

										<span class=""stext-116 cl6 p-t-20"">
											$39.00
										</span>
									</div>
								</li>

								<li class=""flex-w flex-t p-b-30"">
									<a href=""#"" class=""wrao-pic-w size-214 hov-ovelay1 m-r-20"">
										<img width=90 , height=""1");
            WriteLiteral(@"10"" src=""images/Product/mass1.jpg"" alt=""PRODUCT"">
									</a>

									<div class=""size-215 flex-col-t p-t-8"">
										<a href=""#"" class=""stext-116 cl8 hov-cl1 trans-04"">
											Nixon Porter Leather Watch In Tan
										</a>

										<span class=""stext-116 cl6 p-t-20"">
											$17.00
										</span>
									</div>
								</li>
							</ul>
						</div>

						<div class=""p-t-55"">
							<h4 class=""mtext-112 cl2 p-b-20"">
								Archive
							</h4>

							<ul>
								<li class=""p-b-7"">
									<a href=""#"" class=""flex-w flex-sb-m stext-115 cl6 hov-cl1 trans-04 p-tb-2"">
										<span>
											July 2018
										</span>

										<span>
											(9)
										</span>
									</a>
								</li>

								<li class=""p-b-7"">
									<a href=""#"" class=""flex-w flex-sb-m stext-115 cl6 hov-cl1 trans-04 p-tb-2"">
										<span>
											June 2018
										</span>

										<span>
											(39)
										</span>
									</a>
								</li");
            WriteLiteral(@">

								<li class=""p-b-7"">
									<a href=""#"" class=""flex-w flex-sb-m stext-115 cl6 hov-cl1 trans-04 p-tb-2"">
										<span>
											May 2018
										</span>

										<span>
											(29)
										</span>
									</a>
								</li>

								<li class=""p-b-7"">
									<a href=""#"" class=""flex-w flex-sb-m stext-115 cl6 hov-cl1 trans-04 p-tb-2"">
										<span>
											April 2018
										</span>

										<span>
											(35)
										</span>
									</a>
								</li>

								<li class=""p-b-7"">
									<a href=""#"" class=""flex-w flex-sb-m stext-115 cl6 hov-cl1 trans-04 p-tb-2"">
										<span>
											March 2018
										</span>

										<span>
											(22)
										</span>
									</a>
								</li>

								<li class=""p-b-7"">
									<a href=""#"" class=""flex-w flex-sb-m stext-115 cl6 hov-cl1 trans-04 p-tb-2"">
										<span>
											February 2018
										</span>

										<span>
											(32)
										</span>
		");
            WriteLiteral(@"							</a>
								</li>

								<li class=""p-b-7"">
									<a href=""#"" class=""flex-w flex-sb-m stext-115 cl6 hov-cl1 trans-04 p-tb-2"">
										<span>
											January 2018
										</span>

										<span>
											(21)
										</span>
									</a>
								</li>

								<li class=""p-b-7"">
									<a href=""#"" class=""flex-w flex-sb-m stext-115 cl6 hov-cl1 trans-04 p-tb-2"">
										<span>
											December 2017
										</span>

										<span>
											(26)
										</span>
									</a>
								</li>
							</ul>
						</div>

						<div class=""p-t-50"">
							<h4 class=""mtext-112 cl2 p-b-27"">
								Tags
							</h4>

							<div class=""flex-w m-r--5"">
								<a href=""#""
									class=""flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5"">
									Fashion
								</a>

								<a href=""#""
									class=""flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5"">
									Lifestyle
								</a>

	");
            WriteLiteral(@"							<a href=""#""
									class=""flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5"">
									Denim
								</a>

								<a href=""#""
									class=""flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5"">
									Streetstyle
								</a>

								<a href=""#""
									class=""flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5"">
									Crafts
								</a>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
