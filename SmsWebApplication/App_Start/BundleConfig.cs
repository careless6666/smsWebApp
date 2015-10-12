using System.Web;
using System.Web.Optimization;

namespace SmsWebApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/s-scripts").Include(
                        "~/Scripts/Pages.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/bootstrap-toggle.min.js",
                      "~/Scripts/bootstrap-datetimepicker.min.js",
                      "~/Scripts/locales/bootstrap-datetimepicker.ru.js",
                      "~/Scripts/knockout-3.3.0.js",
                      "~/Scripts/knockout-custom.js",
                      "~/Scripts/knockout.mapping-latest.js",
                      "~/Scripts/jquery.ui.timepicker.js",
                      "~/Scripts/select2.min.js",
                      "~/Scripts/select2_locale_ru.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/s-styles.css",
                      "~/Content/bootstrap-toggle.min.css",
                      "~/Content/sidebar.css",
                      "~/Content/bootstrap-datetimepicker.min.css",
                      "~/Content/select2.css",
                      "~/Content/select2-bootstrap.css"));

        }
    }
}
