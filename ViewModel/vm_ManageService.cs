using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Http;
using EasyJobHunter.Models;

namespace EasyJobHunter.ViewModel
{
	public class vm_ManageService
	{
		public tbl_service SERVICE { get; set; }
		public List<IFormFile> FILES { get; set; }
		public List<int> ids_keptImg { get; set; }
		public List<int> cate_ids { get; set; }
	}

}