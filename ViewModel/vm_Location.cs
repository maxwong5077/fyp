using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyJobHunter.Models;
using Microsoft.AspNetCore.Http;

namespace EasyJobHunter.ViewModel
{
	public class vm_Location
	{
		public tbl_location LOCATION { get; set; }
		public int dependent_j { get; set; }
		public int dependent_s { get; set; }
	}

}