using CommonTypes.CommonModels;
using CommonTypes.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest.Order
{
    public class OrderTestBuilder
    {
        public long Id { get; set; }
        public long CustomerId{ get; set; }
        public Address Address { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DiscountType DiscountType { get; set; }
        public short? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public List<Delivery> Deliveries { get; set; }
    }
}
