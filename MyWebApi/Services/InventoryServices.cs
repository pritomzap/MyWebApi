using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Services
{
    public class InventoryServices : IInventoryServices
    {
        private readonly Dictionary<string,InventoryItem> _inventoryItems;

        public InventoryServices()
        {
            _inventoryItems = new Dictionary<string, InventoryItem>();
        }

        public InventoryItem AddInventoryItems(InventoryItem items)
        {
            _inventoryItems.Add(items.Name, items);

            return items;
        }

        public Dictionary<string, InventoryItem> GetInventoryItems()
        {
            return _inventoryItems;
        }
    }
}
