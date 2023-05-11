using System;
using System.Collections.Generic;

#nullable disable

namespace Store.Models
{
    public partial class Shipper
    {
        public int ShipperId { get; set; }
        public string ShipperName { get; set; }
        public string Phone { get; set; }
        public DateTime? ShipDate { get; set; }
    }
}
