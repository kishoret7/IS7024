using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RealEstate.VaccinesData;

namespace RealEstate.Pages
{
    public class VaccinesModel : PageModel
    {
        [BindProperty]
        public SelectList StateList { get; set; }
        public string UserState { get; set; }
        public Dictionary<string, string> AllStatesDropdownDictionary { get; set; }

        public void OnGet(string query)
        {
            AllStatesDropdown();
            using (var webClient = new WebClient())
            {
                string VaccinesData = string.Empty;


                try
                {
                    VaccinesData = webClient.DownloadString("https://covidtrackerxml.azurewebsites.net/Covid19VaccineJson");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception while calling API - Vaccines data", e);

                }

                var covidVaccines = Vaccines.FromJson(VaccinesData);



                if (!string.IsNullOrWhiteSpace(query))
                {
                    var covidVaccineList = covidVaccines.ToList();
                    var stateWiseVaccines = covidVaccineList.FindAll(x => string.Equals(x.Location, query, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (stateWiseVaccines != null && stateWiseVaccines.Count > 0)
                    {
                        var orderedStateWiseVaccines = stateWiseVaccines.OrderByDescending(x => x.Date).ToArray();
                        ViewData["CovidVaccines"] = orderedStateWiseVaccines[0];
                    }
                    else
                    {
                        ViewData["CovidVaccines"] = null;
                    }
                }
                else
                {
                    ViewData["CovidVaccines"] = null;
                }
                UserState = query;
            }
        }

        private void AllStatesDropdown()
        {
            AllStatesDropdownDictionary = new Dictionary<string, string>
            {
                { "AL", "Alabama" },
                { "AK", "Alaska" },
                { "AZ", "Arizona" },
                { "AR", "Arkansas" },
                { "CA", "California" },
                { "CO", "Colorado" },
                { "CT", "Connecticut" },
                { "DE", "Delaware" },
                { "DC", "District Of Columbia" },
                { "FL", "Florida" },
                { "GA", "Georgia" },
                { "HI", "Hawaii" },
                { "ID", "Idaho" },
                { "IL", "Illinois" },
                { "IN", "Indiana" },
                { "IA", "Iowa" },
                { "KS", "Kansas" },
                { "KY", "Kentucky" },
                { "LA", "Louisiana" },
                { "ME", "Maine" },
                { "MD", "Maryland" },
                { "MA", "Massachusetts" },
                { "MI", "Michigan" },
                { "MN", "Minnesota" },
                { "MS", "Mississippi" },
                { "MO", "Missouri" },
                { "MT", "Montana" },
                { "NE", "Nebraska" },
                { "NV", "Nevada" },
                { "NH", "New Hampshire" },
                { "NJ", "New Jersey" },
                { "NM", "New Mexico" },
                { "NY", "New York" },
                { "NC", "North Carolina" },
                { "ND", "North Dakota" },
                { "OH", "Ohio" },
                { "OK", "Oklahoma" },
                { "OR", "Oregon" },
                { "PA", "Pennsylvania" },
                { "RI", "Rhode Island" },
                { "SC", "South Carolina" },
                { "SD", "South Dakota" },
                { "TN", "Tennessee" },
                { "TX", "Texas" },
                { "UT", "Utah" },
                { "VT", "Vermont" },
                { "VA", "Virginia" },
                { "WA", "Washington" },
                { "WV", "West Virginia" },
                { "WI", "Wisconsin" },
                { "WY", "Wyoming" }
            };

            ViewData["UserState"] = new SelectList(AllStatesDropdownDictionary, "Key", "Value");
        }
    }
}

