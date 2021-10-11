namespace Domain.DomainModels.Orders
{
    public class OrderItem
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public decimal Subtotal => Quantity * UnitPrice;
    }
}
