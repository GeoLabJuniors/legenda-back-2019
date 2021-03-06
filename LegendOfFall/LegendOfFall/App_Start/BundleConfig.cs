﻿using System.Web.Optimization;

namespace LegendOfFall
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(                                                
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/admin-panel.js",
                        "~/Scripts/ckeditor/ckeditor.js"
                ));

            bundles.Add(new StyleBundle("~/bundles/mystyles").Include(
                        "~/Content/assets/css/reset.css",
                        "~/Content/assets/css/layout-style.css"                        
                ));

            bundles.Add(new StyleBundle("~/bundles/wrappedstyles").Include(
                        "~/Content/assets/css/materialize.min.css",
                        "~/Content/assets/css/font-awesome.min.css",
                        "~/Content/assets/css/owl.carousel.min.css",
                        "~/Content/assets/css/owl.theme.default.min.css",
                        "~/Content/assets/css/simplelightbox.min.css",
                        "~/Content/assets/css/style.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/ckeditor").Include("~/Scripts/ckeditor/ckeditor.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
