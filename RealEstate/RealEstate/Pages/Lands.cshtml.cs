using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RealEstate.Pages
{
    public class LandsModel : PageModel
    {
        [BindProperty]
        public string CommunityNumberItem { get; set; }

        public async Task OnGetAsync(string query)
        {
            using (var webClient = new WebClient())
            {
                string Lands_data = string.Empty;
                try
                {
                    Lands_data = webClient.DownloadString("https://data.cityofchicago.org/resource/aksk-kvfp.json");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error during API call - Land Inventory", e);
                }
                var AllLandInventory = LandData.Lands.FromJson(Lands_data);

                if (!string.IsNullOrWhiteSpace(query))
                {
                    var AllLandsList = AllLandInventory.ToList();
                    long UserCommunityNumber = (long)Convert.ToDouble(query);
                    var CommunityLand = AllLandsList.FindAll(x => (x.CommunityAreaNumber == UserCommunityNumber ) );
                    CommunityLand = CommunityLand.FindAll(x => x.SqFt >= 0);
                    CommunityLand = CommunityLand.OrderByDescending(x => x.SqFt).ToList();
                    if (CommunityLand != null && CommunityLand.Count > 0)
                    {
                        ViewData["UserLandsList"] = CommunityLand;
                    }
                    else
                    {
                        ViewData["UserLandsList"] = null;
                    }
                }
                else
                {
                    ViewData["UserLandsList"] = null;
                }
             CommunityNumberItem = query;
            }
        }

    }
}
