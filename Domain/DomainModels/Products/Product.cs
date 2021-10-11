using CommonTypes.Enumerations;

namespace Domain.DomainModels.Products
{
    public class Product
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public decimal BaseUnitPrice { get; private set; }
        public decimal Profit { get; private set; }
        public decimal TotalPrice => BaseUnitPrice + Profit;

        public ProductType ProductType { get; set; }

        public Product(long id, string name, decimal baseUnitPrice, decimal profit, ProductType productType)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            Id = id;
            Name = name;
            BaseUnitPrice = baseUnitPrice;
            Profit = profit;
            ProductType = productType;
        }

    }

    public static class ProdcutDomainExtension
    {
        public static bool CheckProductIsFragile(this Product? product)
        {
            if (product == null) return false;
            var check = product.ProductType == ProductType.Fragile ? true : false;
            return check;
        }
    }


}
