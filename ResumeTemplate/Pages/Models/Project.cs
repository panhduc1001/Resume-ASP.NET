﻿using System.Collections.Generic;

namespace ResumeTemplate.Models
{
    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public List<string> Technologies { get; set; }
    }
}