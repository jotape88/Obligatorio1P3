using System.Web;
using System.Web.Mvc;

namespace WebObligatorio_1_P3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
