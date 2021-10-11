using CommonTypes.Enumerations;
using Domain.DomainModels.Deliveries;

namespace Domain.DomainModels.Orders
{
    public class Order 
    {
        public long Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public OrderStatus Status { get; set; }
        public long CustomerId { get; set; }
        public long AddressId { get; set; }
        public DiscountType? DiscountType { get; set; }
        public short? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<Delivery>? Deliveries { get; set; }
    }


}
