namespace Domain.DomainModels.Products
{
    public class ProductDomain
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal BaseUnitPrice { get; private set; }
        public decimal Profit { get; private set; }

        public ProductDomain(long id, string name, decimal baseUnitPrice, decimal profit)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            
            Id = id;
            Name = name;
            BaseUnitPrice = baseUnitPrice;
            Profit = profit;
        }
    }
}
