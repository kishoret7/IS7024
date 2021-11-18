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
    
    public class HousesModel : PageModel
    {
        [BindProperty]
        public SelectList AreaList { get; set; }
        public string SearchArea { get; set; }
        public List<string> AllAreaList { get; set; }

        

        public void Onget(string query)
        {
            InitAreaDropDown();

            using (var webClient = new WebClient())
            {
                string Houses_data = string.Empty;


                try
                {
                    Houses_data = webClient.DownloadString("https://data.cityofchicago.org/resource/s6ha-ppgi.json");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error during API call - Housing", e);

                }

                var AllHousing = HouseData.Houses.FromJson(Houses_data);



                if (!string.IsNullOrWhiteSpace(query))
                {
                    var AllhousingList = AllHousing.ToList();
                    var CommunityHousing = AllhousingList.FindAll(x => string.Equals(x.CommunityArea, query, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (CommunityHousing != null && CommunityHousing.Count > 0)
                    {
                        
                        ViewData["UserHousesList"] = CommunityHousing;
                    }
                    else
                    {
                        ViewData["UserHousesList"] = null;
                    }
                }
                else
                {
                    ViewData["UserHousesList"] = null;
                }
              
                SearchArea = query;
            }

            
        }

        private void InitAreaDropDown()
        {
            AllAreaList = new List<string>
            {
                { "Englewood" },
                { "Logan Square" },
                { "Portage Park" },
                { "West Town" },
                { "Lower West Side" },
                
            };

            ViewData["SearchArea"] = new SelectList(AllAreaList);
        }

    }
}

