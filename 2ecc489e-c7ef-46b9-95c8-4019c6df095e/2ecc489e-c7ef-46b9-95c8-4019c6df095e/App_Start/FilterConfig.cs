using System.Web;
using System.Web.Mvc;

namespace _2ecc489e_c7ef_46b9_95c8_4019c6df095e
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}