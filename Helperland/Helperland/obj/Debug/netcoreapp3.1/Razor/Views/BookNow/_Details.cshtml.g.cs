#pragma checksum "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\BookNow\_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f76d4200e6408858719a05079c2953cd0e5a9a7b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f76d4200e6408858719a05079c2953cd0e5a9a7b", @"/Views/BookNow/_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_BookNow__Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "mumbai", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Development\TatvaSoft\Project\Helperland\Helperland\Helperland\Views\BookNow\_Details.cshtml"
  
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
        <label class=""form-label address-block"">
            <input type=""radio"" name=""address"" id=""address1"" value=""1"">
            <div><span>Address: </span> Janakpuri Appartment 14, Junagadh</div>
            <div><span>Mobile nunber: </span>9512347382</div>
            <div class=""radio-input-icon""></div>
        </label>
        <label class=""form-label address-block"">
            <input type=""radio"" name=""address"" id=""address2"" value=""2"">
            <div><span>Address: </span> Janakpuri Appartment 14, Junagadh</div>
            <div><span>Mobile nunber: </span>9512347382</div>
            <div class=""radio-input-icon""></div>
        </label>
        <label class=""form-labe");
            WriteLiteral(@"l address-block"">
            <input type=""radio"" name=""address"" id=""address3"" value=""3"">
            <div><span>Address: </span> Janakpuri Appartment 14, Junagadh</div>
            <div><span>Mobile nunber: </span>9512347382</div>
            <div class=""radio-input-icon""></div>
        </label>
    </div>
    <div class=""col-12"">
        <input type=""button"" class=""btn btn-large-outline"" value=""+ Add New Address"" id=""addAddressButton"" />
        <div class=""addressForm"" id=""addAddressForm"">
            <div class=""row"">
                <div class=""col-md-6 form-group"">
                    <label class=""form-label"">Street Name</label>
                    <input type=""text"" class=""form-control"" placeholder=""Street Name"" required />
                    <!-- <span class=""text-danger"">Error</span> -->
                </div>
                <div class=""col-md-6 form-group"">
                    <label class=""form-label"">House Number</label>
                    <input type=""number"" class=""form-con");
            WriteLiteral(@"trol"" placeholder=""House Number"" required />
                    <!-- <span class=""text-danger"">Error</span> -->
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 form-group"">
                    <label class=""form-label"">Postal Code</label>
                    <input type=""text"" class=""form-control"" placeholder=""Street Name"" value=""53842"" disabled required />
                    <!-- <span class=""text-danger"">Error</span> -->
                </div>
                <div class=""col-md-6 form-group"">
                    <label class=""form-label"">City</label>
                    <select class=""form-select"" required>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f76d4200e6408858719a05079c2953cd0e5a9a7b6559", async() => {
                WriteLiteral("Mumbai");
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
                    <!-- <span class=""text-danger"">Error</span> -->
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 form-group"">
                    <label class=""form-label"">Mobile Number</label>
                    <div class=""input-group"">
                        <span class=""input-group-text"" id=""basic-addon1"">+49</span>
                        <input type=""number"" class=""form-control"" placeholder=""Mobile Number"" required />
                    </div>
                </div>
            </div>
            <div class=""row"">
                <input type=""button"" class=""col-2 btn btn-primary-small mx-2"" value=""Save"" id=""addAddress"" />
                <input type=""button"" class=""col-2 btn btn-secondary-small"" value=""Cancel"" id=""closeAddressForm"" />
            </div>
        </div>
    </div>
    <p class=""hr-line""></p>
    <div class=""d-flex flex-row-reverse"">
        <input type=""button"" class=""co");
            WriteLiteral("l-3 btn btn-primary\" value=\"Continue\" />\r\n    </div>\r\n</div> ");
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