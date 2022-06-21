using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using EasyJobHunter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Store
{
	public static class Utilitarios
	{
		public static string GetSystemName()
		{
			return "Easy Job Hunter";
		}

		public static string IsLinkActive(this IHtmlHelper htmlHelper, string action, string  controller)
		{
			string routeController = htmlHelper.ViewContext.RouteData.Values["controller"].ToString();
			string routeAction = htmlHelper.ViewContext.RouteData.Values["action"].ToString();
			if(string.IsNullOrEmpty(action))
      {
				if (routeController == controller)
					return "active";
				else
					return "";
			}
			else
      {
				if (routeController == controller && routeAction == action)
					return "active";
				else
					return "";
			}
		}

	}

}