using System.Web;
using System.Web.Mvc;

namespace KiemTra_NguyenDangLinh_1911065607
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
