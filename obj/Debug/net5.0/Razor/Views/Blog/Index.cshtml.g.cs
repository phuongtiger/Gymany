#pragma checksum "D:\Gymany\Views\Blog\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e1f2a5d6a9b20a821174b60fffb20e1ab6824766b4e6ca934a19701ddb7cbdf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1f2a5d6a9b20a821174b60fffb20e1ab6824766b4e6ca934a19701ddb7cbdf2", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1ad82fd099c5ebdb38242de6bf3268e417158293877eb9ddbb3e1fd1759c708e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.ListModels>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wrap-search-header flex-w p-l-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
	<!-- Modal Search -->
	<div class=""modal-search-header flex-c-m trans-04 js-hide-modal-search"">
		<div class=""container-search-header"">
			<button class=""flex-c-m btn-hide-modal-search trans-04 js-hide-modal-search"">
				<img src=""images/icons/icon-close2.png"" alt=""CLOSE"">
			</button>

			");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1f2a5d6a9b20a821174b60fffb20e1ab6824766b4e6ca934a19701ddb7cbdf24086", async() => {
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
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t</header>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1f2a5d6a9b20a821174b60fffb20e1ab6824766b4e6ca934a19701ddb7cbdf25686", async() => {
                WriteLiteral(@"
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
						<!-- item blog -->
						<div class=""p-b-63"">
");
#nullable restore
#line 38 "D:\Gymany\Views\Blog\Index.cshtml"
        if (Model.Posts != null)
							{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Gymany\Views\Blog\Index.cshtml"
         foreach (var item in Model.Posts)
								{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t<a  class=\"hov-img0 how-pos5-parent\" href=\"javascript:void(0)\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1229, "\"", 1275, 3);
                WriteAttributeValue("", 1239, "redirectToBlogDetail(\'", 1239, 22, true);
#nullable restore
#line 42 "D:\Gymany\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1261, item.PostID, 1261, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1273, "\')", 1273, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 1293, "\"", 1310, 1);
#nullable restore
#line 43 "D:\Gymany\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1299, item.Image, 1299, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"IMG-BLOG\">\r\n\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t<div class=\"p-t-32\">\r\n\r\n\t\t\t\t\t\t\t\t\t\t<h4 class=\"p-b-15\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a class=\"ltext-108 cl2 hov-cl1 trans-04\" href=\"javascript:void(0)\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1486, "\"", 1532, 3);
                WriteAttributeValue("", 1496, "redirectToBlogDetail(\'", 1496, 22, true);
#nullable restore
#line 48 "D:\Gymany\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1518, item.PostID, 1518, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1530, "\')", 1530, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 49 "D:\Gymany\Views\Blog\Index.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t</h4>\r\n\r\n\t\t\t\t\t\t\t\t\t\t<p class=\"stext-117 cl6\">\r\n");
#nullable restore
#line 54 "D:\Gymany\Views\Blog\Index.cshtml"
            if (!string.IsNullOrEmpty(item.Content) && item.Content.Length > 200)
											{
												

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\Gymany\Views\Blog\Index.cshtml"
       Write(item.Content.Substring(0, 200));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <!-- Lấy 200 ký tự đầu tiên -->\r\n");
#nullable restore
#line 57 "D:\Gymany\Views\Blog\Index.cshtml"
											}
											else
											{
												

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Gymany\Views\Blog\Index.cshtml"
       Write(item.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <!-- Hiển thị toàn bộ nội dung nếu không vượt quá 200 ký tự -->\r\n");
#nullable restore
#line 61 "D:\Gymany\Views\Blog\Index.cshtml"
											}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"										</p>

										<div class=""flex-w flex-sb-m p-t-18"">
											<span class=""flex-w flex-m stext-111 cl2 p-r-30 m-tb-10"">
												<span>
													<span class=""cl4"">By</span> Admin
												</span>
											</span>

											<a class=""stext-101 cl2 hov-cl1 trans-04 m-tb-10"" href=""javascript:void(0)""");
                BeginWriteAttribute("onclick", " onclick=\"", 2292, "\"", 2338, 3);
                WriteAttributeValue("", 2302, "redirectToBlogDetail(\'", 2302, 22, true);
#nullable restore
#line 71 "D:\Gymany\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2324, item.PostID, 2324, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2336, "\')", 2336, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\tContinue Reading\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fa fa-long-arrow-right m-l-9\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 77 "D:\Gymany\Views\Blog\Index.cshtml"
								}

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\Gymany\Views\Blog\Index.cshtml"
         
							}
							else
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<p>Không có bài đăng nào.</p>\r\n");
#nullable restore
#line 82 "D:\Gymany\Views\Blog\Index.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"						</div>



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
										Fashion
									</a>");
                WriteLiteral(@"
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
										<img width=90 , height=""110"" , src=""images/Product/whey1");
                WriteLiteral(@".jpg"" alt=""PRODUCT"">
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
										<img width=90 , height=""110"" src=""images/Product/mass1");
                WriteLiteral(@".jpg"" alt=""PRODUCT"">
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
								</li>

								<li class=""p-b-7");
                WriteLiteral(@""">
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
									</a>
								</li>
");
                WriteLiteral(@"
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

								<a href=""#""
									");
                WriteLiteral(@"class=""flex-c-m stext-107 cl6 size-301 bor7 p-lr-15 hov-tag1 trans-04 m-r-5 m-b-5"">
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
<<<<<<< HEAD
<<<<<<<");
                BeginWriteAttribute("HEAD", " HEAD\r\n=", 9231, "", 9239, 0);
                EndWriteAttribute();
                WriteLiteral(@"======
>>>>>>> 4cc9f67f52084229977a45b5113b5ec7bb61abe2
	</section>



	<script>
    function redirectToBlogDetail(PostID) {
        $.ajax({
            type: ""POST"",
            url: ""/Blog/SavePostId"",
            data: { PostID: PostID },
            success: function(response) {
                window.location.href = ""/BlogDetail""; // Chuyển hướng đến BlogDetailController
            },
            error: function(xhr, status, error) {
                console.error(xhr.responseText);
            }
        });
    }
</script>

	<!--===============================================================================================-->
	<script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/animsition/js/animsition.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/boot");
                WriteLiteral(@"strap/js/popper.js""></script>
	<script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/select2/select2.min.js""></script>
	<script>
		$("".js-select2"").each(function () {
			$(this).select2({
				minimumResultsForSearch: 20,
				dropdownParent: $(this).next('.dropDownSelect2')
			});
		})
	</script>
	<!--===============================================================================================-->
	<script src=""vendor/MagnificPopup/jquery.magnific-popup.min.js""></script>
	<!--===============================================================================================-->
	<script src=""vendor/perfect-scrollbar/perfect-scrollbar.min.js""></script>
	<script>
		$('.js-pscroll').each(function () {
			$(this).css('position', 'relative');
			$(this).css('overflow', 'hidden');
			var ps = new PerfectScrollbar(this, {
				wheelSpeed: 1,
				scrollingThreshold: 1000,");
                WriteLiteral(@"
				wheelPropagation: false,
			});

			$(window).on('resize', function () {
				ps.update();
			})
		});
	</script>
	<!--===============================================================================================-->
	<script src=""js/Product/main.js""></script>
<<<<<<< HEAD

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n=======\r\n\t</section>\r\n>>>>>>> bebbc7c38c8041651d9e71ecb5120e5617201b89\r\n=======\r\n>>>>>>> 4cc9f67f52084229977a45b5113b5ec7bb61abe2\r\n\r\n");
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
