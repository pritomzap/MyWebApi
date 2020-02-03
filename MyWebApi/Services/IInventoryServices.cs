using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Services
{
    public interface IInventoryServices
    {
        public InventoryContext context { get; set; }
        InventoryItem AddInventoryItems(InventoryItem items);
        IEnumerable<InventoryItem> GetInventoryItems();
    }
}
