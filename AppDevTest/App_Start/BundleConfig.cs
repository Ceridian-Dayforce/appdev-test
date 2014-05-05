﻿using System.Web;
using System.Web.Optimization;

namespace AppDevTest
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			BundleTable.EnableOptimizations = true;
			bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/*.css"));
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));
		}
	}
}
