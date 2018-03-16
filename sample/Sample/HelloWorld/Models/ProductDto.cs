using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class ProductDto //Data transfer object
    {
        public int ProductId { get; set; }

        public int ProductTypeId { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool IsActive { get; set; }

        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }
        
        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

      public string ModifiedBy { get; set; }
    }
}