using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BrewsData;

namespace RealEstate.Pages
{
    public class BrewsModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string Brews_data = string.Empty;
                try
                {
                    Brews_data = webClient.DownloadString("https://breweryarc.azurewebsites.net/breweryentire");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error during API call - Breweries Data", e);
                }                    
                List<Breweries> BrewsCollection = Breweries.FromJson(Brews_data);
                ViewData["Brews"] = BrewsCollection;
            }

        }
    }
}


