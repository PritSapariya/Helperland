#pragma checksum "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480c2cf90e19261f9c46b7d50b9dcb3f940324b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceProvider_MyRatings), @"mvc.1.0.view", @"/Views/ServiceProvider/MyRatings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"480c2cf90e19261f9c46b7d50b9dcb3f940324b8", @"/Views/ServiceProvider/MyRatings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_ServiceProvider_MyRatings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Helperland.Models.DBModels.Rating>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/service-provider/sp-my-ratings.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select rating-list d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select sorting-list d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/calendar2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/layer-14.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/star1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/star2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
  
    Layout = "~/Views/Shared/_ServiceProviderLayout.cshtml";
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input hidden type=\"text\" value=\"6\" id=\"navbarCurrentID\" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "480c2cf90e19261f9c46b7d50b9dcb3f940324b87395", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"ratings-wrapper\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"left-section col-md-6 mb-2\">\r\n            <label class=\"form-label d-inline-block\">Rating&nbsp;</label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "480c2cf90e19261f9c46b7d50b9dcb3f940324b88725", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "480c2cf90e19261f9c46b7d50b9dcb3f940324b89001", async() => {
                    WriteLiteral("All");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 15 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.RatingList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"right-section col-md-6\">\r\n            <label class=\"form-label d-inline-block\">Sorting&nbsp;</label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "480c2cf90e19261f9c46b7d50b9dcb3f940324b811667", async() => {
                WriteLiteral("\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 22 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.SortingList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <table class=\"table mt-3 table-bordered\" id=\"datatable\">\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 31 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"mb-2\">\r\n                    <td class=\"p-3\">\r\n                        <div>\r\n                            <span class=\"d-md-inline-block px-md-3\">\r\n                                <span class=\"d-block\">");
#nullable restore
#line 37 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                                 Write(item.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <h6 class=\"d-block\">");
#nullable restore
#line 38 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                               Write(item.RatingFromNavigation.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                                                                    Write(item.RatingFromNavigation.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </span>\r\n                            <span class=\"d-md-inline-block px-5\">\r\n                                <span class=\"d-block\"><b>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "480c2cf90e19261f9c46b7d50b9dcb3f940324b815054", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;&nbsp;");
#nullable restore
#line 41 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                                                                                         Write(item.ServiceRequest.ServiceStartDate.ToString("dd'/'MM'/'yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                                <span class=\"d-block\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "480c2cf90e19261f9c46b7d50b9dcb3f940324b816643", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;&nbsp;");
#nullable restore
#line 42 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                                                                                     Write(item.ServiceRequest.ServiceStartDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 42 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                                                                                                                                               Write(item.ServiceRequest.ServiceStartDate.AddMinutes((int)((item.ServiceRequest.ExtraHours + item.ServiceRequest.ServiceHours) * 60)).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </span>
                            <span class=""d-md-inline-block px-5"">
                                <span class=""d-block""><b>Rating</b></span>
                                <span class=""d-block align-middle"">
");
#nullable restore
#line 47 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                     if (item.Ratings != null)
                                    {
                                        int i;
                                        for (i = 1; i < item.Ratings; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "480c2cf90e19261f9c46b7d50b9dcb3f940324b819479", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                        }
                                        for (int j = i; j <= 5; j++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "480c2cf90e19261f9c46b7d50b9dcb3f940324b820928", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                        }

                                        if (item.Ratings == 5)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h6 class=\"mt-1 fw-light d-md-inline-block mx-md-2\">Excellent</h6>\r\n");
#nullable restore
#line 62 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                        }
                                        else if (item.Ratings >= 4)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h6 class=\"mt-1 fw-light d-md-inline-block mx-md-2\">Very Good</h6>\r\n");
#nullable restore
#line 66 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                        }
                                        else if (item.Ratings >= 3)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h6 class=\"mt-1 fw-light d-md-inline-block mx-md-2\">Good</h6>\r\n");
#nullable restore
#line 70 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                        }
                                        else if (item.Ratings >= 2)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h6 class=\"mt-1 fw-light d-md-inline-block mx-md-2\">Poor</h6>\r\n");
#nullable restore
#line 74 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                        }
                                        else 
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h6 class=\"mt-1 fw-light d-md-inline-block mx-md-2\">Very Poor</h6>\r\n");
#nullable restore
#line 78 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                        }

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\r\n                            </span>\r\n                        </div>\r\n");
#nullable restore
#line 84 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                         if (item.ServiceRequest.Comments != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <hr class=\"my-2\">\r\n                            <div class=\"px-md-3\">\r\n                                <h6 class=\"d-inline-block mb-1\">Customer Comment</h6><br />\r\n                                <span class=\"d-inline-block\">");
#nullable restore
#line 89 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                                                        Write(item.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n");
#nullable restore
#line 91 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 95 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\MyRatings.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


        </tbody>
    </table>

</div>

<script>

    $("".sorting-list"").change(() => {

        let url = window.location.pathname + ""?sort="" + $("".sorting-list"").val() + ""&&rate="" + $("".rating-list"").val();
        window.location.href = url;
        
    });

    $("".rating-list"").change(() => {

        let url = window.location.pathname + ""?sort="" + $("".sorting-list"").val() + ""&&rate="" + $("".rating-list"").val();
        console.log(url);
        window.location.href = url;

    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Helperland.Models.DBModels.Rating>> Html { get; private set; }
    }
}
#pragma warning restore 1591
