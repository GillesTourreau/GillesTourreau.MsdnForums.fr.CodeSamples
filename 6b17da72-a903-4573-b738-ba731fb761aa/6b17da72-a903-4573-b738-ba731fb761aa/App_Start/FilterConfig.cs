using System.Web;
using System.Web.Mvc;

namespace _6b17da72_a903_4573_b738_ba731fb761aa
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}