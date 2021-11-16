using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LandData;
using System.Net;
using HouseData;

namespace RealEstate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {


            using (var webClient = new WebClient())
            {
                
                string Chicago_data = string.Empty;

                try
                {
                    Chicago_data = webClient.DownloadString("https://data.cityofchicago.org/resource/s6ha-ppgi.json");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception while calling API", e);
                }

                // Convert raw text to list.
                List<Houses> houseCollection = Houses.FromJson(Chicago_data);


                ViewData["Houses"] = houseCollection;

                string Chicago_Land_data = string.Empty;

                try
                {
                    Chicago_Land_data = webClient.DownloadString("https://data.cityofchicago.org/resource/aksk-kvfp.json");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception while calling API", e);
                }
            

                // Convert raw text to list.
                List<Lands> landCollection = Lands.FromJson(Chicago_Land_data);


                ViewData["Lands"] = landCollection;


            }


        }
    }
}
