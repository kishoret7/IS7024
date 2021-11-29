#pragma checksum "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\Brews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90a8138114d070159f99605d96e82659d7a71ed0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RealEstate.Pages.Pages_Brews), @"mvc.1.0.razor-page", @"/Pages/Brews.cshtml")]
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
#line 1 "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\_ViewImports.cshtml"
using RealEstate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90a8138114d070159f99605d96e82659d7a71ed0", @"/Pages/Brews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a03e431bb8e8d5c382f4f12cfffc7376137c81d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Brews : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\Brews.cshtml"
  
    ViewData["Title"] = "Brewery";
    var TheBrewsList = (List<BrewsData.Breweries>)ViewData["Brews"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""/css/BrewSheet.css"" type=""text/css"" />
<div>
    <style>
        .myTable {
            width: 100%;
            text-align: left;
            background-color: antiquewhite;
            border-collapse: collapse;
        }

            .myTable th {
                background-color: darkblue;
                color: white;
            }

            .myTable td,
            .myTable th {
                padding: 10px;
                border: 1px solid black;
            }
    </style>
    <table class=""myTable"" border=""1"" width=""80%"">
        <tr>

            <th>Name</th>
            <th>Brewery Type</th>
            <th>Street</th>
            <th>Phone</th>
            <th>Website Url</th>

        </tr>
");
#nullable restore
#line 38 "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\Brews.cshtml"
          
            int First30brews = 0;
            foreach (BrewsData.Breweries brew in TheBrewsList)
            {

                First30brews = First30brews + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\Brews.cshtml"
                   Write(brew.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\Brews.cshtml"
                   Write(brew.BreweryType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\Brews.cshtml"
                   Write(brew.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\Brews.cshtml"
                   Write(brew.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\Brews.cshtml"
                   Write(brew.WebsiteUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\prana\OneDrive - University of Cincinnati\ASSIGNMENT\IS7024\RealEstate\RealEstate\Pages\Brews.cshtml"


                if (First30brews == 30)
                { break; }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RealEstate.Pages.BrewsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RealEstate.Pages.BrewsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RealEstate.Pages.BrewsModel>)PageContext?.ViewData;
        public RealEstate.Pages.BrewsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
