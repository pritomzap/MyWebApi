using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Services
{
    interface IInventoryServices
    {
        InventoryItem AddInventoryItems(InventoryItem items);
        Dictionary<string,InventoryItem> GetInventoryItems();
    }
}
