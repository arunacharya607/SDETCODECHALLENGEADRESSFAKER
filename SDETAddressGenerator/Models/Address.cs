using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDETAddressGenerator.Models
{
    public class Address
    {
        public string House { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string StateCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
    }
}