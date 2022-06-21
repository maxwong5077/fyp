using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyJobHunter.Models;
using EasyJobHunter.ViewModel;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EasyJobHunter.Controllers
{
	public class ServiceController : Controller
	{
		private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

		public IActionResult Main()
		{
			ViewBag.carousel = db.tbl_carousel_image.Where(x => x.module == "SERVICE").ToList();
			ViewBag.location = db.tbl_location.ToList();
			var models = db.tbl_category_s.ToList();
			return View(models);
		}

		public IActionResult Index(int id)//by category id
		{
			List<tbl_service> list = db.tbl_service.Where(x => x.status != "V").ToList();
			ViewBag.Title = "All Micro Jobs";
			ViewBag.location = db.tbl_location.ToList();
			if (id != 0)
			{
				var checkExist = db.tbl_category_s.Find(id);
				if (checkExist != null)
				{
					ViewBag.Title = "Micro Jobs (" + db.tbl_category_s.Where(x => x.id == id).Select(x => x.name).FirstOrDefault() + ")";
					List<int> service_ids = db.tbl_service_categories.Where(x => x.category_id == id).Select(x => x.service_id).ToList();
					list = list.Where(x => service_ids.Any(a => a == x.id)).ToList();
				}
			}
			List<vm_Service> models = GetViewModel(list);
			return View("grid", models);
		}

		public IActionResult My()
		{
			ViewBag.Title = "My Micro Job Posts";
			string userid = HttpContext.Session.GetString("USERID").ToString();
			var list = db.tbl_service.Where(x => x.status != "V" && x.created_by == userid).ToList();
			List<vm_Service> models = GetViewModel(list);
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_s.ToList();
			return View("table", models);
		}

		public IActionResult All()
		{
			ViewBag.Title = "All Micro Job Posts";
			var list = db.tbl_service.Where(x => x.status != "V").ToList();
			List<vm_Service> models = GetViewModel(list);
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_s.ToList();
			return View("table", models);
		}

		public List<vm_Service> GetViewModel(List<tbl_service> list)
		{
			List<vm_Service> models = (from d in list
														 select new vm_Service()
														 {
															 SERVICE = d,
															 imagesFilePath = db.tbl_service_images.Where(x => x.service_id == d.id).Select(x => x.file_path).ToList(),
															 cate_ids = db.tbl_service_categories.Where(x => x.service_id == d.id).Select(x => x.category_id).ToList(),
															 APPLICATION = db.tbl_service_applications.Where(x => x.status != "V" && x.service_id == d.id).ToList(),
														 }).ToList();
			return models;
		}

		public IActionResult Detail(int? id)//by service id
		{
			if (id == null)
			{
				return RedirectToAction("Index", "Home");
			}
			tbl_service item = db.tbl_service.Find(id);
			if (item == null)
			{
				return RedirectToAction("Index", "Home");
			}
			ViewBag.category = db.tbl_category_s.ToList();
			ViewBag.location = db.tbl_location.ToList();

			List<tbl_service> list = new List<tbl_service>();
			list.Add(item);
			vm_Service model = GetViewModel(list).FirstOrDefault();
			return View(model);
		}

		public IActionResult Search(string query, int category, int location)
		{
			string location_name = db.tbl_location.Find(location) == null ? "All Location" : db.tbl_location.Find(location).name;
			string category_name = db.tbl_category_s.Find(category) == null ? "All Category" : db.tbl_category_s.Find(category).name;

			ViewBag.Title = "Search (" + category_name + ") Micro Jobs in " + location_name + (string.IsNullOrEmpty(query) ? "" : ": " + query);
			ViewBag.location = db.tbl_location.ToList();

			List<int> serviceIDListInThisCategory = db.tbl_service_categories.Where(x => x.category_id == category || category == 0).Select(x => x.service_id).ToList();
			List<tbl_service> list = db.tbl_service.Where(x => x.status != "V" && x.is_publish && serviceIDListInThisCategory.Any(a => a == x.id) && (x.location_id == location || location == 0)).ToList();
			List<vm_Service> models = GetViewModel(list);

			if (string.IsNullOrEmpty(query))
			{
				return View("grid", models);
			}
			else
			{
				List<vm_Service> matchedModels = new List<vm_Service>();
				List<int> all_match_ids = new List<int>();
				List<string> keywords = query.Split(' ').ToList().Select(x => x.Trim().ToLower()).Distinct().ToList();
				foreach (var k in keywords)
				{
					var match_ids = models
						.Where(x =>
						(x.SERVICE.name != null && x.SERVICE.name.ToLower().Contains(k))
						||
						(x.SERVICE.content != null && x.SERVICE.content.ToLower().Contains(k))
						)
						.Select(x => x.SERVICE.id).Distinct().ToList();
					all_match_ids.AddRange(match_ids);
				}
				var SERVICE_id_appear = (from d in all_match_ids
																 group d by new { id = d } into grp
																 select new { grp.Key.id, occurrence = grp.Count() }
														 ).OrderByDescending(x => x.occurrence).ToList();
				matchedModels = (from d in models
												 where SERVICE_id_appear.Any(a => a.id == d.SERVICE.id)
												 select new
												 {
													 item = d,
													 occurrence = SERVICE_id_appear.Where(x => x.id == d.SERVICE.id).Select(x => x.occurrence).FirstOrDefault(),
												 }).OrderByDescending(x => x.occurrence).ToList()
												 .Select(x => x.item).ToList();
				return View("grid", matchedModels);
			}			
		}


		public IActionResult Create()
		{
			ViewBag.category = db.tbl_category_s.ToList();
			ViewBag.location = db.tbl_location.ToList();
			return View();
		}

		[HttpPost]
		public string Create(vm_ManageService model)
		{
			string ErrorMessage = "";
			try
			{
				db.tbl_service.Add(model.SERVICE);
				db.SaveChanges();

				//_category -- add new record
				model.cate_ids = model.cate_ids == null ? new List<int>() : model.cate_ids;
				List<tbl_service_categories> tobeAdded_cate = (from s in model.cate_ids
																									 select new tbl_service_categories()
																									 {
																										 category_id = s,
																										 service_id = model.SERVICE.id,
																									 }).ToList();
				db.tbl_service_categories.AddRange(tobeAdded_cate);
				db.SaveChanges();

				//DETECT IF GOT ANY IMAGES ATTACHED
				if (model.FILES != null && model.FILES.Count > 0 && model.FILES[0] != null)
				{
					int c = 0;
					foreach (var i in model.FILES)
					{
						string FileName = i.FileName;
						string FileExtension = Path.GetExtension(FileName);
						string FilenameWithoutExtension = model.SERVICE.id.ToString() + "_" + c.ToString();
						string uniquemarking = "_" + Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss");
						string newName = FilenameWithoutExtension + uniquemarking + FileExtension;
						string url = new HomeController().UploadStorage(i, newName, "service");

						//SAVE INTO IMAGE TABLE
						tbl_service_images img = new tbl_service_images();
						img.service_id = model.SERVICE.id;
						img.file_path = url;
						db.tbl_service_images.Add(img);
						db.SaveChanges();

						c++;
					}//end foreach (var i in model.FILES)
				}//end if(model.FILES!=null && model.FILES.Count > 0)
			}// end try
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			return ErrorMessage;
		}


		public IActionResult Edit(int? id)
		{
			if (id == null)
			{
				return RedirectToAction("Index", "Home");
			}
			tbl_service item = db.tbl_service.Find(id);
			if (item == null)
			{
				return RedirectToAction("Index", "Home");
			}
			ViewBag.category = db.tbl_category_s.ToList();
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.IMGs = db.tbl_service_images.Where(x => x.service_id == id).ToList();
			vm_ManageService model = new vm_ManageService();
			model.SERVICE = item;
			model.ids_keptImg = db.tbl_service_images.Where(x => x.service_id == id).Select(x => x.id).ToList();
			model.cate_ids = db.tbl_service_categories.Where(x => x.service_id == id).Select(x => x.category_id).Distinct().ToList();
			return View(model);
		}


		[HttpPost]
		public string Edit(vm_ManageService model)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_service.Find(model.SERVICE.id);
				if (checkExist == null)
				{
					ErrorMessage = "Service ID (" + model.SERVICE.id + ") doesn't exist in the system database.";
				}
				else
				{
					checkExist.edited_by = model.SERVICE.edited_by;
					checkExist.edited_date = model.SERVICE.edited_date;

					checkExist.name = model.SERVICE.name;
					checkExist.price = model.SERVICE.price;
					checkExist.content = model.SERVICE.content;
					checkExist.is_publish = model.SERVICE.is_publish;
					checkExist.location_id = model.SERVICE.location_id;
					db.SaveChanges();

					model.cate_ids = model.cate_ids == null ? new List<int>() : model.cate_ids;
					//_category -- remove unwanted record
					var curr_service_cate = db.tbl_service_categories.Where(x => x.service_id == model.SERVICE.id).ToList();
					var tobeDeleted_cate = curr_service_cate.Where(x => !model.cate_ids.Any(a => a == x.category_id)).ToList();
					db.tbl_service_categories.RemoveRange(tobeDeleted_cate);
					db.SaveChanges();
					//_category -- add new record
					List<tbl_service_categories> chosen_cate = (from s in model.cate_ids
																									select new tbl_service_categories()
																									{
																										category_id = s,
																										service_id = model.SERVICE.id,
																									}).ToList();
					var tobeAdded_cate = chosen_cate.Where(x => !curr_service_cate.Any(a => a.category_id == x.category_id)).ToList();
					db.tbl_service_categories.AddRange(tobeAdded_cate);
					db.SaveChanges();

					//delete if old images is deleted
					var currDB = db.tbl_service_images.Where(x => x.service_id == model.SERVICE.id).ToList();
					model.ids_keptImg = model.ids_keptImg == null ? new List<int>() : model.ids_keptImg;
					var tobeDeleted = currDB.Where(x => !model.ids_keptImg.Any(a => a == x.id)).ToList();
					//delete old images from db
					db.tbl_service_images.RemoveRange(tobeDeleted);
					db.SaveChanges();


					//DETECT IF GOT ANY IMAGES ATTACHED
					if (model.FILES != null && model.FILES.Count > 0 && model.FILES[0] != null)
					{
						int c = 0;
						foreach (var i in model.FILES)
						{
							string FileName = i.FileName;
							string FileExtension = Path.GetExtension(FileName);
							string FilenameWithoutExtension = model.SERVICE.id.ToString() + "_" + c.ToString();
							string uniquemarking = "_" + Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss");
							string newName = FilenameWithoutExtension + uniquemarking + FileExtension;
							string url = new HomeController().UploadStorage(i, newName, "service");

							//SAVE INTO record_IMG TABLE
							tbl_service_images img = new tbl_service_images();
							img.service_id = model.SERVICE.id;
							img.file_path = url;
							db.tbl_service_images.Add(img);
							db.SaveChanges();

							c++;
						}//end foreach (var i in model.FILES)
					}//end if(model.FILES!=null && model.FILES.Count > 0)


				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			//return Json(new JsonResult);
			//return Json(ErrorMessage, new Newtonsoft.Json.JsonSerializerSettings());
			return ErrorMessage;
		}

		public string Delete(int? id)
		{
			string ErrorMessage = "";
			string userid = HttpContext.Session.GetString("USERID").ToString();
			try
			{
				var checkExist = db.tbl_service.Find(id);
				if (checkExist == null)
				{
					ErrorMessage = "Service ID (" + id + ") doesn't exist in the system database.";
				}
				else
				{
					var record = db.tbl_service.Find(id);
					record.status = "V";
					record.edited_by = userid;
					record.edited_date = DateTime.Now;
					//also delete categories record
					var tobeDeleted = db.tbl_service_categories.Where(x => x.service_id == id).ToList();
					db.tbl_service_categories.RemoveRange(tobeDeleted);
					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			return ErrorMessage;
		}

		public IActionResult Provider(string id)
		{
			ViewBag.Title = "Micro Jobs by all providers";
			ViewBag.location = db.tbl_location.ToList();
			List<tbl_service> list = db.tbl_service.Where(x => x.status != "V" && x.is_publish).ToList();
			List<vm_Service> models = new List<vm_Service>();
			if (id != "0")
			{
				var checkExist = db.tbl_user_profile.Find(id);
				if (checkExist != null)
				{
					ViewBag.Title = "Micro Jobs by " + checkExist.real_name;
					list = list.Where(x => x.created_by == checkExist.userid).ToList();
				}
			}
			models = GetViewModel(list);
			return View("grid", models);
		}

	}
}
