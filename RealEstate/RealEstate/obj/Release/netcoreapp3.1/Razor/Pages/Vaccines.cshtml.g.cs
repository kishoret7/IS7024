#pragma checksum "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58fdb09fed110ccfb4bbc64c33b7a937882ba7b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RealEstate.Pages.Pages_Vaccines), @"mvc.1.0.razor-page", @"/Pages/Vaccines.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58fdb09fed110ccfb4bbc64c33b7a937882ba7b2", @"/Pages/Vaccines.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03e431bb8e8d5c382f4f12cfffc7376137c81d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vaccines : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "query", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row mb-3 ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
  
    

    RealEstate.VaccinesData.Vaccines TheVacinesDetails= (RealEstate.VaccinesData.Vaccines)ViewData["CovidVaccines"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <br />\r\n    <h2>Latest StateWise Covid Vaccines</h2>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58fdb09fed110ccfb4bbc64c33b7a937882ba7b24870", async() => {
                WriteLiteral("\r\n            <div class=\"input-group row\">\r\n                <div class=\"col-sm-2 font-weight-bold\">Select a State</div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58fdb09fed110ccfb4bbc64c33b7a937882ba7b25272", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 17 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.UserState);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.UserState;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"input-group-append\">\r\n                    <input type=\"submit\" value=\"Submit\" class=\"btn btn-outline-secondary\" />\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 24 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
         if (string.IsNullOrWhiteSpace(Model.UserState))
        {

        }
        else if (TheVacinesDetails == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-info\">COVID19 Data for ");
#nullable restore
#line 30 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
                                                      Write(Model.AllStatesDropdownDictionary[@Model.UserState]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" not found.</div>\r\n");
#nullable restore
#line 31 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-6"">
                    <div >
                        <div class=""card-subtitle"">
                            CUMULATIVE DOSAGE TILL DATE
                        </div>
                        
                        <dl class=""row"">
                            <dt class=""col-sm-6"">
                                Date
                            </dt>
                            <dd class=""col-sm-6"">
                                ");
#nullable restore
#line 46 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
                           Write(TheVacinesDetails.Date.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-6\">\r\n                                State\r\n                            </dt>\r\n                            <dd class=\"col-sm-6\">\r\n                                ");
#nullable restore
#line 52 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
                           Write(Model.AllStatesDropdownDictionary[TheVacinesDetails.Location.ToUpper()]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </dd>
                            <dt class=""col-sm-6"">
                                Total Doses Administered
                            </dt>
                            <dd class=""col-sm-6"">
                                ");
#nullable restore
#line 58 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
                           Write(TheVacinesDetails.AdministeredCumulative);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </dd>
                            <dt class=""col-sm-6"">
                                Totat Dose 1 Administered
                            </dt>
                            <dd class=""col-sm-6"">
                                ");
#nullable restore
#line 64 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
                           Write(TheVacinesDetails.AdminDose1Cumulative);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </dd>
                            <dt class=""col-sm-6"">
                                Total Series Complete
                            </dt>
                            <dd class=""col-sm-6"">
                                ");
#nullable restore
#line 70 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
                           Write(TheVacinesDetails.SeriesCompleteCumulative);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </dd>
                            <dt class=""col-sm-6"">
                                Total Booster Doses Administered
                            </dt>
                            <dd class=""col-sm-6"">
                                ");
#nullable restore
#line 76 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
                           Write(TheVacinesDetails.BoosterCumulative);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n                    </div>\r\n                </div>\r\n\r\n                \r\n                \r\n            </div>\r\n");
#nullable restore
#line 85 "C:\Users\kisho\Documents\GitHub\IS7024\RealEstate\RealEstate\Pages\Vaccines.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RealEstate.Pages.VaccinesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RealEstate.Pages.VaccinesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RealEstate.Pages.VaccinesModel>)PageContext?.ViewData;
        public RealEstate.Pages.VaccinesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
