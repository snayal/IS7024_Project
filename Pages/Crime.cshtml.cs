using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using QuickTypeCrimes;

namespace IS7024_Project.Pages
{
    public class CrimeModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {

                string crimeJSON = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/k59e-2pvf.json");
                JSchema crimeSchema = JSchema.Parse(System.IO.File.ReadAllText("CrimeSchema.json"));
                JArray crimeArray = JArray.Parse(crimeJSON);
                IList<string> validationEvents = new List<string>();
                if (crimeArray.IsValid(crimeSchema, out validationEvents))
                {
                    var crime = Crime.FromJson(crimeJSON);
                    ViewData["Crime"] = crime;
                }
                else
                {
                    foreach (string evt in validationEvents)
                    {
                        Console.WriteLine(evt);
                    }
                    ViewData["Crime"] = new QuickTypeCrimes.Crime[0];
                }
            }
        }
    }
}
