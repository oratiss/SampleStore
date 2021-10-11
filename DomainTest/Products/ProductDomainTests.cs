
using CommonTypes.Enumerations;
using Domain.DomainModels.Products;
using FluentAssertions;
using System;
using Xunit;

namespace DomainTest.Products
{
    public class ProductDomainTests
    {
        [Fact]
        public void Name_Should_Not_Be_Empty()
        {
            //arrange act and Assert alltogether
            Assert.Throws<ArgumentNullException>(() => new ProductTestBuilder()
                .With(x => x.Name, string.Empty)
                .Build());
        }

        [Fact]
        public void Total_Price_should_Be_Equal_To_Sum_Of_BaseUnitPrice_And_Profit()
        {
            //arrange and act
            var someProduct = new ProductTestBuilder()
                .With(x => x.BaseUnitPrice, 100_000)
                .With(x => x.Profit, 10_000)
                .Build();

            //assert
            var check = someProduct.TotalPrice == someProduct.BaseUnitPrice + someProduct.Profit;
            check.Should().BeTrue();
        }

        [Fact]
        public void Check_Product_Is_Fragile_Method_Should_Return_False_If_A_Product_Is_Normal()
        {
            //arrange and act
            var someProduct = new ProductTestBuilder()
                .With(x => x.ProductType, ProductType.Normal)
                .Build();

            //assert
            var checkFragility = someProduct.CheckProductIsFragile();
            checkFragility.Should().BeFalse();
        }

    }
}
