#pragma checksum "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c394acae20f5d25c760af7102601f3855ef1bed01ab63a25455983ee7ed0b8ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\_ViewImports.cshtml"
using Gymany;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\_ViewImports.cshtml"
using Gymany.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c394acae20f5d25c760af7102601f3855ef1bed01ab63a25455983ee7ed0b8ea", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ad82fd099c5ebdb38242de6bf3268e417158293877eb9ddbb3e1fd1759c708e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.ListModels>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wrap-search-header flex-w p-l-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #4CAF50; color: white; padding: 10px 20px; margin-top: 10px; border: none; cursor: pointer; border-radius: 5px; transition: background-color 0.3s; display: inline-block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg0 p-t-75 p-b-85"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animsition"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c394acae20f5d25c760af7102601f3855ef1bed01ab63a25455983ee7ed0b8ea5751", async() => {
                WriteLiteral(@"
    <title>Shoping Cart</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!--===============================================================================================-->
    <link rel=""icon"" type=""image/png"" href=""images/icons/favicon.png"" />
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""vendor/bootstrap/css/bootstrap.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""fonts/iconic/css/material-design-iconic-font.min.css"">
    <!--===========================================================================");
                WriteLiteral(@"====================-->
    <link rel=""stylesheet"" type=""text/css"" href=""fonts/linearicons-v1.0.0/icon-font.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""vendor/animate/animate.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""vendor/css-hamburgers/hamburgers.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""vendor/animsition/css/animsition.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""vendor/select2/select2.min.css"">
    <!--===============================================================================================-->
    <link rel=""s");
                WriteLiteral(@"tylesheet"" type=""text/css"" href=""vendor/perfect-scrollbar/perfect-scrollbar.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""css/Product/util.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/Product/main.css"">
    <!--===============================================================================================-->
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c394acae20f5d25c760af7102601f3855ef1bed01ab63a25455983ee7ed0b8ea9385", async() => {
                WriteLiteral(@"

    <!-- Modal Search -->
    <div class=""modal-search-header flex-c-m trans-04 js-hide-modal-search"">
        <div class=""container-search-header"">
            <button class=""flex-c-m btn-hide-modal-search trans-04 js-hide-modal-search"">
                <img src=""images/icons/icon-close2.png"" alt=""CLOSE"">
            </button>

            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c394acae20f5d25c760af7102601f3855ef1bed01ab63a25455983ee7ed0b8ea10028", async() => {
                    WriteLiteral("\r\n                <button class=\"flex-c-m trans-04\">\r\n                    <i class=\"zmdi zmdi-search\"></i>\r\n                </button>\r\n                <input class=\"plh3\" type=\"text\" name=\"search\" placeholder=\"Search...\">\r\n            ");
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
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <!-- Shoping Cart -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c394acae20f5d25c760af7102601f3855ef1bed01ab63a25455983ee7ed0b8ea11761", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 57 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
         if (Model.Carts == null || !Model.Carts.Any())
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <div style=\"text-align: center; margin-top: 50px; \">\r\n                <p style=\"font-size: 18px; color: #555;\">Không có mục nào trong giỏ hàng.</p>\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c394acae20f5d25c760af7102601f3855ef1bed01ab63a25455983ee7ed0b8ea12495", async() => {
                        WriteLiteral("\r\n                    Shopping now\r\n                ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 66 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"

        }
        else
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-10 col-xl-7 m-lr-auto m-b-50"">
                        <div class=""m-l-25 m-r--38 m-lr-0-xl"">
                            <div class=""wrap-table-shopping-cart"">
                                <table class=""table-shopping-cart"">
                                    <tr class=""table_head"">
                                        <th class=""column-1"">Product</th>
                                        <th class=""column-2""></th>
                                        <th class=""column-3"">Price</th>
                                        <th class=""column-4"">Quantity</th>
                                        <th class=""column-5"">Total</th>
                                    </tr>



");
#nullable restore
#line 86 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
                                     foreach (var item in Model.Carts)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                        <tr class=""table_row"">
                                            <td class=""column-1"">
                                                <div class=""how-itemcart1"">
                                                    <img");
                    BeginWriteAttribute("src", " src=\"", 5159, "\"", 5214, 1);
#nullable restore
#line 91 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5165, Html.DisplayFor(modelItem => item.Product.Image), 5165, 49, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" alt=""IMG"">
                                                </div>
                                            </td>
                                            <td class=""column-2"">

                                            </td>
                                            <td class=""column-3"">$ ");
#nullable restore
#line 97 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
                                                              Write(Html.DisplayFor(modelItem => item.Product.Price));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"</td>
                                            <td class=""column-4"">
                                                <div class=""wrap-num-product flex-w m-l-auto m-r-0"">
                                                    <div class=""btn-num-product-down cl8 hov-btn3 trans-04 flex-c-m"">
                                                        <i class=""fs-16 zmdi zmdi-minus""></i>
                                                    </div>
                                                    <input class=""mtext-104 cl3 txt-center num-product"" type=""number""
                                                        name=""num-product1""");
                    BeginWriteAttribute("value", " value=\"", 6215, "\"", 6237, 1);
#nullable restore
#line 104 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
WriteAttributeValue("", 6223, item.Quantity, 6223, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("\r\n                                                        data-price=\"");
#nullable restore
#line 105 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
                                                               Write(item.Product.Price);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@""">
                                                    <div class=""btn-num-product-up cl8 hov-btn3 trans-04 flex-c-m"">
                                                        <i class=""fs-16 zmdi zmdi-plus""></i>
                                                    </div>
                                                </div>
                                            </td>
                                            <td class=""column-5"">$ ");
#nullable restore
#line 111 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
                                                               Write(item.Quantity * item.Product.Price);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 113 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"


                                </table>
                            </div>
                        </div>
                    </div>

                    <div class=""col-sm-10 col-lg-7 col-xl-5 m-lr-auto m-b-50"">
                        <div class=""bor10 p-lr-40 p-t-30 p-b-40 m-l-63 m-r-40 m-lr-0-xl p-lr-15-sm"">
                            <h4 class=""mtext-109 cl2 p-b-30"">
                                Cart Totals
                            </h4>

                            <div id=""subtotal"" class=""flex-w flex-t bor12 p-b-13"">
                                <div class=""size-208"">
                                    <span class=""stext-110 cl2"">
                                        Subtotal:
                                    </span>
                                </div>

                                <div class=""size-209"">
                                    <span id=""subtotal-value"" class=""mtext-110 cl2"">
                                        $0.00
                  ");
                    WriteLiteral(@"                  </span>
                                </div>
                            </div>

                            <button class=""flex-c-m stext-101 cl0 size-116 bg3 bor14 hov-btn3 p-lr-15 trans-04 pointer"">
                                Proceed to Checkout
                            </button>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 149 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script>
        // Hàm xử lý sự kiện khi thay đổi số lượng
        function updateTotalPrice(input) {
            var quantity = parseInt(input.value); // Lấy giá trị mới của số lượng
            var price = parseFloat(input.dataset.price); // Lấy giá của sản phẩm từ thuộc tính data
            var totalPrice = quantity * price; // Tính toán tổng tiền

            // Cập nhật giá trị tổng tiền trong cột ""Total""
            var row = input.closest('.table_row');
            var totalCell = row.querySelector('.column-5');
            totalCell.textContent = '$ ' + totalPrice.toFixed(2); // Hiển thị tổng tiền với định dạng tiền tệ

            // Cập nhật lại Subtotal
            updateSubtotal();
        }

        // Lắng nghe sự kiện input trên tất cả các trường nhập số lượng và gọi hàm xử lý
        var quantityInputs = document.querySelectorAll('.num-product');
        quantityInputs.forEach(function (input) {
            input.addEventListener('input', function () {
         ");
                WriteLiteral(@"       updateTotalPrice(this); // Gọi hàm xử lý khi số lượng thay đổi
            });
        });
    </script>

    <script>
        // Hàm tính toán và cập nhật Subtotal
        function updateSubtotal() {
            var subtotal = 0;

            // Duyệt qua tất cả các hàng trong giỏ hàng
            var rows = document.querySelectorAll('.table_row');
            rows.forEach(function (row) {
                // Lấy giá trị Total từ cột cuối cùng
                var totalCell = row.querySelector('.column-5');
                var total = parseFloat(totalCell.textContent.replace('$', ''));
                subtotal += total; // Cộng vào Subtotal
            });

            // Cập nhật giá trị Subtotal
            var subtotalElement = document.getElementById('subtotal-value');
            subtotalElement.textContent = '$' + subtotal.toFixed(2); // Hiển thị với định dạng tiền tệ
        }

        // Gọi hàm cập nhật Subtotal khi trang được tải
        document.addEventListener('DOMC");
                WriteLiteral(@"ontentLoaded', function () {
            updateSubtotal();
        });
    </script>



    <!--===============================================================================================-->
    <script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
    <!--===============================================================================================-->
    <script src=""vendor/animsition/js/animsition.min.js""></script>
    <!--===============================================================================================-->
    <script src=""vendor/bootstrap/js/popper.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
    <!--===============================================================================================-->
    <script src=""vendor/select2/select2.min.js""></script>
    <script>
        $("".js-select2"").each(function () {
            $(this).select2({
                minimumResultsForSearch: 20,
                dropdownParent: $(this).next('");
                WriteLiteral(@".dropDownSelect2')
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
                scrollingThreshold: 1000,
                wheelPropagation: false,
            });

            $(window).on('resize', function () {
                ps.update();
            })
        });
    </script>
    <!--===============================================================================================-->
    <scrip");
                WriteLiteral("t src=\"js/Product/main.js\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
#nullable restore
#line 247 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
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
