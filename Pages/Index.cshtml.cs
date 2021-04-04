using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PropertyQuickType;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using QuickTypeCrimes;


namespace IS7024_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]

        public Property property { get; set; }



        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public object MyProperty { get; private set; }
        public void OnGet(string jsonSting)
        {
            using (var webClient = new WebClient())
            {


                string propertyJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json");

                string ZipJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?project_type=RESIDENTIAL");
                string NeighJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?project_type=RESIDENTIAL");
                string streetJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?project_type=RESIDENTIAL");

                Property[] property = Property.FromJson(propertyJsonString);
                ViewData["MyProperty"] = property;


                IDictionary<long, HealthcareCenter.Healthcare> allHealthcares = new Dictionary<long, HealthcareCenter.Healthcare>();
                string propertyJson = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json");
                PropertyQuickType.Property[] properties = PropertyQuickType.Property.FromJson(propertyJson);
                                
                string healthcareJSON = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/v8yh-wpss.json");

                string crimeJSON = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/k59e-2pvf.json");
                QuickTypeCrimes.Crime[] crimes = QuickTypeCrimes.Crime.FromJson(crimeJSON);
                
               
                string propertyResJason = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json?project_type=RESIDENTIAL");
               

              
                JSchema schema = JSchema.Parse(System.IO.File.ReadAllText("PropertySchema.json"));
                JArray jsonArray = JArray.Parse(propertyJson);
                IList<string> validationEvents = new List<string>();
                if (jsonArray.IsValid(schema, out validationEvents))
                {
                    
                   
                  

                    var propertyResidential = Property.FromJson(propertyResJason);
                    ViewData["PropertyRes"] = propertyResidential;
                }
                else
                {
                    foreach (string evt in validationEvents)
                    {
                        Console.WriteLine(evt);
                    }
                   
                    ViewData["MyProperty"] = property;
                }
            }

        }

        
    }
}



   



