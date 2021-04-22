using Bogus;
using SDETAddressGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SDETAddressGenerator.Controllers.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        public string GetRandomAddress()
        {
            var countryList = new[] { "US", "Canada", "Mexico", "Netherlands" };
            var address = new Faker<Address>()
                .RuleFor(x => x.House, x => x.Address.BuildingNumber())
                .RuleFor(x => x.Street, x => x.Address.StreetName())
                .RuleFor(x => x.PostalCode, x => x.Address.ZipCode())
                .RuleFor(x => x.StateCode, x => x.Address.StateAbbr())
                .RuleFor(x => x.CountryCode, x => x.Address.CountryCode())
                .RuleFor(x => x.County, x => x.Address.County())
                .RuleFor(x => x.State, x => x.Address.State())
                .RuleFor(x => x.Country, x => x.PickRandom(countryList));

            var result = JsonSerializer.Serialize(address.Generate());
            return result;
        }
    }
}