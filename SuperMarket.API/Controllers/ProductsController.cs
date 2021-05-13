using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperMarket.API.Domain.Models;
using SuperMarket.API.Domain.Services;

namespace SuperMarket.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Category Get()
        {
            Category myCat = new Category();
            myCat.Id = 123;
            myCat.Name = "Cheeses";
            CalculateCostService myCalc = new CalculateCostService();
            myCalc.calc(1,2);
            return myCat;

        }
    }
}
