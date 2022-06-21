using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyJobHunter.Models;
using Microsoft.AspNetCore.Http;

namespace EasyJobHunter.ViewModel
{
	public class vm_Carousel
	{
		public List<tbl_carousel_image> cAROUSEL { get; set; }
		//for form
		public List<IFormFile> FILES { get; set; }
		public List<int> ids_keptImg { get; set; }
	}

}