using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApplication.Models
{
    public class Movie
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
