#pragma checksum "D:\Gymany\Views\Product\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9ac8d1d36abe459e13c00e7fbaa332d53a961423b897581098d003da2dbcfbf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Gymany\Views\Product\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Gymany\Views\Product\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9ac8d1d36abe459e13c00e7fbaa332d53a961423b897581098d003da2dbcfbf0", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1ad82fd099c5ebdb38242de6bf3268e417158293877eb9ddbb3e1fd1759c708e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.ListModels>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wrap-search-header flex-w p-l-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("stext-104 cl4 hov-cl1 trans-04 js-name-b2 p-b-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

	<header>
		<!-- Modal Search -->
		<div class=""modal-search-header flex-c-m trans-04 js-hide-modal-search"">
			<div class=""container-search-header"">
				<button class=""flex-c-m btn-hide-modal-search trans-04 js-hide-modal-search"">
					<img src=""images/icons/icon-close2.png"" alt=""CLOSE"">
				</button>

				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ac8d1d36abe459e13c00e7fbaa332d53a961423b897581098d003da2dbcfbf05391", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<button class=\"flex-c-m trans-04\">\r\n\t\t\t\t\t\t<i class=\"zmdi zmdi-search\"></i>\r\n\t\t\t\t\t</button>\r\n\t\t\t\t\t<input class=\"plh3\" type=\"text\" name=\"search\" placeholder=\"Search...\">\r\n\t\t\t\t");
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

	
	<!-- Product -->
	<div class=""container bg0 m-t-23 p-b-140"">
		<div>
			<div class=""flex-w flex-sb-m p-b-52"">
				<div class=""flex-w flex-l-m filter-tope-group m-tb-10"">
					<button class=""stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5 how-active1"" data-filter=""*"">
						All Products
					</button>
");
#nullable restore
#line 33 "D:\Gymany\Views\Product\Index.cshtml"
      foreach (var item in Model.Categories) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<button class=\"stext-106 cl6 hov1 bor3 trans-04 m-r-32 m-tb-5\" data-filter=\".");
#nullable restore
#line 34 "D:\Gymany\Views\Product\Index.cshtml"
                                                                              Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 35 "D:\Gymany\Views\Product\Index.cshtml"
  Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</button>\r\n");
#nullable restore
#line 37 "D:\Gymany\Views\Product\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				</div>

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
				<div class=""dis-none panel-search w-full p-t-10 p-b-15"">
					<div class=""bor8 dis-flex p-l-15"">
						<button class=""size-113 flex-c-m fs-16 cl2 hov-cl1 trans-04"">
							<i class=""zmdi zmdi-search""></i>
						</button>

						<input class=""mtext-107 cl2 size-114 plh2 p-r-15"" type=""text"" name=""");
            WriteLiteral(@"search-product"" placeholder=""Search"">
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
										Default
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
									<a href=""#"" class=""filter-link stext-1");
            WriteLiteral(@"06 trans-04"">
										Price: Low to High
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
									<a href=""#"" class=""filter-link stext-106 trans-04"">
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

								<li class=""p-b-6"">");
            WriteLiteral(@"
									<a href=""#"" class=""filter-link stext-106 trans-04"">
										$150.00 - $200.00
									</a>
								</li>

								<li class=""p-b-6"">
									<a href=""#"" class=""filter-link stext-106 trans-04"">
										$200.00+
									</a>
								</li>
							</ul>
						</div>
					</div>
				</div>
			</div>
			
			<div class=""row isotope-grid"">
");
#nullable restore
#line 160 "D:\Gymany\Views\Product\Index.cshtml"
     foreach (var item in Model.ListProducts) {
					string CateType = "";
					foreach (var category in Model.Categories) {
						if (item.CategoryID == category.CategoryID) {
							CateType = category.Type;
						}
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 4857, "\"", 4921, 6);
            WriteAttributeValue("", 4865, "col-sm-6", 4865, 8, true);
            WriteAttributeValue(" ", 4873, "col-md-4", 4874, 9, true);
            WriteAttributeValue(" ", 4882, "col-lg-3", 4883, 9, true);
            WriteAttributeValue(" ", 4891, "p-b-35", 4892, 7, true);
            WriteAttributeValue(" ", 4898, "isotope-item", 4899, 13, true);
#nullable restore
#line 167 "D:\Gymany\Views\Product\Index.cshtml"
WriteAttributeValue(" ", 4911, CateType, 4912, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t<!-- Block2 -->\r\n\t\t\t\t\t\t<div class=\"block2\">\r\n\t\t\t\t\t\t\t<div class=\"block2-pic hov-img0\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 5030, "\"", 5047, 1);
#nullable restore
#line 171 "D:\Gymany\Views\Product\Index.cshtml"
WriteAttributeValue("", 5036, item.Image, 5036, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""IMG-PRODUCT"">

								<a href=""#"" class=""block2-btn flex-c-m stext-103 cl2 size-102 bg0 bor2 hov-btn1 p-lr-15 trans-04 js-show-modal1"">
									Quick View
								</a>
							</div>

							<div class=""block2-txt flex-w flex-t p-t-14"">
								<div class=""block2-txt-child1 flex-col-l "">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ac8d1d36abe459e13c00e7fbaa332d53a961423b897581098d003da2dbcfbf013742", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 181 "D:\Gymany\Views\Product\Index.cshtml"
     Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 180 "D:\Gymany\Views\Product\Index.cshtml"
                                                            WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t\t\t<span class=\"stext-105 cl3\">\r\n\t\t\t\t\t\t\t\t\t\t$");
#nullable restore
#line 185 "D:\Gymany\Views\Product\Index.cshtml"
      Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									</span>
								</div>
								<div class=""block2-txt-child2 flex-r p-t-3"">
									<a href=""#"" class=""btn-addwish-b2 dis-block pos-relative js-addwish-b2"">
										<img class=""icon-heart1 dis-block trans-04"" src=""images/icons/icon-heart-01.png"" alt=""ICON"">
										<img class=""icon-heart2 dis-block trans-04 ab-t-l"" src=""images/icons/icon-heart-02.png"" alt=""ICON"">
									</a>
								</div>
							</div>
						</div>
					</div>
");
#nullable restore
#line 197 "D:\Gymany\Views\Product\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t\t<!-- Load more -->\r\n\t\t\t<div class=\"flex-c-m flex-w w-full p-t-45\">\r\n\t\t\t\t");
#nullable restore
#line 201 "D:\Gymany\Views\Product\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model.ListProducts, page => Url.Action("Index", new { page = page }),
					new X.PagedList.Web.Common.PagedListRenderOptionsBase
				{
					LiElementClasses = new string[] { "page-item" },
					PageClasses = new string[] { "page-link" }
				}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n\t<!-- Modal1 -->\r\n");
            WriteLiteral(@"<!--===============================================================================================-->	
	<script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/animsition/js/animsition.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/bootstrap/js/popper.js""></script>
	<script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/select2/select2.min.js""></script>
	<script>
		$("".js-select2"").each(function(){
			$(this).select2({
				minimumResultsForSearch: 20,
				dropdownParent: $(this).next('.dropDownSelect2')
			});
		})
	</script>
<!--===============================================================================================-->
	<script src=""vendo");
            WriteLiteral(@"r/daterangepicker/moment.min.js""></script>
	<script src=""vendor/daterangepicker/daterangepicker.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/slick/slick.min.js""></script>
	<script src=""js/Product/slick-custom.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/parallax100/parallax100.js""></script>
	<script>
        $('.parallax100').parallax100();
	</script>
<!--===============================================================================================-->
	<script src=""vendor/MagnificPopup/jquery.magnific-popup.min.js""></script>
	<script>
		$('.gallery-lb').each(function() { // the containers for all your galleries
			$(this).magnificPopup({
		        delegate: 'a', // the selector for gallery item
		        type: 'image',
		        gallery: {
		        	enabled:true
		        },
		        mainClass: 'mfp-fade");
            WriteLiteral(@"'
		    });
		});
	</script>
<!--===============================================================================================-->
	<script src=""vendor/isotope/isotope.pkgd.min.js""></script>
<!--===============================================================================================-->
	<script src=""vendor/sweetalert/sweetalert.min.js""></script>
	<script>
		$('.js-addwish-b2, .js-addwish-detail').on('click', function(e){
			e.preventDefault();
		});

		$('.js-addwish-b2').each(function(){
			var nameProduct = $(this).parent().parent().find('.js-name-b2').html();
			$(this).on('click', function(){
				swal(nameProduct, ""is added to wishlist !"", ""success"");

				$(this).addClass('js-addedwish-b2');
				$(this).off('click');
			});
		});

		$('.js-addwish-detail').each(function(){
			var nameProduct = $(this).parent().parent().parent().find('.js-name-detail').html();

			$(this).on('click', function(){
				swal(nameProduct, ""is added to wishlist !"", ""success"");

				$(this).a");
            WriteLiteral(@"ddClass('js-addedwish-detail');
				$(this).off('click');
			});
		});

		/*---------------------------------------------*/

		$('.js-addcart-detail').each(function(){
			var nameProduct = $(this).parent().parent().parent().parent().find('.js-name-detail').html();
			$(this).on('click', function(){
				swal(nameProduct, ""is added to cart !"", ""success"");
			});
		});
	
	</script>
<!--===============================================================================================-->
	<script src=""vendor/perfect-scrollbar/perfect-scrollbar.min.js""></script>
	<script>
		$('.js-pscroll').each(function(){
			$(this).css('position','relative');
			$(this).css('overflow','hidden');
			var ps = new PerfectScrollbar(this, {
				wheelSpeed: 1,
				scrollingThreshold: 1000,
				wheelPropagation: false,
			});

			$(window).on('resize', function(){
				ps.update();
			})
		});
	</script>
<!--===============================================================================================-->
	");
            WriteLiteral("<script src=\"js/Product/main.js\"></script>\r\n");
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
