using System.Web;
using System.Web.Mvc;

namespace Ediz_Yurdakul_ST10242585_CLDV6211_POE_Part_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
