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
                // Grab our JSON text. 
                var houseJSON = webClient.DownloadString("https://data.cityofchicago.org/resource/s6ha-ppgi.json");

                // Convert raw text to list.
                List<Houses> houseCollection = Houses.FromJson(houseJSON);

                ViewData["Houses"] = houseCollection;

                var landJSON = webClient.DownloadString("https://data.cityofchicago.org/resource/aksk-kvfp.json");

                // CHANGE 2 : Try catch block to catch and throw exceptions - daspl
                string result = "";

                try
                {
                    result = webClient.DownloadString(landJSON);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception while calling the Land API", e);

               }

                // Convert raw text to list.
                List<Lands> landCollection = Lands.FromJson(landJSON);


                ViewData["Lands"] = landCollection;


            }


        }
    }
}
