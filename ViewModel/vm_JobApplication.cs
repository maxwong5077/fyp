using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyJobHunter.Models;

namespace EasyJobHunter.ViewModel
{
	public class vm_JobApplication
	{
		public tbl_job_applications APPLICATION { get; set; }
		public tbl_job JOB { get; set; }
		public List<int> CATEGORIES { get; set; }
		public List<string> IMAGEPATHS { get; set; }
	}
}