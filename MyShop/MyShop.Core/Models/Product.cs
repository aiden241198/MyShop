using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        [StringLength(20)]
        [DisplayName("Product Name")]
        public string ID { set; get; }
        public string Name { get; set; }
        public string Description { set; get; }

        [Range(0, 1000)]
        public decimal Price { set; get; }
        public string Category { set; get; }
        public string Image { set; get; }

        public Product()
        {
            this.ID = Guid.NewGuid().ToString();
        }
    }
}
