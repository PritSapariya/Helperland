#pragma checksum "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\BookNow\_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee766487797f6faee18d6c38e1ecab0018e875af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookNow__Details), @"mvc.1.0.view", @"/Views/BookNow/_Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee766487797f6faee18d6c38e1ecab0018e875af", @"/Views/BookNow/_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_BookNow__Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Junagadh", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\BookNow\_Details.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Your Details Section Starts -->

<div class=""row d-lg-none"">
    <span class=""step-title"">Your Details</span>
    <p class=""hr-line""></p>
</div>
<div class=""row"">
    <label class=""form-label"">Enter your contact details, so we can serve you in better way!</label>
    <div class=""col-12 address-wrapper"">
");
            WriteLiteral(@"    </div>
    <div class=""col-12"">
        <input type=""button"" class=""btn btn-large-outline"" value=""+ Add New Address"" id=""addAddressButton"" />
        <div class=""addressForm"" id=""addAddressForm"">
            <div class=""row"">
                <div class=""col-md-6 form-group"">
                    <label class=""form-label"">Street Name</label>
                    <input type=""text"" class=""form-control"" id=""addressLine1"" placeholder=""Street Name"" required />
                    <span class=""text-danger"" id=""addressLine1Error""></span> 
                </div>
                <div class=""col-md-6 form-group"">
                    <label class=""form-label"">House Number</label>
                    <input type=""text"" class=""form-control"" id=""addressLine2"" placeholder=""House Number"" required />
                    <span class=""text-danger"" id=""addressLine2Error""></span>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 form-group"">
          ");
            WriteLiteral(@"          <label class=""form-label"">Postal Code</label>
                    <input type=""text"" class=""form-control"" placeholder=""Postal Code"" id=""postalCode2"" value='000000' disabled  />
                </div>
                <div class=""col-md-6 form-group"">
                    <label class=""form-label"">City</label>
                    <select class=""form-select"" id=""city"" required>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee766487797f6faee18d6c38e1ecab0018e875af5567", async() => {
                WriteLiteral("Junagadh");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                    <span class=""text-danger""></span>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 form-group"">
                    <label class=""form-label"">Mobile Number</label>
                    <div class=""input-group"">
                        <span class=""input-group-text"" id=""basic-addon1"">+49</span>
                        <input type=""number"" class=""form-control"" id=""mobile"" placeholder=""Mobile Number"" required />
                    </div>
                    <span class=""text-danger"" id=""mobileError""></span>
                </div>
            </div>
            <div class=""row"">
                <input type=""button"" class=""col-2 btn btn-primary-small mx-2"" value=""Save"" id=""addAddress"" />
                <input type=""button"" class=""col-2 btn btn-secondary-small"" value=""Cancel"" id=""closeAddressForm"" />
            </div>
        </div>
    </div>
    <p class=""hr-line""></p>
    <div cl");
            WriteLiteral(@"ass=""d-flex flex-row-reverse"">
        <input type=""button"" class=""col-3 btn btn-primary"" id=""submit3"" value=""Continue"" />
    </div>
</div> 

<script>

    $().ready(() => {

        $(""#section3"").show();

        $(""#step3"").click(() => {

            $("".nav-link"").removeClass(""filled"");
            $("".nav-link"").removeClass(""active"");
            $(""#section3"").show();
            $(""#step1"").addClass(""filled"");
            $(""#step2"").addClass(""filled"");
            $(""#step3"").addClass(""active"");
            $(""#step4"").addClass(""disabled"");
            $(""#section4"").empty();
            $(""#section4"").hide();

        });

        $('#addAddressForm').hide();
        $(""#postalCode2"").val($(""#postalCode"").val());

        $('#addAddressButton').click(() => {
            resetFormValues();
            $('#addAddressButton').hide();
            $('#addAddressForm').show();
        });
        $('#closeAddressForm').click(() => {
            resetFormValues();
       ");
            WriteLiteral(@"     $('#addAddressButton').show();
            $('#addAddressForm').hide();
        });

        const addressValidation = () => {

            var flag = true;

            if ($(""#addressLine1"").val() == '') {
                $(""#addressLine1Error"").text(""Enter valid data"");
                flag = false;
            }
            if ($(""#addressLine2"").val() == '') {
                $(""#addressLine2Error"").text(""Enter valid data"");
                flag = false;
            }
            if ($(""#mobile"").val() == '') {
                $(""#mobileError"").text(""Enter 10 digit number"");
                flag = false;
            }

            return flag;
        };

        $(""#addAddress"").click(() => {

            if (!addressValidation()) {
                return;
            }
            else {
                var address = {};
                address.userId = parseInt($(""#userId"").text());
                address.addressLine1 = $(""#addressLine1"").val();
                a");
            WriteLiteral(@"ddress.addressLine2 = $(""#addressLine2"").val();
                address.postalCode = $(""#postalCode"").val();
                address.city = $(""#city"").val();
                address.mobile = $(""#mobile"").val();

                $.ajax({
                    type: ""POST"",
                    url: ""/BookNow/AddAddress"",
                    data: JSON.stringify(address),
                    contentType: 'application/json; charset=utf-8',
                    success: function (responce) {
                        
                        $('#addAddressButton').show();
                        $('#addAddressForm').hide();
                        GetAddress();

                    },
                    failure: function (response) {
                        alert(""failure"");
                    },
                    error: function (response) {
                        alert(""Something went Worng"");
                    }
                }); 
            }

        });

        const GetAddr");
            WriteLiteral(@"ess = () => {

            $.ajax({

                type: ""POST"",
                url: ""/BookNow/GetAddress"",
                data: { _id: parseInt($(""#userId"").text()), _postalCode: $(""#postalCode"").val() },

                success: function (responce) {

                    var addressArr = JSON.parse(responce).address;
                    
                    $("".address-wrapper"").empty();
                    for (var i = 0; i < addressArr.length; i++) {
                        $("".address-wrapper"").append(`
                                                    <label class=""form-label address-block"">
                                                        <input type=""radio"" name=""address"" id=""${addressArr[i].AddressId}"" value=""${addressArr[i].AddressId}"" />
                                                        <div><span>Address: </span>${addressArr[i].AddressLine1} ${addressArr[i].AddressLine2}, ${addressArr[i].City}</div>
                                                        <div>");
            WriteLiteral(@"<span>Mobile nunber: </span>${addressArr[i].Mobile}</div>
                                                        <div class=""radio-input-icon""></div>
                                                    </label>
                                                    `);
                    }

                },
                failure: function (response) {
                    alert(""failure"");
                },
                error: function (response) {
                    alert(""Something went Worng"");
                }

            });

        };

        GetAddress();

        const stepOn = (firstStep, secondStep, section) => {

            $(section).hide();
            $(firstStep).removeClass(""active"");
            $(firstStep).addClass(""filled"");
            $(secondStep).addClass(""active"");
            $(secondStep).removeClass(""disabled"");

        };
        const resetFormValues = () => {
            // reseting the form value
            $(""#addressLine1"").val("""")");
            WriteLiteral(@";
            $(""#addressLine2"").val("""");
            $(""#mobile"").val("""");
        };

        $(""#submit3"").click(() => {
            stepOn(""#step3"", ""#step4"", ""#section3"");
            $(""#section4"").load(""/BookNow/GetPaymentPage"");
        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
