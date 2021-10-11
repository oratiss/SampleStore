namespace DomainTest.Order
{
    public class OrderItem
    {
        public long Id { get; set; }
        public long Product { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public decimal Subtotal => Quantity * UnitPrice;
    }
}
