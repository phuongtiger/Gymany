#pragma checksum "D:\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "822c30a9a4dafdc4d35920afa3712c42bbe173f20f83cda0d975879d0ae96e78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_GymOwner_Views_GymOwner_Home), @"mvc.1.0.view", @"/Areas/GymOwner/Views/GymOwner/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"822c30a9a4dafdc4d35920afa3712c42bbe173f20f83cda0d975879d0ae96e78", @"/Areas/GymOwner/Views/GymOwner/Home.cshtml")]
    #nullable restore
    public class Areas_GymOwner_Views_GymOwner_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Gymany\Areas\GymOwner\Views\GymOwner\Home.cshtml"
  
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
                </d");
            WriteLiteral(@"iv>
                <!-- /.col-lg-12 -->
            </div>
            <!-- ============================================================== -->
            <!-- End Bread crumb and right sidebar toggle -->
            <!-- ============================================================== -->
            <!-- ============================================================== -->
            <!-- Container fluid  -->
            <!-- ============================================================== -->
            <div class=""container-fluid"">
                <!-- ============================================================== -->
                <!-- Three charts -->
                <!-- ============================================================== -->
                <div class=""row justify-content-center"">
                    <div class=""col-lg-4 col-md-12"">
                        <div class=""white-box analytics-info"">
                            <h3 class=""box-title"">Total Visit</h3>
               ");
            WriteLiteral(@"             <ul class=""list-inline two-part d-flex align-items-center mb-0"">
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
                            <ul class=""list-inline two-part d-flex align-items-center mb-0"">
                                <li>
                                    <div id=""sparklinedash2""><canvas width=""");
            WriteLiteral(@"67"" height=""30""
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
            WriteLiteral(@"                                </li>
                                <li class=""ms-auto""><span class=""counter text-info"">911</span>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <!-- ============================================================== -->
                <!-- PRODUCTS YEARLY SALES -->
                <!-- ============================================================== -->
                <div class=""row"">
                    <div class=""col-md-12 col-lg-12 col-sm-12 col-xs-12"">
                        <div class=""white-box"">
                            <h3 class=""box-title"">Products Yearly Sales</h3>
                            <div class=""d-md-flex"">
                                <ul class=""list-inline d-flex ms-auto"">
                                    <li class=""ps-3"">
                                        <h5><i class=""fa fa-circle me-1 text-info""></i>");
            WriteLiteral(@"Mac</h5>
                                    </li>
                                    <li class=""ps-3"">
                                        <h5><i class=""fa fa-circle me-1 text-inverse""></i>Windows</h5>
                                    </li>
                                </ul>
                            </div>
                            <div id=""ct-visits"" style=""height: 405px;"">
                                <div class=""chartist-tooltip"" style=""top: -17px; left: -12px;""><span
                                        class=""chartist-tooltip-value"">6</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- ============================================================== -->
                <!-- RECENT SALES -->
                <!-- ============================================================== -->
                <div class=""row"">
                    <div c");
            WriteLiteral(@"lass=""col-md-12 col-lg-12 col-sm-12"">
                        <div class=""white-box"">
                            <div class=""d-md-flex mb-3"">
                                <h3 class=""box-title mb-0"">Recent sales</h3>
                                <div class=""col-md-3 col-sm-4 col-xs-6 ms-auto"">
                                    <select class=""form-select shadow-none row border-top"">
                                        <option>March 2021</option>
                                        <option>April 2021</option>
                                        <option>May 2021</option>
                                        <option>June 2021</option>
                                        <option>July 2021</option>
                                    </select>
                                </div>
                            </div>
                            <div class=""table-responsive"">
                                <table class=""table no-wrap"">
                                    <t");
            WriteLiteral(@"head>
                                        <tr>
                                            <th class=""border-top-0"">#</th>
                                            <th class=""border-top-0"">Name</th>
                                            <th class=""border-top-0"">Status</th>
                                            <th class=""border-top-0"">Date</th>
                                            <th class=""border-top-0"">Price</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>1</td>
                                            <td class=""txt-oflo"">Elite admin</td>
                                            <td>SALE</td>
                                            <td class=""txt-oflo"">April 18, 2021</td>
                                            <td><span class=""text-success"">$24</span></td>
           ");
            WriteLiteral(@"                             </tr>
                                        <tr>
                                            <td>2</td>
                                            <td class=""txt-oflo"">Real Homes WP Theme</td>
                                            <td>EXTENDED</td>
                                            <td class=""txt-oflo"">April 19, 2021</td>
                                            <td><span class=""text-info"">$1250</span></td>
                                        </tr>
                                        <tr>
                                            <td>3</td>
                                            <td class=""txt-oflo"">Ample Admin</td>
                                            <td>EXTENDED</td>
                                            <td class=""txt-oflo"">April 19, 2021</td>
                                            <td><span class=""text-info"">$1250</span></td>
                                        </tr>
                                    ");
            WriteLiteral(@"    <tr>
                                            <td>4</td>
                                            <td class=""txt-oflo"">Medical Pro WP Theme</td>
                                            <td>TAX</td>
                                            <td class=""txt-oflo"">April 20, 2021</td>
                                            <td><span class=""text-danger"">-$24</span></td>
                                        </tr>
                                        <tr>
                                            <td>5</td>
                                            <td class=""txt-oflo"">Hosting press html</td>
                                            <td>SALE</td>
                                            <td class=""txt-oflo"">April 21, 2021</td>
                                            <td><span class=""text-success"">$24</span></td>
                                        </tr>
                                        <tr>
                                            <td>6</td>
     ");
            WriteLiteral(@"                                       <td class=""txt-oflo"">Digital Agency PSD</td>
                                            <td>SALE</td>
                                            <td class=""txt-oflo"">April 23, 2021</td>
                                            <td><span class=""text-danger"">-$14</span></td>
                                        </tr>
                                        <tr>
                                            <td>7</td>
                                            <td class=""txt-oflo"">Helping Hands WP Theme</td>
                                            <td>MEMBER</td>
                                            <td class=""txt-oflo"">April 22, 2021</td>
                                            <td><span class=""text-success"">$64</span></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                 ");
            WriteLiteral(@"   </div>
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
                                    <div class=""p-2""><img src=""/Areas/GymOwner/Sources/plugins/images/users/varun.jpg"" alt=""user"" width=""50"" class=""rounded-circle""></div>
                                    <d");
            WriteLiteral(@"iv class=""comment-text ps-2 ps-md-3 w-100"">
                                        <h5 class=""font-medium"">James Anderson</h5>
                                        <span class=""mb-3 d-block"">Lorem Ipsum is simply dummy text of the printing and type setting industry.It has survived not only five centuries. </span>
                                        <div class=""comment-footer d-md-flex align-items-center"">
                                             <span class=""badge bg-primary rounded"">Pending</span>
                                             
                                            <div class=""text-muted fs-2 ms-auto mt-2 mt-md-0"">April 14, 2021</div>
                                        </div>
                                    </div>
                                </div>
                                <!-- Comment Row -->
                                <div class=""d-flex flex-row comment-row p-3"">
                                    <div class=""p-2""><img src=""/Areas/GymOw");
            WriteLiteral(@"ner/Sources/plugins/images/users/genu.jpg"" alt=""user"" width=""50"" class=""rounded-circle""></div>
                                    <div class=""comment-text ps-2 ps-md-3 active w-100"">
                                        <h5 class=""font-medium"">Michael Jorden</h5>
                                        <span class=""mb-3 d-block"">Lorem Ipsum is simply dummy text of the printing and type setting industry.It has survived not only five centuries. </span>
                                        <div class=""comment-footer d-md-flex align-items-center"">

                                            <span class=""badge bg-success rounded"">Approved</span>
                                            
                                            <div class=""text-muted fs-2 ms-auto mt-2 mt-md-0"">April 14, 2021</div>
                                        </div>
                                    </div>
                                </div>
                                <!-- Comment Row -->
            ");
            WriteLiteral(@"                    <div class=""d-flex flex-row comment-row p-3"">
                                    <div class=""p-2""><img src=""/Areas/GymOwner/Sources/plugins/images/users/ritesh.jpg"" alt=""user"" width=""50"" class=""rounded-circle""></div>
                                    <div class=""comment-text ps-2 ps-md-3 w-100"">
                                        <h5 class=""font-medium"">Johnathan Doeting</h5>
                                        <span class=""mb-3 d-block"">Lorem Ipsum is simply dummy text of the printing and type setting industry.It has survived not only five centuries. </span>
                                        <div class=""comment-footer d-md-flex align-items-center"">

                                            <span class=""badge rounded bg-danger"">Rejected</span>
                                            
                                            <div class=""text-muted fs-2 ms-auto mt-2 mt-md-0"">April 14, 2021</div>
                                        </div>
           ");
            WriteLiteral(@"                         </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4 col-md-12 col-sm-12"">
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
                                            <button class=""btn btn-info btn-circle btn"" type=""b");
            WriteLiteral(@"utton"">
                                                <i class=""far fa-comments text-white""></i>
                                            </button>
                                        </div>
                                        <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                                src=""/plugins/images/users/varun.jpg"" alt=""user-img"" class=""img-circle"">
                                            <div class=""ms-2"">
                                                <span class=""text-dark"">Varun Dhavan <small
                                                        class=""d-block text-success d-block"">online</small></span>
                                            </div>
                                        </a>
                                    </li>
                                    <li>
                                        <div class=""call-chat"">
                                            <button class=""btn btn-s");
            WriteLiteral(@"uccess text-white btn-circle btn"" type=""button"">
                                                <i class=""fas fa-phone""></i>
                                            </button>
                                            <button class=""btn btn-info btn-circle btn"" type=""button"">
                                                <i class=""far fa-comments text-white""></i>
                                            </button>
                                        </div>
                                        <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                                src=""/plugins/images/users/genu.jpg"" alt=""user-img"" class=""img-circle"">
                                            <div class=""ms-2"">
                                                <span class=""text-dark"">Genelia
                                                    Deshmukh <small class=""d-block text-warning"">Away</small></span>
                                            </div");
            WriteLiteral(@">
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
                                        </div>
                                        <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                                src=""/plugins/images/users/ritesh.jpg"" alt=""user-img"" class=""img-circle"">
                                           ");
            WriteLiteral(@" <div class=""ms-2"">
                                                <span class=""text-dark"">Ritesh
                                                    Deshmukh <small class=""d-block text-danger"">Busy</small></span>
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
                                        </div>
        ");
            WriteLiteral(@"                                <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                                src=""/plugins/images/users/arijit.jpg"" alt=""user-img"" class=""img-circle"">
                                            <div class=""ms-2"">
                                                <span class=""text-dark"">Arijit
                                                    Sinh <small class=""d-block text-muted"">Offline</small></span>
                                            </div>
                                        </a>
                                    </li>
                                    <li>
                                        <div class=""call-chat"">
                                            <button class=""btn btn-success text-white btn-circle btn"" type=""button"">
                                                <i class=""fas fa-phone""></i>
                                            </button>
                                          ");
            WriteLiteral(@"  <button class=""btn btn-info btn-circle btn"" type=""button"">
                                                <i class=""far fa-comments text-white""></i>
                                            </button>
                                        </div>
                                        <a href=""javascript:void(0)"" class=""d-flex align-items-center""><img
                                                src=""/plugins/images/users/govinda.jpg"" alt=""user-img""
                                                class=""img-circle"">
                                            <div class=""ms-2"">
                                                <span class=""text-dark"">Govinda
                                                    Star <small class=""d-block text-success"">online</small></span>
                                            </div>
                                        </a>
                                    </li>
                                    <li>
                                        <");
            WriteLiteral(@"div class=""call-chat"">
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
                                                    Abraham<small class=""d-b");
            WriteLiteral(@"lock text-success"">online</small></span>
                                            </div>
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
            <!-- ============");
            WriteLiteral(@"================================================== -->
            <!-- End footer -->
            <!-- ============================================================== -->
        </div>
        <!-- ============================================================== -->
        <!-- End Page wrapper  -->
        <!-- ============================================================== -->
    </div>


");
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
