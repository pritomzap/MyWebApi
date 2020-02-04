using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Models;
using MyWebApi.Services;

//https://localhost:44306/v1/AddInventoryItems

namespace MyWebApi.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryServices _services;

        public InventoryController(IInventoryServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("AddInventoryItems")]
        public async Task<IActionResult> AddInventoryItems([FromBody]InventoryItem items)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var inventoryItems = _services.AddInventoryItems(items);

            return Ok(inventoryItems);

        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public IEnumerable<InventoryItem> GetInventoryItems()
        {
            var inventoryItems = _services.GetInventoryItems();

            return inventoryItems;
        }

    }
}