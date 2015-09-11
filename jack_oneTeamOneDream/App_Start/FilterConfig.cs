using System.Web;
using System.Web.Mvc;

namespace jack_oneTeamOneDream
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
