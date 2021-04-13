using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.RazorPages;
using CovidVaccine;

namespace IS7024_Project.Pages
{
    public class CovidVaccinesModel : PageModel
    {
        public void OnGet()
        {
            string output = getData(" https://data.cdc.gov/resource/saz5-9hgg.json");
            var vaccine = Vaccine.FromJson(output);
            ViewData["Vaccines"] = vaccine;

        }

        private string getData(string url1)
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.DownloadString(url1);
            }
        }
    }
}






    