#pragma checksum "D:\Gymany\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74318a2dae28545ae9ab012e3723119a867db4b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74318a2dae28545ae9ab012e3723119a867db4b0", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd2daf746351e1b25467b5be6f3116a2ee2c55df", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.ListModels>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wrap-search-header flex-w p-l-15"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #4CAF50; color: white; padding: 10px 20px; margin-top: 10px; border: none; cursor: pointer; border-radius: 5px; transition: background-color 0.3s; display: inline-block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-c-m stext-101 cl0 size-116 bg3 bor14 hov-btn3 p-lr-15 trans-04 pointer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg0 p-t-75 p-b-85"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("animsition"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74318a2dae28545ae9ab012e3723119a867db4b06186", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74318a2dae28545ae9ab012e3723119a867db4b09796", async() => {
                WriteLiteral(@"

    <!-- Modal Search -->
    <div class=""modal-search-header flex-c-m trans-04 js-hide-modal-search"">
        <div class=""container-search-header"">
            <button class=""flex-c-m btn-hide-modal-search trans-04 js-hide-modal-search"">
                <img src=""images/icons/icon-close2.png"" alt=""CLOSE"">
            </button>

            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74318a2dae28545ae9ab012e3723119a867db4b010415", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74318a2dae28545ae9ab012e3723119a867db4b012124", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Gymany\Views\Cart\Index.cshtml"
         if (Model.Carts == null || !Model.Carts.Any())
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <div style=\"text-align: center; margin-top: 50px; \">\r\n                <p style=\"font-size: 18px; color: #555;\">Không có mục nào trong giỏ hàng.</p>\r\n                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74318a2dae28545ae9ab012e3723119a867db4b012798", async() => {
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
#line 67 "D:\Gymany\Views\Cart\Index.cshtml"

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
                                        <th class=""column-3"">Price</th>
                                        <th class=""column-4"">Quantity</th>
                                        <th class=""column-5"">Total</th>
                                    </tr>



");
#nullable restore
#line 86 "D:\Gymany\Views\Cart\Index.cshtml"
                                     foreach (var item in Model.Carts)
                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                        <tr class=""table_row"">
                                            <td class=""column-1"">
                                                <div class=""how-itemcart1"">
                                                    <img");
                    BeginWriteAttribute("src", " src=\"", 5112, "\"", 5167, 1);
#nullable restore
#line 91 "D:\Gymany\Views\Cart\Index.cshtml"
WriteAttributeValue("", 5118, Html.DisplayFor(modelItem => item.Product.Image), 5118, 49, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" alt=\"IMG\">\r\n                                                </div>\r\n                                            </td>\r\n                                            <td class=\"column-3\">\r\n");
#nullable restore
#line 95 "D:\Gymany\Views\Cart\Index.cshtml"
                                                  
                                                    decimal price = (decimal)item.Product.Price;
                                                    string formattedAmount = price.ToString("C0");
                                                

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                ");
#nullable restore
#line 99 "D:\Gymany\Views\Cart\Index.cshtml"
                                           Write(formattedAmount);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" VND
                                            </td>
                                            <td class=""column-4"">
                                                <div class=""wrap-num-product flex-w m-l-auto m-r-0"">
                                                    <button type=""button""");
                    BeginWriteAttribute("value", " value=\"", 6019, "\"", 6039, 1);
#nullable restore
#line 103 "D:\Gymany\Views\Cart\Index.cshtml"
WriteAttributeValue("", 6027, item.CartID, 6027, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@"
                                                        onclick=""updateCartItemMinus(this, -1)""
                                                        class=""btn-num-product-down cl8 hov-btn3 trans-04 flex-c-m"">
                                                        <i class=""fs-16 zmdi zmdi-minus""></i>
                                                    </button>
                                                    <input class=""mtext-104 cl3 txt-center num-product"" type=""number""
                                                        name=""num-product1""");
                    BeginWriteAttribute("value", " value=\"", 6609, "\"", 6631, 1);
#nullable restore
#line 109 "D:\Gymany\Views\Cart\Index.cshtml"
WriteAttributeValue("", 6617, item.Quantity, 6617, 14, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("\r\n                                                        data-price=\"");
#nullable restore
#line 110 "D:\Gymany\Views\Cart\Index.cshtml"
                                                               Write(item.Product.Price);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\">\r\n                                                    <button type=\"button\"");
                    BeginWriteAttribute("value", " value=\"", 6798, "\"", 6818, 1);
#nullable restore
#line 111 "D:\Gymany\Views\Cart\Index.cshtml"
WriteAttributeValue("", 6806, item.CartID, 6806, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@"
                                                        onclick=""updateCartItemPlus(this, 1)""
                                                        class=""btn-num-product-up cl8 hov-btn3 trans-04 flex-c-m"">
                                                        <i class=""fs-16 zmdi zmdi-plus""></i>
                                                    </button>
                                                </div>
                                            </td>
                                            <td class=""column-5"">
                                                $");
#nullable restore
#line 119 "D:\Gymany\Views\Cart\Index.cshtml"
                                             Write((int)item.Quantity * (int)item.Product.Price);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"column-7\">\r\n                                                <button type=\"button\" class=\"btn-delete btn\"");
                    BeginWriteAttribute("value", " value=\"", 7671, "\"", 7691, 1);
#nullable restore
#line 122 "D:\Gymany\Views\Cart\Index.cshtml"
WriteAttributeValue("", 7679, item.CartID, 7679, 12, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("\r\n                                                    onclick=\"deleteCartItem(this)\">\r\n                                                    <img src=\"images/Product/DeleteBtn.jpg\" width=\"20px\" weight=\"20px\"");
                    BeginWriteAttribute("alt", " alt=\"", 7897, "\"", 7903, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                                    </button>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 128 "D:\Gymany\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"                                </table>
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
                    WriteLiteral("            </span>\r\n                                </div>\r\n                            </div>\r\n\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74318a2dae28545ae9ab012e3723119a867db4b022782", async() => {
                        WriteLiteral("\r\n                                Proceed to Checkout\r\n                            ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 164 "D:\Gymany\Views\Cart\Index.cshtml"
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script src=\"/vendor/sweetalert/sweetalert.min.js\"></script>\r\n    <script>\r\n        function deleteCartItem(button) {\r\n            var cartID = button.value;\r\n\r\n            $.ajax({\r\n                type: \'POST\',\r\n                url: \'");
#nullable restore
#line 174 "D:\Gymany\Views\Cart\Index.cshtml"
                 Write(Url.Action("Delete", "Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                data: {
                    cartID: cartID
                },
                success: function (response) {
                    swal(""Deleted product!"", ""Success"");
                    // Xóa hàng khỏi bảng giỏ hàng mà không cần tải lại trang
                    var row = button.closest('.table_row');
                    row.remove();
                    // Gọi lại hàm cập nhật Subtotal
                    updateSubtotal();
                },
                error: function (xhr, status, error) {
                    alert(""Fail"");
                    console.error(xhr.responseText);
                }
            });
        }
    </script>




    <script>
        function updateCartItemMinus(button, change) {
            var row = button.closest("".table_row"");
            var input = row.querySelector("".num-product"");
            var quantity = parseInt(input.value);
            var price = parseFloat(input.dataset.price);
            var totalElement = row.qu");
                WriteLiteral(@"erySelector("".column-5"");
            var cartID = button.value;

            // Update quantity based on change
            quantity += change;
            if (quantity < 1) quantity = 1; // Ensure minimum quantity is 1
            // Update input value
            input.value = quantity + 1;

            // Update total
            var total = quantity * price;
            totalElement.textContent = ""$ "" + total.toFixed(2);

            // Update subtotal
            updateSubtotal();



            $.ajax({
                type: 'POST',
                url: '");
#nullable restore
#line 223 "D:\Gymany\Views\Cart\Index.cshtml"
                 Write(Url.Action("UpdateCartItem", "Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                data: {
                    cartID: cartID,
                    quantity: quantity
                }
            });
        }


        function updateCartItemPlus(button, change) {
            var row = button.closest("".table_row"");
            var input = row.querySelector("".num-product"");
            var quantity = parseInt(input.value);
            var price = parseFloat(input.dataset.price);
            var totalElement = row.querySelector("".column-5"");
            var cartID = button.value;

            // Update quantity based on change
            quantity += change;
            if (quantity < 1) quantity = 1; // Ensure minimum quantity is 1
            // Update input value
            input.value = quantity - 1;

            // Update total
            var total = quantity * price;
            totalElement.textContent = ""$ "" + total.toFixed(2);

            // Update subtotal
            updateSubtotal();



            $.ajax({
                ty");
                WriteLiteral("pe: \'POST\',\r\n                url: \'");
#nullable restore
#line 257 "D:\Gymany\Views\Cart\Index.cshtml"
                 Write(Url.Action("UpdateCartItem", "Cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                data: {
                    cartID: cartID,
                    quantity: quantity
                }
            });
        }

        function updateSubtotal() {
            var subtotal = 0;
            var totalElements = document.querySelectorAll("".column-5"");
            totalElements.forEach(function (element) {
                subtotal += parseFloat(element.textContent.replace(""$ "", """"));
            });
            document.getElementById(""subtotal-value"").textContent = ""$ "" + subtotal.toFixed(2);
        }
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
                var total = parseF");
                WriteLiteral(@"loat(totalCell.textContent.replace('$', ''));
                subtotal += total; // Cộng vào Subtotal
            });

            // Cập nhật giá trị Subtotal
            var subtotalElement = document.getElementById('subtotal-value');
            subtotalElement.textContent = '$' + subtotal.toFixed(2); // Hiển thị với định dạng tiền tệ
        }

        // Gọi hàm cập nhật Subtotal khi trang được tải
        document.addEventListener('DOMContentLoaded', function () {
            updateSubtotal();
        });
    </script>



    <!--===============================================================================================-->
    <script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
    <!--===============================================================================================-->
    <script src=""vendor/animsition/js/animsition.min.js""></script>
    <!--===============================================================================================-->
    <script src=""v");
                WriteLiteral(@"endor/bootstrap/js/popper.js""></script>
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
            $(this).c");
                WriteLiteral(@"ss('overflow', 'hidden');
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
    <script src=""js/Product/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gymany.Models.ListModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
