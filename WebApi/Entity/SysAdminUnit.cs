using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Entity
{
    [Serializable]
    public class SysAdminUnit
    {
        public List<Item> items { get; set; }
        public SysAdminUnit()
        {
            items = new List<Item>();
        }
    }
    [Serializable]
    public class Item
    {
        public string Name { get; set; }
    }
}