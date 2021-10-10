using Domain.DomainModels.Products;
using Utilities.ReflectionTools;
using static Utilities.Constants.ProductConstants;

namespace DomainTest.Products
{
    public class ProductTestBuilder : ReflectionBuilder<ProductDomain, ProductTestBuilder>
    {
        private readonly ProductTestBuilder _builderInstance;

        private static long _id = SomeId;
        private static string _name = SomeProductName;
        private static decimal _baseUnitPrice = SomeBaseUnitPrice;
        private static decimal _profit = SomeProfit;

        public ProductTestBuilder()
        {
            _builderInstance = this;
        }
        public override ProductDomain Build()
        {
           return new ProductDomain(_id, _name, _baseUnitPrice, _profit);
        }
    }
}
