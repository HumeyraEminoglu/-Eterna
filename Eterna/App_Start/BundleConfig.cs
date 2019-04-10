using System.Web;
using System.Web.Optimization;

namespace Eterna
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            //bundles.Add(new ScriptBundle("~/js/mysite").Include("~/content/js/jquery.js").Include("~/content/js/jquery.easing.1.3.js").);


            bundles.Add(new ScriptBundle("~/js/mysite").IncludeDirectory("~/Content/js", "*.js", false));

            bundles.Add(new StyleBundle("~/css/MyCss").IncludeDirectory("~/Content/css", "*.css", false));
        }
    }
}
