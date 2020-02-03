using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Services
{
    public class InventoryServices : IInventoryServices
    {
        //private readonly Dictionary<string,InventoryItem> _inventoryItems;

       

        public InventoryServices()
        {
            
        }

        public InventoryContext context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public InventoryItem AddInventoryItems(InventoryItem items)
        {
            context.InventoryItems.Add( items);

            return items;
        }

        public IEnumerable<InventoryItem> GetInventoryItems()
        {
            return context.InventoryItems;
        }
    }
}
