using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebApi.Entity
{
    [Serializable]
    [XmlRoot(ElementName = "SysAdminUnit")]
    public class SysAdminUnitResponed
    {
        [XmlElement(ElementName = "Item")]
        public List<ItemRespond> items { get; set; }
        public SysAdminUnitResponed()
        {
            items = new List<ItemRespond>();
        }
    }
    [Serializable]
    public class ItemRespond
    {
        public bool IsSuccess { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public Guid UserOneCGuid { get; set; }
    }
}