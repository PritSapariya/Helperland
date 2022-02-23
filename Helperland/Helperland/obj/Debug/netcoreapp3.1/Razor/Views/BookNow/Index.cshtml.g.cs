#pragma checksum "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\BookNow\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "467aaca0c979d23e80f05cd20a2c51ab083b275a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookNow_Index), @"mvc.1.0.view", @"/Views/BookNow/Index.cshtml")]
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
#line 1 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"467aaca0c979d23e80f05cd20a2c51ab083b275a", @"/Views/BookNow/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_BookNow_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/book-now.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/book-now.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\BookNow\Index.cshtml"
  
    ViewData["Title"] = "Book Now";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "467aaca0c979d23e80f05cd20a2c51ab083b275a4822", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- Main Content Starts -->
<main>
    <!-- Price Section -->
    <section class=""main-section"">
        <h2 class=""title"">Set up your cleaning service</h2>

        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 col-xl-9"">

                    <!-- Left -> navbar Starts -->
                    <ul class=""book-now nav nav-custom nav-fill"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""step1"" href=""#"">
                                <span class=""icon""></span>
                                <span class=""text d-none d-lg-inline-block"">Setup Service</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled"" id=""step2"" href=""#"">
                                <span class=""icon""></span>
                                <span class=""text d-none d-lg-inline-block"">Schedule & P");
            WriteLiteral(@"lan</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled"" id=""step3"" href=""#"">
                                <span class=""icon""></span>
                                <span class=""text d-none d-lg-inline-block"">Your Details</span>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled"" id=""step4"" href=""#"">
                                <span class=""icon""></span>
                                <span class=""text d-none d-lg-inline-block"">Make Payment</span>
                            </a>
                        </li>
                    </ul>
                    <!-- Left -> navbar Ends -->

                    <!-- Left -> Form Details Section Starts -->
                    <div class=""book-now-section-wrapper"" id=""book-now-section-wrapper"">
                ");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467aaca0c979d23e80f05cd20a2c51ab083b275a8117", async() => {
                WriteLiteral(@"

                            <section id=""section1"">
                                <div class=""row d-lg-none"">
                                    <span class=""step-title"">Setup Service</span>
                                    <p class=""hr-line""></p>
                                </div>
                                <div id=""step1message"">
                                    
                                </div>
                                <div class=""row"">
                                    <label class=""form-label"">Enter your Postal Code</label>
                                </div>
                                <div class=""row form-group"">
                                    <div class=""col-md-6 col-lg-5"">
                                        <input id=""postalCode"" type=""number"" class=""form-control"" required />
                                        <span id=""postalCodeError"" class=""text-danger""></span>
                                    </div>
                    ");
                WriteLiteral(@"                <div class=""col-md-5 my-2 my-md-0"">
                                        <input id=""submit1"" type=""button"" class=""btn btn-primary"" value=""Check Availability"" />
                                    </div>
                                </div>
                            </section>

                            <section id=""section2"">
                                
                            </section>
                            <section id=""section3"">
                                
                            </section>
                            <section id=""section4"">
                                
                            </section>

                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!-- Left -> Form Details Section Ends -->
                </div>

                <!-- Right -->
                <div class=""col-lg-4 col-xl-3 d-none d-lg-block"">
                    <div class=""payment-summary-wrapper"">

                        <div class=""payment-summary"">
                            <h6 class=""heading"">Payment Summary</h6>
                            <div class=""service-details"">
                                <span id=""serviceDateSummary"">01/01/2000</span>&nbsp;&nbsp;&nbsp;<span id=""serviceStartTimeSummary"">08:00</span>

                                <table class=""table-borderless"">
                                    <thead>
                                        <tr>
                                            <th");
            BeginWriteAttribute("class", " class=\"", 4766, "\"", 4774, 0);
            EndWriteAttribute();
            WriteLiteral(@">Duration</th>
                                            <th class=""col-3 text-end""></th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>Basic</td>
                                            <td class=""text-end"" id=""basicTime"">3 Hrs</td>
                                        </tr>
                                        <tr id=""extraTitle"">
                                            <td class=""extra-title"">Extras</td>
                                            <td></td>
                                        </tr>
                                        <div class=""d-none"">

                                            <tr>
                                                <td>Inside cabinets</td>
                                                <td class=""text-end"">30 Min.</td>
                               ");
            WriteLiteral(@"             </tr>
                                            <tr>
                                                <td>Inside fridge</td>
                                                <td class=""text-end"">30 Min.</td>
                                            </tr>
                                            <tr>
                                                <td>Inside oven</td>
                                                <td class=""text-end"">30 Min.</td>
                                            </tr>
                                            <tr>
                                                <td>Laundry wash & dry</td>
                                                <td class=""text-end"">30 Min.</td>
                                            </tr>
                                            <tr>
                                                <td>Interior windows</td>
                                                <td class=""text-end"">30 Min.</td>
                         ");
            WriteLiteral(@"                   </tr>

                                        </div>
                                    </tbody>
                                </table>
                                <hr>
                                <div class=""total-time d-flex justify-content-between"">
                                    <div class=""d-inline-block""><b>Total Service Time</b></div>
                                    <div class=""d-inline-block text-end""><b>5.5 Hrs</b></div>
                                </div>


                            </div>
                        </div>
                        <hr class=""m-0"">
                        <div class=""cleaning-details d-flex justify-content-between"">
                            <div class=""d-inline-block"">Per cleaning</div>
                            <div class=""d-inline-block text-end""><b>99,00 €</b></div>
                        </div>
                        <hr class=""m-0"">
                        <div class=""payment-details d-flex just");
            WriteLiteral(@"ify-content-between"">
                            <div class=""d-inline-block""><h4>Total<br>Payment</h4></div>
                            <div class=""d-inline-block text-end""><h1><b>99,00 €</b></h1></div>
                        </div>

                    </div>
                </div>

            </div>
        </div>

    </section>
</main>
<!-- Main Content Ends -->

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "467aaca0c979d23e80f05cd20a2c51ab083b275a15737", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 169 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\BookNow\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
