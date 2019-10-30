using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudOperation.Models;
using Microsoft.AspNetCore.Mvc;
using static CrudOperation.Models.VendorRepository;

namespace CrudOperation.Controllers
{
    [Produces("application/json")]
    [Route("api/Vendor")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorRepository _gameRepository;
        public VendorController(IVendorRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
      

        [HttpPost]
        public async Task<IActionResult> post([FromBody]Vendor vender)
        {
            await _gameRepository.Create(vender);
            return new OkObjectResult(vender);
        }
       

    }
}
