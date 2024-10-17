using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alza.Models
{
    public class Product
    {
        public class Product
        {
            [Required]
            public int Id { get; set; }

            [Required]
            public string Name { get; set; } = string.Empty;

            [Required]
            public Uri ImgUri { get; set; } = new Uri("http://example.com");

            [Required]
            public decimal Price { get; set; }

            public string? Description { get; set; }
        }
    }
}