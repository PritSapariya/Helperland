#pragma checksum "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edaa42d3a43205fcf2c4e3ad690ad90fa67cdb63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceProvider_Partial__ServiceHistoryDetails), @"mvc.1.0.view", @"/Views/ServiceProvider/Partial/_ServiceHistoryDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edaa42d3a43205fcf2c4e3ad690ad90fa67cdb63", @"/Views/ServiceProvider/Partial/_ServiceHistoryDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_ServiceProvider_Partial__ServiceHistoryDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Helperland.Models.DBModels.ServiceRequest>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/service-provider/service-hisory-details.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/included.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("included"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/not-included.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("not-included"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ServiceProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptService", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edaa42d3a43205fcf2c4e3ad690ad90fa67cdb637167", async() => {
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 11 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
  
    List<String> extraList = new List<string>();

    foreach(var item in Model.ServiceRequestExtras)
    {
        switch(item.ServiceExtraId)
        {
            case 1:
                extraList.Add("Inside cabinets");
                break;

            case 2:
                extraList.Add("Inside fridge");
                break;

            case 3:
                extraList.Add("Inside oven");
                break;

            case 4:
                extraList.Add("Laundry wash & dry");
                break;

            case 5:
                extraList.Add("Interior windows");
                break;

            default:
                break;


        }
    }

    String extraString = String.Join(", ", extraList);
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal-header"">
    <h4 class=""modal-title"" id=""serviceDetailsModalLabel"">Service Details</h4>
    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
</div>
<div class=""modal-body row m-0"">

    <div class=""col-12 p-0 mb-1""><h4>");
#nullable restore
#line 54 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                Write(Model.ServiceStartDate.ToString("dd'/'MM'/'yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 54 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                    Write(Model.ServiceStartDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 54 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                                                                Write(Model.ServiceStartDate.AddMinutes((int)((Model.ServiceHours + Model.ExtraHours) * 60)).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n    <div class=\"col-12 p-0 mb-1\"><b>Duration :</b>  <span class=\"d-inline-block\">");
#nullable restore
#line 55 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                             Write(Model.ServiceHours + Model.ExtraHours);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Hrs</span></div>\r\n    <hr class=\"my-2\">\r\n    <div class=\"col-12 p-0 mb-1\"><b>Service Id :</b>  <span class=\"d-inline-block\">");
#nullable restore
#line 57 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                              Write(Model.ServiceRequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 58 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
     if (extraList.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 p-0 mb-1\"><b>Extras :</b>  <span class=\"d-inline-block\">");
#nullable restore
#line 60 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                              Write(extraString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 61 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 p-0 mb-1\"><b>Net Amount :</b> &nbsp;&nbsp; <span class=\"d-inline-block payment\">€ ");
#nullable restore
#line 62 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                                    Write(Model.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n    <hr class=\"my-2\">\r\n    <div class=\"col-12 p-0 mb-1\"><b>Customer Name :</b> <span class=\"d-inline-block\">");
#nullable restore
#line 64 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                Write(Model.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 64 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                                      Write(Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n    <div class=\"col-12 p-0 mb-1\"><b>Service Address :</b> <span class=\"d-inline-block\">");
#nullable restore
#line 65 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                  Write(Model.ServiceRequestAddresses.First().AddressLine2);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 65 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                                                                       Write(Model.ServiceRequestAddresses.First().AddressLine1);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 65 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                                                                                                                            Write(Model.ServiceRequestAddresses.First().City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 65 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                                                                                                                                                                          Write(Model.ServiceRequestAddresses.First().PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n    <div class=\"col-12 p-0 mb-1\"><b>Phone :</b> +91 <span class=\"d-inline-block\">");
#nullable restore
#line 66 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                            Write(Model.ServiceRequestAddresses.First().Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n    <div class=\"col-12 p-0 mb-1\"><b>Email :</b> <span class=\"d-inline-block\">");
#nullable restore
#line 67 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                        Write(Model.ServiceRequestAddresses.First().Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n    <hr class=\"my-2\">\r\n    <div class=\"col-12 p-0 mb-2\"><b>Comments :</b> <span class=\"d-inline-block\">");
#nullable restore
#line 69 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                           Write(Model.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n");
#nullable restore
#line 70 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
     if (Model.HasPets == true)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 p-0 mb-1 d-flex align-items-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "edaa42d3a43205fcf2c4e3ad690ad90fa67cdb6317762", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;I have pets at home\r\n        </div>\r\n");
#nullable restore
#line 76 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 p-0 mb-1 d-flex align-items-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "edaa42d3a43205fcf2c4e3ad690ad90fa67cdb6319346", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("&nbsp;I don\'t have pets at home\r\n        </div>\r\n");
#nullable restore
#line 82 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
#nullable restore
#line 86 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
 if (Model.Status != 4 && Model.Status != 2)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"modal-footer action\">\r\n");
#nullable restore
#line 89 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
     if (Model.Status == 5)
    {
        if (Model.ServiceStartDate.AddMinutes((int)((Model.ServiceHours + Model.ExtraHours) * 60)) < DateTime.Now)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edaa42d3a43205fcf2c4e3ad690ad90fa67cdb6321596", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn px-4 py-2 btn-action-primary d-flex align-items-center\" data-bs-dismiss=\"modal\">Complete</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-serviceId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                      WriteLiteral(Model.ServiceRequestId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-serviceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                                                                 WriteLiteral(ViewBag.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
     if (Model.Status == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edaa42d3a43205fcf2c4e3ad690ad90fa67cdb6325577", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn px-4 py-2 btn-action-primary d-flex align-items-center\" data-bs-dismiss=\"modal\">Accept</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-serviceId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                WriteLiteral(Model.ServiceRequestId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-serviceId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["serviceId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
                                                                                                                           WriteLiteral(ViewBag.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 99 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"button\" class=\"btn px-4 py-2 btn-action-secondary d-flex align-items-center\" data-bs-dismiss=\"modal\">Cancel</button>\r\n</div>\r\n");
#nullable restore
#line 102 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\ServiceProvider\Partial\_ServiceHistoryDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Helperland.Models.DBModels.ServiceRequest> Html { get; private set; }
    }
}
#pragma warning restore 1591
