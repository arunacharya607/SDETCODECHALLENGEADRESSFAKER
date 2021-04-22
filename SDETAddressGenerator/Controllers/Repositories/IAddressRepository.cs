using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDETAddressGenerator.Controllers.Repositories
{
    public interface IAddressRepository
    {
        string GetRandomAddress();
    }
}