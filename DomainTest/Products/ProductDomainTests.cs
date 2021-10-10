
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DomainTest.Products
{
    public class ProductDomainTests
    {
        [Fact]
        public void Name_Should_Not_Be_Empty()
        {
            //arrange act and Assert alltogether
            Assert.Throws<NullReferenceException>(() => new ProductTestBuilder()
                .With(x => x.Name, string.Empty)
                .Build());
        }

    }
}
