using CommonTypes.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypes.CommonModels
{
    public class Address
    {
        public long Id { get; set; }
        public Province Province { get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }
        public int Number { get; set; }
        public string PostCode { get; set; }
    }
}
