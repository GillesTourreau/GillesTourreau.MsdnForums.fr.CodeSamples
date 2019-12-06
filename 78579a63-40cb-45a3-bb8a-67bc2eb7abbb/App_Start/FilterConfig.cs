using System.Web;
using System.Web.Mvc;

namespace _78579a63_40cb_45a3_bb8a_67bc2eb7abbb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}