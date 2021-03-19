using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejecicio1.Models.Data
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public int Price { get; set; }

        public int Stock { get; set; }

        public int Total => Price * Stock;
    }
}