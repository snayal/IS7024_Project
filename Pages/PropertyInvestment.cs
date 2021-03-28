using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuickType;

namespace IS7024_Project.Pages
{
    public class PropertyInvestment : PageModel
    {
        public object MyProperty { get; set; }

        public void OnGet()
        {

            using (var webClient = new WebClient())
            {
                string propertyJsonString = webClient.DownloadString("https://data.cincinnati-oh.gov/resource/m76i-p5p9.json");

                Property[] property = Property.FromJson(propertyJsonString);
                ViewData["MyProperty"] = property;
            }
        }
    }
}
