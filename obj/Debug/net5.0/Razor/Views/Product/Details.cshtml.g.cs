#pragma checksum "D:\Gymany\Views\Product\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef92", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1ad82fd099c5ebdb38242de6bf3268e417158293877eb9ddbb3e1fd1759c708e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.ListModels>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef923450", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Details</title>
    <!--===============================================================================================-->	
	<link rel=""icon"" type=""image/png"" href=""images/icons/favicon.png""/>
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/bootstrap/css/bootstrap.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/fonts/iconic/css/material-design-iconic-font.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/f");
                WriteLiteral(@"onts/linearicons-v1.0.0/icon-font.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/animate/animate.css"">
<!--===============================================================================================-->	
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/css-hamburgers/hamburgers.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/animsition/css/animsition.min.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/select2/select2.min.css"">
<!--===============================================================================================-->	
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/daterangepicker/daterangepicker.css"">
<!--====================");
                WriteLiteral(@"===========================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/slick/slick.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/MagnificPopup/magnific-popup.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/vendor/perfect-scrollbar/perfect-scrollbar.css"">
<!--===============================================================================================-->
	<link rel=""stylesheet"" type=""text/css"" href=""/css/Product/util.css"">
	<link rel=""stylesheet"" type=""text/css"" href=""/css/Product/main.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef927445", async() => {
                WriteLiteral(@"
<div class=""wrap-modal1 js-modal1 p-t-60 p-b-20 show-js-modal1"">
		<div class=""container"">
			<div class=""bg0 p-t-60 p-b-30 p-lr-15-lg how-pos3-parent"">
				<div class=""row"">
					<div class=""col-md-6 col-lg-7 p-b-30"">
						<div class=""p-l-25 p-r-30 p-lr-0-lg"">
							<div class=""wrap-slick3 flex-sb flex-w"">
								<div class=""wrap-slick3-dots""></div>
								<div class=""wrap-slick3-arrows flex-sb-m flex-w""></div>

								<div class=""slick3 gallery-lb"">
									<div class=""item-slick3"" data-thumb=""/images/Product/whey1.jpg"">
										<div class=""wrap-pic-w pos-relative"">
											<img src=""/images/Product/whey1.jpg"" alt=""IMG-PRODUCT"">

											<a class=""flex-c-m size-108 how-pos1 bor0 fs-16 cl10 bg0 hov-btn3 trans-04"" href=""/images/Product/whey1.jpg"">
												<i class=""fa fa-expand""></i>
											</a>
										</div>
									</div>

									<div class=""item-slick3"" data-thumb=""/images/Product/whey2.jpg"">
										<div class=""wrap-pic-w pos-relative"">
											<im");
                WriteLiteral(@"g src=""/images/Product/whey2.jpg"" alt=""IMG-PRODUCT"">

											<a class=""flex-c-m size-108 how-pos1 bor0 fs-16 cl10 bg0 hov-btn3 trans-04"" href=""/images/Product/whey2.jpg"">
												<i class=""fa fa-expand""></i>
											</a>
										</div>
									</div>

									<div class=""item-slick3"" data-thumb=""/images/Product/whey3.jpg"">
										<div class=""wrap-pic-w pos-relative"">
											<img src=""/images/Product/whey3.jpg"" alt=""IMG-PRODUCT"">

											<a class=""flex-c-m size-108 how-pos1 bor0 fs-16 cl10 bg0 hov-btn3 trans-04"" href=""/images/Product/whey3.jpg"">
												<i class=""fa fa-expand""></i>
											</a>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					
					<div class=""col-md-6 col-lg-5 p-b-30"">
						<div class=""p-r-50 p-t-5 p-lr-0-lg"">
							<h4 class=""mtext-105 cl2 js-name-detail p-b-14"">
								");
#nullable restore
#line 87 "D:\Gymany\Views\Product\Details.cshtml"
   Write(Model.product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</h4>\r\n\r\n\t\t\t\t\t\t\t<span class=\"mtext-106 cl2\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 91 "D:\Gymany\Views\Product\Details.cshtml"
   Write(Model.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t<p class=\"stext-102 cl3 p-t-23\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 95 "D:\Gymany\Views\Product\Details.cshtml"
   Write(Model.product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
							</p>
							
							<!--  -->
							<div class=""p-t-33"">
								<div class=""flex-w flex-r-m p-b-10"">
									<div class=""size-203 flex-c-m respon6"">
										Size
									</div>

									<div class=""size-204 respon6-next"">
										<div class=""rs1-select2 bor8 bg0"">
											<select class=""js-select2"" name=""time"">
												");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9210896", async() => {
                    WriteLiteral("Choose an option");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9211969", async() => {
                    WriteLiteral("Size S");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9213032", async() => {
                    WriteLiteral("Size M");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9214095", async() => {
                    WriteLiteral("Size L");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9215158", async() => {
                    WriteLiteral("Size XL");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
											</select>
											<div class=""dropDownSelect2""></div>
										</div>
									</div>
								</div>

								<div class=""flex-w flex-r-m p-b-10"">
									<div class=""size-203 flex-c-m respon6"">
										Color
									</div>

									<div class=""size-204 respon6-next"">
										<div class=""rs1-select2 bor8 bg0"">
											<select class=""js-select2"" name=""time"">
												");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9216622", async() => {
                    WriteLiteral("Choose an option");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9217695", async() => {
                    WriteLiteral("Red");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9218755", async() => {
                    WriteLiteral("Blue");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9219816", async() => {
                    WriteLiteral("White");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13c7b37f86b82f04370f0dab058880cf17f0c1df9cfcf4d6e28916ce5b48ef9220878", async() => {
                    WriteLiteral("Grey");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
											</select>
											<div class=""dropDownSelect2""></div>
										</div>
									</div>
								</div>

								<div class=""flex-w flex-r-m p-b-10"">
									<div class=""size-204 flex-w flex-m respon6-next"">
										<div class=""wrap-num-product flex-w m-r-20 m-tb-10"">
											<div class=""btn-num-product-down cl8 hov-btn3 trans-04 flex-c-m"">
												<i class=""fs-16 zmdi zmdi-minus""></i>
											</div>

											<input class=""mtext-104 cl3 txt-center num-product"" type=""number"" name=""num-product"" value=""1"">

											<div class=""btn-num-product-up cl8 hov-btn3 trans-04 flex-c-m"">
												<i class=""fs-16 zmdi zmdi-plus""></i>
											</div>
										</div>

										<button class=""flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04 js-addcart-detail"">
											Add to cart
										</button>
									</div>
								</div>	
							</div>

							<!--  -->
							<div class=""flex-w flex-m p-l-100 p-t-40 respon7"">
								<div class");
                WriteLiteral(@"=""flex-m bor9 p-r-10 m-r-11"">
									<a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 js-addwish-detail tooltip100"" data-tooltip=""Add to Wishlist"">
										<i class=""zmdi zmdi-favorite""></i>
									</a>
								</div>

								<a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 m-r-8 tooltip100"" data-tooltip=""Facebook"">
									<i class=""fa fa-facebook""></i>
								</a>

								<a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 m-r-8 tooltip100"" data-tooltip=""Twitter"">
									<i class=""fa fa-twitter""></i>
								</a>

								<a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 m-r-8 tooltip100"" data-tooltip=""Google Plus"">
									<i class=""fa fa-google-plus""></i>
								</a>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
    <!--===============================================================================================-->	
	<script src=""/vendor/jquery/jquery-3.2.1.min.js""></scri");
                WriteLiteral(@"pt>
<!--===============================================================================================-->
	<script src=""/vendor/animsition/js/animsition.min.js""></script>
<!--===============================================================================================-->
	<script src=""/vendor/bootstrap/js/popper.js""></script>
	<script src=""/vendor/bootstrap/js/bootstrap.min.js""></script>
<!--===============================================================================================-->
	<script src=""/vendor/select2/select2.min.js""></script>
	<script>
		$("".js-select2"").each(function(){
			$(this).select2({
				minimumResultsForSearch: 20,
				dropdownParent: $(this).next('.dropDownSelect2')
			});
		})
	</script>
<!--===============================================================================================-->
	<script src=""/vendor/daterangepicker/moment.min.js""></script>
	<script src=""/vendor/daterangepicker/daterangepicker.js""></script>
<!--======================================");
                WriteLiteral(@"=========================================================-->
	<script src=""/vendor/slick/slick.min.js""></script>
	<script src=""/js/Product/slick-custom.js""></script>
<!--===============================================================================================-->
	<script src=""/vendor/parallax100/parallax100.js""></script>
	<script>
        $('.parallax100').parallax100();
	</script>
<!--===============================================================================================-->
	<script src=""/vendor/MagnificPopup/jquery.magnific-popup.min.js""></script>
	<script>
		$('.gallery-lb').each(function() { // the containers for all your galleries
			$(this).magnificPopup({
		        delegate: 'a', // the selector for gallery item
		        type: 'image',
		        gallery: {
		        	enabled:true
		        },
		        mainClass: 'mfp-fade'
		    });
		});
	</script>
<!--===============================================================================================-->
	<script src=");
                WriteLiteral(@"""/vendor/isotope/isotope.pkgd.min.js""></script>
<!--===============================================================================================-->
	<script src=""/vendor/sweetalert/sweetalert.min.js""></script>
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

				$(this).addClass('js-addedwish-detail');
				$(this).off('click');
			});
		});

		/*---------------------------------------------*/

		$('.js-addcart");
                WriteLiteral(@"-detail').each(function(){
			var nameProduct = $(this).parent().parent().parent().parent().find('.js-name-detail').html();
			$(this).on('click', function(){
				swal(nameProduct, ""is added to cart !"", ""success"");
			});
		});
	
	</script>
<!--===============================================================================================-->
	<script src=""/vendor/perfect-scrollbar/perfect-scrollbar.min.js""></script>
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
	<script src=""/js/Product/main.js""></script>
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
            WriteLiteral("\r\n</html>\r\n");
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
