using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class ProductWarehouse
    {
        public int ProductId { get; set; }

        public int WarehouseId { get; set; }

        public Product Product { get; set; }

        public Warehouse Warehouse { get; set; }
    }
}
