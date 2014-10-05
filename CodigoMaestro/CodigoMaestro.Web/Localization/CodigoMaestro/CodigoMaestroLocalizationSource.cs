using System.Web;
using Abp.Localization.Sources.Xml;

namespace CodigoMaestro.Web.Localization.CodigoMaestro
{
    public class CodigoMaestroLocalizationSource : XmlLocalizationSource
    {
        public CodigoMaestroLocalizationSource()
            : base("CodigoMaestro", HttpContext.Current.Server.MapPath("/Localization/CodigoMaestro"))
        {
        }
    }
}