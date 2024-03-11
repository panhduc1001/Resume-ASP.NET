using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ResumeTemplate.Pages
{
    public class IndexModel : PageModel
    {
        public string FullName { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Languages { get; set; }

        public void OnGet()
        {
            FullName = "Jackson Phan";
            LinkedInUsername = "jackson-anhducphan";
            YearsOfExperience = 2;
            Languages = new List<string> { "English", "Vietnamese", "French" };
        }
    }
}
