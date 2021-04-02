using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PropertyQuickType;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace IS7024_Project.Pages
{
    public class PropertyInvestment : PageModel
    {

        public object Jschema { get; private set; }

    
        [BindProperty]
        public string ProjectType { get; set; }

        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }

        public bool isSearchType { get; set; }
        public bool isSearchNeighborhood { get; set; }
        public bool isSearchZipCode { get; set; }

        public void OnGet()
        {




            using (var webClient = new WebClient())
            {
                string propertyJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json");

                string ZipJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?project_type=RESIDENTIAL");
                string NeighJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?project_type=RESIDENTIAL");
                string streetJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?project_type=RESIDENTIAL");

                Property[] property = Property.FromJson(propertyJsonString);
                ViewData["MyProperty"] = property;


               
            }


        }
    }
}



	

	

		



		