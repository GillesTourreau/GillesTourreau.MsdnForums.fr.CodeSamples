using System.Web;
using System.Web.Mvc;

namespace _65587b38_3a8e_4d2c_bd5e_c62cebb4d61d
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}