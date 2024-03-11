using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeTemplater.Models
{
    public class Link
    {
        public enum LinkType
        {
            Github,
            LinkedIn
        }

        public string urlPath;

        public LinkType Type { get; set; }
    }
}
