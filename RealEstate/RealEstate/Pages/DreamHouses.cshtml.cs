using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HouseData;
using LandData;
using Microsoft.Extensions.Logging;

namespace RealEstate.Pages
{
    public class DreamHousesModel : PageModel
    {
        private readonly ILogger<DreamHousesModel> _logger;

        [BindProperty]
        public DreamHouses House { get; set; }


        public DreamHousesModel(ILogger<DreamHousesModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["DreamHouseList"] = AllDreamHouses.AllHouses;
        }

        public void OnPost()
        {
             
            string stuff = House.CommunityArea + House.PropertyType + House.Street + House.PlotSize 
                + House.ManagementCompany;
            AllDreamHouses.AllHouses.Add(House);

            ViewData["DreamHouseList"] = AllDreamHouses.AllHouses;
        }
    }
}
