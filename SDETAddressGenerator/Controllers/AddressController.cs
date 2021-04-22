using Microsoft.AspNetCore.Mvc;
using SDETAddressGenerator.Controllers.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDETAddressGenerator.Controllers
{
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository _repository;

        public AddressController(IAddressRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet("/randomizer/address")]
        public IActionResult Address()
        {
            var result = _repository.GetRandomAddress();

            return Ok(result);
        }
    }
}