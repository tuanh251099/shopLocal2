using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Application.Catalog.Products.Dtos
{
    public class ProductCreateRequest
    {
        public int Name { get; set; }
        public decimal Price { get; set; }
    }
}
