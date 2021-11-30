#pragma checksum "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50361d15345f52e33eacf5f4124d177222b40f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RealEstate.Pages.Pages_Lands), @"mvc.1.0.razor-page", @"/Pages/Lands.cshtml")]
namespace RealEstate.Pages
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
#line 1 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\_ViewImports.cshtml"
using RealEstate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50361d15345f52e33eacf5f4124d177222b40f37", @"/Pages/Lands.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03e431bb8e8d5c382f4f12cfffc7376137c81d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Lands : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
  
    ViewData["Title"] = "LandInventory";
    var TheLandsList = (List<LandData.Lands>)ViewData["UserLandsList"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50361d15345f52e33eacf5f4124d177222b40f373736", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/StyleSheet.css\" type=\"text/css\" />\r\n    <div class=\"container\">\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50361d15345f52e33eacf5f4124d177222b40f374121", async() => {
                    WriteLiteral(@"
            <div class=""form-group"">
                <label for=""SearchItem"" style=""color: goldenrod"" class=""control-label""> <strong>Land Inventories</strong></label>
                <div style=""color: goldenrod"" class=""mb-5"">
                    <strong>Search by </strong> <span style=""color: goldenrod"" class=""span_style""><strong>Community Number</strong></span>&nbsp;&nbsp;&nbsp;
                </div>
                <input id=""SearchItem""");
                    BeginWriteAttribute("value", " value=\"", 759, "\"", 793, 1);
#nullable restore
#line 18 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
WriteAttributeValue("", 767, Model.CommunityNumberItem, 767, 26, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" name=\"query\" class=\"form-control\" type=\"text\" />\r\n            </div>\r\n            <div style=\"margin-bottom:20px;\">\r\n                <input class=\"btn btn-primary\" type=\"submit\" value=\"Search\" />\r\n            </div>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 25 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
         if (string.IsNullOrWhiteSpace(Model.CommunityNumberItem))
        {

        }
        else if (TheLandsList == null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-info\"> Data for Lands in this Community area number [");
#nullable restore
#line 31 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                                                                                    Write(Model.CommunityNumberItem);

#line default
#line hidden
#nullable disable
                WriteLiteral("] not found.</div>\r\n");
#nullable restore
#line 32 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div>                
                <table class=""myTable"">
                    <tr>
                        <th>Property Status</th>
                        <th>Managing Org</th>
                        <th>Community Area</th>
                        <th>Address</th>
                        <th>ZipCode</th>
                        <th>Area Available</th>
                        <th>Latitude</th>
                        <th>Longitude</th>
                    </tr>
");
#nullable restore
#line 47 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                      
                        int FirstTenLands = 0;
                        foreach (LandData.Lands land in TheLandsList)
                        {
                            FirstTenLands = FirstTenLands + 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                               Write(land.PropertyStatus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                               Write(land.ManagingOrganization);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                               Write(land.CommunityAreaName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                               Write(land.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                               Write(land.ZipCode);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                               Write(land.SqFt);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                               Write(land.Latitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                               Write(land.Longitude);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
                            if (FirstTenLands == 10)
                            { break; }
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n            </div>\r\n");
#nullable restore
#line 68 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Lands.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RealEstate.Pages.LandsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RealEstate.Pages.LandsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RealEstate.Pages.LandsModel>)PageContext?.ViewData;
        public RealEstate.Pages.LandsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
