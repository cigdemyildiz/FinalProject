using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        // [Required] : bu da bir attributedur
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
