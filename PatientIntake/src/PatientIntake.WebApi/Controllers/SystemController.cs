using System;
using System.Net;
using System.Net.Sockets;
using System.Web.Http;
using PatientIntake.Core.Models;

namespace PatientIntake.WebApi.Controllers
{
    [RoutePrefix("api/system")]
    public class SystemController : ApiController
    {
        [Route("time")]
        public DateTimeOffset GetSystemTime()
        {
            return DateTimeOffset.Now;
        }

        [Route("name")]
        public string GetSystemName()
        {
            return Environment.MachineName;
        }

        [Route("ipaddress")]
        public string GetSystemIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Local IP Address Not Found!";
        }

        [Route("info")]
        public SystemInformation GetAllSystemInfo()
        {
            return new SystemInformation
            {
                Name = GetSystemName(),
                Time = GetSystemTime(),
                IpAddress = GetSystemIpAddress()
            };
        }
    }
}