using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyJobHunter.Models;

namespace EasyJobHunter.ViewModel
{
	public class vm_Service
	{
		public tbl_service SERVICE { get; set; }
		public List<string> imagesFilePath { get; set; }
		public List<int> cate_ids { get; set; }
		public List<tbl_service_applications> APPLICATION { get; set; }
	}

}