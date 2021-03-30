using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuickType;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace IS7024_Project.Pages
{
    public class PropertyInvestment : PageModel
    {

        public object Jschema { get; private set; }

        public void OnGet()
        {




            using (var webClient = new WebClient())
            {
                string propertyJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json");

                string ZipJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?ZipCode");
                string NeighJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?Neighborhood");
                string streetJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?SiteStreetAddress");
               
                Property[] property = Property.FromJson(propertyJsonString);
                ViewData["MyProperty"] = property;
            }


        }
    }
}



	

	

		



		