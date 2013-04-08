using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

namespace SignalRTest
{
    public static class RegisterHubs
    {
        public static void Start()
        {
            // Register the default hubs route: ~/signalr/hubs
            RouteTable.Routes.MapHubs();
        }
    }
}
