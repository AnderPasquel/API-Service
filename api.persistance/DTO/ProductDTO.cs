using System;
using System.Collections.Generic;
using System.Text;

namespace api.persistance.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Creation { get; set; }
        public DateTime Modification { get; set; }
    }
}
