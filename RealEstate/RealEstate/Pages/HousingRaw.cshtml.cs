using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RealEstateRawdata.Pages
{
    public class HousingRawModel : PageModel
    {
        public JsonResult OnGet()
        {
            using (var webClient = new WebClient())
            {
                string HouseRawData = webClient.DownloadString("https://data.cityofchicago.org/resource/s6ha-ppgi.json");
                var HousesMyAPIdata = HouseData.Houses.FromJson(HouseRawData);
                return new JsonResult(HousesMyAPIdata);

            }
        }
    }
}


