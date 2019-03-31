using Abp.Web.Mvc.Views;

namespace WENTE.Web.Views
{
    public abstract class WENTEWebViewPageBase : WENTEWebViewPageBase<dynamic>
    {

    }

    public abstract class WENTEWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WENTEWebViewPageBase()
        {
            LocalizationSourceName = WENTEConsts.LocalizationSourceName;
        }
    }
}