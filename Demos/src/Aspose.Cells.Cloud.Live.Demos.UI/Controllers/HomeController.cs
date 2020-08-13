using Aspose.Cells.Cloud.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Cells.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Read, Write, View &amp; Convert Spreadsheets (via C# REST SDK)";
			ViewBag.MetaDescription = "Aspose.Cells Cloud SDK for .NET allows developers to read excel spreadsheets from cloud storage, modify, view &amp; convert them using C# or other .NET languages.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
