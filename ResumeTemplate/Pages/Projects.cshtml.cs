// Projects.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ResumeTemplate.Models;
using ResumeTemplater.Models;

namespace ResumeTemplate.Pages
{
    public class ProjectsModel : PageModel
    {
        public string GithubUsername { get; set; }
        public List<Project> Projects { get; set; }

        public void OnGet()
        {
            Projects = new List<Project> {
                new Project()
                {
                    Title = "Explorella",
                    Description = "A large scale travelling application built to help plan your destination and itinerary on your next trip!",
                    Year = 2019,
                    Technologies = new List<string> {"React", "Node", "Express", "MongoDB"}
                },
                new Project()
                {
                    Title = "Cypher Clothing",
                    Description = "A large scale e-commerce clothing store application.",
                    Year = 2019,
                    Technologies = new List<string> {"Razor", "SQLite"}
                },
                new Project()
                {
                    Title = "Password Box",
                    Description = "A password manager Chrome plugin used to create and safely store all your passwords!",
                    Year = 2020,
                    Technologies = new List<string> {"JavaScript", "HTML"}
                },
                new Project()
                {
                  Title = "Spotivize",
                  Description = "Spotivize is a music platform that uses geolocation to track when your favorite artists are playing in your local city!",
                  Year = 2016,
                  Technologies = new List<string> {"Node", "Express", "React", "MongoDB"}
                }
            };
        }
    }
}
