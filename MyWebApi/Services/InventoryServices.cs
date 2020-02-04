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

        private InventoryContext _context;

        public InventoryServices(InventoryContext context)
        {
            _context = context; 
        }
        
       
        public InventoryItem AddInventoryItems(InventoryItem items)
        {
            _context.InventoryItems.Add( items);

            _context.SaveChanges();

            return items;
        }

        public IEnumerable<InventoryItem> GetInventoryItems()
        {
            return _context.InventoryItems;
        }
    }
}
