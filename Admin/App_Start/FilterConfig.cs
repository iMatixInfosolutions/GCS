using System.Web;
using System.Web.Mvc;

namespace Admin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new Admin.Filters.InitializeSimpleMembershipAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}