using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using WebApi.Entity;
using WebApi.Infrastructure;

namespace WebApi.Controllers
{
    public class WebApiController : Controller
    {
        [HttpPost]
        public string GetUserId(XDocument xml)
        {
            var logins = CustomSerializer.Deserializ<SysAdminUnit>(new MemoryStream(Encoding.UTF8.GetBytes(xml.ToString() ?? "")));
            var respond = new SysAdminUnitResponed();
            foreach (var login in logins.items)
            {
                respond.items.Add(new ItemRespond() { ErrorCode = 1, ErrorDescription = "error1", IsSuccess = true, UserOneCGuid = Guid.NewGuid() });
            }
            var stream = CustomSerializer.Serializ(respond);
            var srteamReader = new StreamReader(stream);
            return srteamReader.ReadToEnd();
        }
    }
}