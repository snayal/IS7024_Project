using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickType;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;


namespace IS7024_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string jsonSting)
        {
            using (var webClient = new WebClient())
            {


               
                string propertyJson = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json");

                QuickType.Property[] propertyZipCodes = QuickType.Property.FromJson(propertyJson);

               
                JSchema schema = JSchema.Parse(System.IO.File.ReadAllText("PropertySchema.json"));
                JArray jsonArray = JArray.Parse(propertyJson);
                IList<string> validationEvents = new List<string>();
                if (jsonArray.IsValid(schema, out validationEvents))
                {
                    var property = Property.FromJson(propertyJson);
                    ViewData["Property"] = property;
                }
                else
                {
                    foreach (string evt in validationEvents)
                    {
                        Console.WriteLine(evt);
                    }
                    ViewData["Property"] = new List<Property>();
                }
            }
        }
    }
}
    
