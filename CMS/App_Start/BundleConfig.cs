using System.Web;
using System.Web.Optimization;

namespace CMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Vendor/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Vendor/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Vendor/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Vendor/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/template").Include(
                "~/Content/template/assets/scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                //"~/Scripts/account.js"
                //"~/Scripts/alerts.js",
                //"~/Scripts/chat.js",
                //"~/Scripts/checkout.js",
                //"~/Scripts/config.js",
                //"~/Scripts/country.js",
                "~/Scripts/delete-list-item.js"
                //"~/Scripts/login.js",
                //"~/Scripts/mapbox.js",
                //"~/Scripts/index.js"
                ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/template.css",
                      "~/Content/css/bootstrap-overrides.css",
                      "~/Content/css/template-overrides.css",
                      "~/Content/css/style.css"));
        }
    }
}
