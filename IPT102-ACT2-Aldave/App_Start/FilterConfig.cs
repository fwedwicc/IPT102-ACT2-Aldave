using System.Web;
using System.Web.Mvc;

namespace IPT102_ACT2_Aldave
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
