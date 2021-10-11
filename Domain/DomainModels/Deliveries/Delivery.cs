using CommonTypes.Enumerations;

namespace Domain.DomainModels.Deliveries
{
    public class Delivery
    {
        public long Id { get; set; }
        public List<DeliveryItem> DeliveryItems { get; set; }
        public DeliveryType DeliveryType { get; set; }
        public decimal DeliveryCost { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime DeliveryDateTime { get; set; }


    }

    public class DeliveryItem
    {
        public long Id { get; set; }
        public long PorductId { get; set; }
        public short Quantity { get; set; }
    }
}
