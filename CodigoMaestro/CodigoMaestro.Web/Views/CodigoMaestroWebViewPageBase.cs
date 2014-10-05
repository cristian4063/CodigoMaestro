using Abp.Web.Mvc.Views;

namespace CodigoMaestro.Web.Views
{
    public abstract class CodigoMaestroWebViewPageBase : CodigoMaestroWebViewPageBase<dynamic>
    {

    }

    public abstract class CodigoMaestroWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CodigoMaestroWebViewPageBase()
        {
            LocalizationSourceName = "CodigoMaestro";
        }
    }
}