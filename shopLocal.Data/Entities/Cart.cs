using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopLocal.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quanity { get; set; }
        public decimal Price { get; set; }
        public Guid UserId { get; set; }
        public Product Product { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
