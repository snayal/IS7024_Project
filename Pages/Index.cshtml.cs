﻿using Microsoft.AspNetCore.Mvc;
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
using QuickTypeCrimes;

namespace IS7024_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string crimesJSON = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/k59e-2pvf.json");
                JSchema crimeSchema = JSchema.Parse(System.IO.File.ReadAllText("CrimeSchema.json"));
                JArray crimeArray = JArray.Parse(crimesJSON);
                IList<string> validationEventsCrime = new List<string>();
                if(crimeArray.IsValid(crimeSchema, out validationEventsCrime))
                {
                    var crime = Crimes.FromJson(crimesJSON);
                    ViewData["Crime"] = crime;
                }
                else
                {
                    foreach(string evt in validationEventsCrime)
                    {
                        Console.WriteLine(evt);
                    }
                    ViewData["Crime"] = new List<Crimes>();
                }

                string jsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json");
                JSchema schema = JSchema.Parse(System.IO.File.ReadAllText("PropertySchema.json"));
                JArray jsonArray = JArray.Parse(jsonString);
                IList<string> validationEvents = new List<string>();
                if (jsonArray.IsValid(schema, out validationEvents))
                {
                    var property = Property.FromJson(jsonString);
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
    