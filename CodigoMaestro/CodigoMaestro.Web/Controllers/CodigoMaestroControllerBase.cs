using Abp.Web.Mvc.Controllers;

namespace CodigoMaestro.Web.Controllers
{
    public abstract class CodigoMaestroControllerBase : AbpController
    {
        protected CodigoMaestroControllerBase()
        {
            LocalizationSourceName = "CodigoMaestro";
        }
    }
}