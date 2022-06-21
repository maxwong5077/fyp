using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyJobHunter.Models;

namespace EasyJobHunter.ViewModel
{
	public class vm_Job
	{
		public tbl_job JOB { get; set; }
		public List<string> imagesFilePath { get; set; }
		public List<int> cate_ids { get; set; }
		public List<tbl_job_applications> APPLICATION { get; set; }
	}


}