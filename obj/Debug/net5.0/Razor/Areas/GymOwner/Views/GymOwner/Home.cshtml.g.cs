#pragma checksum "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d30fe82ee8ea4d2d6ea1fa3717108441eed5b8b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_GymOwner_Views_GymOwner_Home), @"mvc.1.0.view", @"/Areas/GymOwner/Views/GymOwner/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d30fe82ee8ea4d2d6ea1fa3717108441eed5b8b3", @"/Areas/GymOwner/Views/GymOwner/Home.cshtml")]
    public class Areas_GymOwner_Views_GymOwner_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Gymany.Models.Payment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
  
    Layout = "GymOwnerLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ============================================================== -->
<!-- Preloader - style you can find in spinners.css -->
<!-- ============================================================== -->
<div class=""preloader"">
    <div class=""lds-ripple"">
        <div class=""lds-pos""></div>
        <div class=""lds-pos""></div>
    </div>
</div>
<!-- ============================================================== -->
<div class=""page-wrapper"">
    <!-- ============================================================== -->
    <!-- Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <div class=""page-breadcrumb bg-white"">
        <div class=""row align-items-center"">
            <div class=""col-lg-3 col-md-4 col-sm-4 col-xs-12"">
                <h4 class=""page-title"">Dashboard</h4>
            </div>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- ============================================================== -->
");
            WriteLiteral(@"    <!-- End Bread crumb and right sidebar toggle -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- Container fluid  -->
    <!-- ============================================================== -->
    <div class=""container-fluid"">
        <!-- ============================================================== -->
        <!-- Three charts -->
        <!-- ============================================================== -->
");
#nullable restore
#line 44 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
         if (ViewData["Error"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">\r\n                ");
#nullable restore
#line 47 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
           Write(ViewData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 49 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row justify-content-center"">
            <div class=""col-lg-4 col-md-12"">
                <div class=""white-box analytics-info"">
                    <h3 class=""box-title"">Total Visit</h3>
                    <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                        <li>
                            <div id=""sparklinedash""><canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                            </div>
                        </li>
                        <li class=""ms-auto""><span class=""counter text-success"">659</span></li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-4 col-md-12"">
                <div class=""white-box analytics-info"">
                    <h3 class=""box-title"">Total Page Views</h3>
                    <ul class=""list-inline two-part d-flex align-items-center mb-0"">");
            WriteLiteral(@"
                        <li>
                            <div id=""sparklinedash2""><canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                            </div>
                        </li>
                        <li class=""ms-auto""><span class=""counter text-purple"">869</span></li>
                    </ul>
                </div>
            </div>
            <div class=""col-lg-4 col-md-12"">
                <div class=""white-box analytics-info"">
                    <h3 class=""box-title"">Unique Visitor</h3>
                    <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                        <li>
                            <div id=""sparklinedash3""><canvas width=""67"" height=""30""
                                    style=""display: inline-block; width: 67px; height: 30px; vertical-align: top;""></canvas>
                            </div>
                     ");
            WriteLiteral(@"   </li>
                        <li class=""ms-auto""><span class=""counter text-info"">911</span>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- PRODUCTS YEARLY SALES -->
        <!-- ============================================================== -->


        <!-- ============================================================== -->
        <!-- RECENT SALES -->
        <!-- ============================================================== -->
        <div class=""row"">
            <div class=""col-md-12 col-lg-12 col-sm-12"">
                <div class=""white-box"">
                    <h3 class=""box-title"">Payment Recent</h3>
                    <div class=""table-responsive"">
                        <table class=""table text-wrap"">
                            <thead>
                                <tr>
                                    <");
            WriteLiteral(@"th class=""border-top-0"">PaymentID</th>
                                    <th class=""border-top-0"">Date</th>
                                    <th class=""border-top-0"">Quantity</th>
                                    <th class=""border-top-0"">Customer</th>
                                    <th class=""border-top-0"">Product</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 116 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 119 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
                                       Write(item.PaymentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 120 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
                                       Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 121 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 122 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
                                       Write(item.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 123 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
                                       Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 125 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- Recent Comments -->
        <!-- ============================================================== -->
        <div class=""row"">
            <!-- .col -->
            <div class=""col-md-12 col-lg-8 col-sm-12"">
                <div class=""card white-box p-0"">
                    <div class=""card-body"">
                        <h3 class=""box-title mb-0"">Recent Comments</h3>
                    </div>
                    <div class=""comment-widgets"">
                        <!-- Comment Row -->
                        <div class=""d-flex flex-row comment-row p-3 mt-0"">
                            <div class=""p-2""><img src=""/Areas/GymOwner/Sources/plugins/images/users/varun.jpg""
                                    alt=""user"" width=""50"" class=""rounded-circ");
            WriteLiteral(@"le""></div>
                            <div class=""comment-text ps-2 ps-md-3 w-100"">
                                <h5 class=""font-medium"">James Anderson</h5>
                                <span class=""mb-3 d-block"">Lorem Ipsum is simply dummy text of the printing and type
                                    setting industry.It has survived not only five centuries. </span>
                                <div class=""comment-footer d-md-flex align-items-center"">
                                    <span class=""badge bg-primary rounded"">Pending</span>

                                    <div class=""text-muted fs-2 ms-auto mt-2 mt-md-0"">April 14, 2021</div>
                                </div>
                            </div>
                        </div>
                        <!-- Comment Row -->
                        <div class=""d-flex flex-row comment-row p-3"">
                            <div class=""p-2""><img src=""/Areas/GymOwner/Sources/plugins/images/users/genu.jpg"" alt=""user""
");
            WriteLiteral(@"                                    width=""50"" class=""rounded-circle""></div>
                            <div class=""comment-text ps-2 ps-md-3 active w-100"">
                                <h5 class=""font-medium"">Michael Jorden</h5>
                                <span class=""mb-3 d-block"">Lorem Ipsum is simply dummy text of the printing and type
                                    setting industry.It has survived not only five centuries. </span>
                                <div class=""comment-footer d-md-flex align-items-center"">

                                    <span class=""badge bg-success rounded"">Approved</span>

                                    <div class=""text-muted fs-2 ms-auto mt-2 mt-md-0"">April 14, 2021</div>
                                </div>
                            </div>
                        </div>
                        <!-- Comment Row -->
                        <div class=""d-flex flex-row comment-row p-3"">
                            <div class=""p-2""><");
            WriteLiteral(@"img src=""/Areas/GymOwner/Sources/plugins/images/users/ritesh.jpg""
                                    alt=""user"" width=""50"" class=""rounded-circle""></div>
                            <div class=""comment-text ps-2 ps-md-3 w-100"">
                                <h5 class=""font-medium"">Johnathan Doeting</h5>
                                <span class=""mb-3 d-block"">Lorem Ipsum is simply dummy text of the printing and type
                                    setting industry.It has survived not only five centuries. </span>
                                <div class=""comment-footer d-md-flex align-items-center"">

                                    <span class=""badge rounded bg-danger"">Rejected</span>

                                    <div class=""text-muted fs-2 ms-auto mt-2 mt-md-0"">April 14, 2021</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div c");
            WriteLiteral(@"lass=""col-lg-4 col-md-12 col-sm-12"">
                <div class=""card white-box p-0"">
                    <div class=""card-heading"">
                        <h3 class=""box-title mb-0"">Chat Listing</h3>
                    </div>
                    <div class=""card-body"">
                        <ul class=""chatonline"">
                            <li>
                                <div class=""call-chat"">
                                    <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                        <i class=""fas fa-phone""></i>
                                    </button>
                                    <button class=""btn btn-info btn-circle btn"" type=""button"">
                                        <i class=""far fa-comments text-white""></i>
                                    </button>
                                </div>
                                <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
          ");
            WriteLiteral(@"                              src=""/plugins/images/users/varun.jpg"" alt=""user-img"" class=""img-circle"">
                                    <div class=""ms-2"">
                                        <span class=""text-dark"">Varun Dhavan <small
                                                class=""d-block text-success d-block"">online</small></span>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <div class=""call-chat"">
                                    <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                        <i class=""fas fa-phone""></i>
                                    </button>
                                    <button class=""btn btn-info btn-circle btn"" type=""button"">
                                        <i class=""far fa-comments text-white""></i>
                                    </button>
         ");
            WriteLiteral(@"                       </div>
                                <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                        src=""/plugins/images/users/genu.jpg"" alt=""user-img"" class=""img-circle"">
                                    <div class=""ms-2"">
                                        <span class=""text-dark"">Genelia
                                            Deshmukh <small class=""d-block text-warning"">Away</small></span>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <div class=""call-chat"">
                                    <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                        <i class=""fas fa-phone""></i>
                                    </button>
                                    <button class=""btn btn-info btn-circle btn"" type=""button"">
         ");
            WriteLiteral(@"                               <i class=""far fa-comments text-white""></i>
                                    </button>
                                </div>
                                <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                        src=""/plugins/images/users/ritesh.jpg"" alt=""user-img"" class=""img-circle"">
                                    <div class=""ms-2"">
                                        <span class=""text-dark"">Ritesh
                                            Deshmukh <small class=""d-block text-danger"">Busy</small></span>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <div class=""call-chat"">
                                    <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                        <i class=""fas fa-phone""></i>
                     ");
            WriteLiteral(@"               </button>
                                    <button class=""btn btn-info btn-circle btn"" type=""button"">
                                        <i class=""far fa-comments text-white""></i>
                                    </button>
                                </div>
                                <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                        src=""/plugins/images/users/arijit.jpg"" alt=""user-img"" class=""img-circle"">
                                    <div class=""ms-2"">
                                        <span class=""text-dark"">Arijit
                                            Sinh <small class=""d-block text-muted"">Offline</small></span>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <div class=""call-chat"">
                                    <button class=""btn btn-success text-");
            WriteLiteral(@"white btn-circle btn"" type=""button"">
                                        <i class=""fas fa-phone""></i>
                                    </button>
                                    <button class=""btn btn-info btn-circle btn"" type=""button"">
                                        <i class=""far fa-comments text-white""></i>
                                    </button>
                                </div>
                                <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                        src=""/plugins/images/users/govinda.jpg"" alt=""user-img"" class=""img-circle"">
                                    <div class=""ms-2"">
                                        <span class=""text-dark"">Govinda
                                            Star <small class=""d-block text-success"">online</small></span>
                                    </div>
                                </a>
                            </li>
                            <li");
            WriteLiteral(@">
                                <div class=""call-chat"">
                                    <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                        <i class=""fas fa-phone""></i>
                                    </button>
                                    <button class=""btn btn-info btn-circle btn"" type=""button"">
                                        <i class=""far fa-comments text-white""></i>
                                    </button>
                                </div>
                                <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                        src=""/plugins/images/users/hritik.jpg"" alt=""user-img"" class=""img-circle"">
                                    <div class=""ms-2"">
                                        <span class=""text-dark"">John
                                            Abraham<small class=""d-block text-success"">online</small></span>
                  ");
            WriteLiteral(@"                  </div>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- /.col -->
        </div>
    </div>
    <!-- ============================================================== -->
    <!-- End Container fluid  -->
    <!-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- footer -->
    <!-- ============================================================== -->
    <footer class=""footer text-center""> 2021 © Ample Admin brought to you by <a
            href=""https://www.wrappixel.com/"">wrappixel.com</a>
    </footer>
    <!-- ============================================================== -->
    <!-- End footer -->
    <!-- ============================================================== -->
</div>
<!-- =================================================");
            WriteLiteral("============= -->\r\n<!-- End Page wrapper  -->\r\n<!-- ============================================================== -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Gymany.Models.Payment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
