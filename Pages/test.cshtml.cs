using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using PropertyQuickType;
using IS7024_Project.Pages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using HealthcareCenter;


namespace IS7024_Project.Pages
{
    public class testModel : PageModel
    {


        public object Jschema { get; private set; }
        [BindProperty]
        public string ProjectType { get; set; }

        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }

        public bool isSearchType { get; set; }
        public bool isSearchNeighborhood { get; set; }
        public bool isSearchZipCode { get; set; }

        public string Url { get; set; }
 

        public void OnGet()
        {
           isSearchNeighborhood =false;
            isSearchType = false;
        }

        public void OnPost()
        {
            string type = ProjectType;
            string neighborhood = Neighborhood;

            if (isSearchNeighborhood==true)
            {

                Url = "https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?neighborhood=" + neighborhood;
            }

            else
            {
                Url = "https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?project_type= " + type;
            }

            using (var webClient = new WebClient())
            {
                string jsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json");
                Property[] property = Property.FromJson(jsonString);
                ViewData["MyProperty"] = property;

                Property[] property1 = Property.FromJson(jsonString);
                ViewData["MyProperty1"] = property;

            }


          

                isSearchType =true;
                isSearchNeighborhood = true;
        }


       
    }
}

