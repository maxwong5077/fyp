using Azure.Storage;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using EasyJobHunter.Models;
using EasyJobHunter.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EasyJobHunter.Controllers
{
  public class JobCarouselController : Controller
  {
    private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

    public IActionResult Index()
    {
      vm_Carousel model = new vm_Carousel();
      model.cAROUSEL = db.tbl_carousel_image.Where(x=>x.module == "JOB").ToList();
			model.ids_keptImg = model.cAROUSEL.Select(x => x.id).ToList();
			return View("Index", model);
    }

    [HttpPost]
    public string Edit(vm_Carousel model)
    {
      string ErrorMessage = "";
      try
			{
				//delete if old images is deleted
				var currDB = db.tbl_carousel_image.Where(x => x.module == "JOB").ToList();
				var tobeDeleted = currDB.Where(x => model.ids_keptImg == null || !model.ids_keptImg.Any(a => a == x.id)).ToList();
				db.tbl_carousel_image.RemoveRange(tobeDeleted);
				db.SaveChanges();

				//DETECT IF GOT ANY IMAGES ATTACHED
				if (model.FILES != null && model.FILES.Count > 0 && model.FILES[0] != null)
				{
					int c = 0;
					foreach (var i in model.FILES)
					{
						string FileName = i.FileName;
						string FileExtension = Path.GetExtension(FileName);
						string FilenameWithoutExtension = c.ToString();
						string uniquemarking = "_" + Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss");
						string newName = FilenameWithoutExtension + uniquemarking + FileExtension;
						string url = new HomeController().UploadStorage(i, newName, "carousel");
						//SAVE INTO IMG TABLE
						tbl_carousel_image IMG = new tbl_carousel_image();
						IMG.file_path = url;
						IMG.module = "JOB";
						db.tbl_carousel_image.Add(IMG);
						db.SaveChanges();
						c++;
					}//end foreach (var i in model.FILES)
				}//end if(model.FILES!=null && model.FILES.Count > 0)
			}
      catch (Exception ex)
      {
        ErrorMessage = ex.Message;
      }
      return ErrorMessage;
    }



  }
}
