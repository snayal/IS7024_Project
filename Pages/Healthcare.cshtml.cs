using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using HealthcareCenter;

namespace IS7024_Project.Pages
{
    public class HealthcareModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {

                string healthcareJSON = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/v8yh-wpss.json");
                JSchema healthcareSchema = JSchema.Parse(System.IO.File.ReadAllText("HealthcareSchema.json"));
                JArray healthcareArray = JArray.Parse(healthcareJSON);
                IList<string> validationEvents = new List<string>();
                if (healthcareArray.IsValid(healthcareSchema, out validationEvents))
                {
                    var healthcare = Healthcare.FromJson(healthcareJSON);
                    ViewData["Healthcare"] = healthcare;
                }
                else
                {
                    foreach (string evt in validationEvents)
                    {
                        Console.WriteLine(evt);
                    }
                    ViewData["Healthcare"] = new HealthcareCenter.Healthcare[0];
                }
            }
        }
    }
}
