using System.Web;
using System.Web.Mvc;

namespace Comp2007_week9_lesson9c
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
