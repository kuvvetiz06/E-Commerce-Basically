using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal Stock { get; set; }
        public string Explanation { get; set; }
        //public List<Basket> Baskets { get; set; }
        public bool Status { get; set; }

    }
}
