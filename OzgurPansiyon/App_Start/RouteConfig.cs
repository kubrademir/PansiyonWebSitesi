using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OzgurPansiyon
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           
            routes.MapRoute("Anasayfa", "", new { controller = "Anasayfa", action = "Anasayfa" });
            routes.MapRoute("Mutfak", "mutfak", new { controller = "mutfak", action = "Mutfak" });
            routes.MapRoute("Ulaşım", "ulasim", new { controller = "ulasim", action = "Ulasim" });
            routes.MapRoute("İletişim", "iletisim", new { controller = "iletisim", action = "İletisim" });
            

        }
    }
}

