using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyJobHunter.Models;
using Microsoft.AspNetCore.Http;

namespace EasyJobHunter.ViewModel
{
	public class vm_Category_J
	{
		public tbl_category_j CATEGORY { get; set; }
		public IFormFile FILE { get; set; }
		public int dependent { get; set; }
	}

}