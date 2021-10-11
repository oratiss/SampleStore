using CommonTypes.Enumerations;
using Domain.DomainModels.Products;
using Utilities.ReflectionTools;
using static Utilities.Constants.ProductConstants;

namespace DomainTest.Products
{
    public class ProductTestBuilder : ReflectionBuilder<Product, ProductTestBuilder>
    {
        private readonly ProductTestBuilder _builderInstance;

        public long Id = SomeId;
        public string Name = SomeProductName;
        public decimal BaseUnitPrice = SomeBaseUnitPrice;
        public decimal Profit = SomeProfit;
        public ProductType ProductType = SomeProductType;

        public ProductTestBuilder()
        {
            _builderInstance = this;
        }
        public override Product Build()
        {
           return new Product(Id, Name, BaseUnitPrice, Profit, ProductType);
        }
    }
}
