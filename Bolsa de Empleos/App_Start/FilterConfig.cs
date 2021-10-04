using System.Web;
using System.Web.Mvc;

namespace Bolsa_de_Empleos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
