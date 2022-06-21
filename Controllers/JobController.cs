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
	public class JobController : Controller
	{
		private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

		public IActionResult Index(int id)//by category id
		{
			List<tbl_job> list = db.tbl_job.Where(x => x.status != "V").ToList();
			ViewBag.Title = "All Temporary & Part time";
			ViewBag.location = db.tbl_location.ToList();
			if (id != 0)
			{
				var checkExist = db.tbl_category_j.Find(id);
				if (checkExist != null)
				{
					ViewBag.Title = "Temporary & Part time (" + db.tbl_category_j.Where(x => x.id == id).Select(x => x.name).FirstOrDefault() + ")";
					List<int> job_ids = db.tbl_job_categories.Where(x => x.category_id == id).Select(x => x.job_id).ToList();
					list = list.Where(x => job_ids.Any(a => a == x.id)).ToList();
				}
			}
			List<vm_Job> models = GetViewModel(list);
			return View("grid", models);
		}

		public IActionResult My()
		{
			ViewBag.Title = "My Job Posts";
			string userid = HttpContext.Session.GetString("USERID").ToString();
			var list = db.tbl_job.Where(x => x.status != "V" && x.created_by == userid).ToList();
			List<vm_Job> models = GetViewModel(list);
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_j.ToList();
			return View("table", models);
		}

		public IActionResult All()
		{
			ViewBag.Title = "All Job Posts";
			var list = db.tbl_job.Where(x => x.status != "V").ToList();
			List<vm_Job> models = GetViewModel(list);
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_j.ToList();
			return View("table", models);
		}

		public List<vm_Job> GetViewModel(List<tbl_job> list)
		{
			List<vm_Job> models = (from d in list
														 select new vm_Job()
														 {
															 JOB = d,
															 imagesFilePath = db.tbl_job_images.Where(x => x.job_id == d.id).Select(x => x.file_path).ToList(),
															 cate_ids = db.tbl_job_categories.Where(x => x.job_id == d.id).Select(x => x.category_id).ToList(),
															 APPLICATION = db.tbl_job_applications.Where(x => x.status != "V" && x.job_id == d.id).ToList(),
														 }).ToList();
			return models;
		}

		public IActionResult Detail(int? id)//by job id
		{
			if (id == null)
			{
				return RedirectToAction("Index", "Home");
			}
			tbl_job item = db.tbl_job.Find(id);
			if (item == null)
			{
				return RedirectToAction("Index", "Home");
			}
			ViewBag.category = db.tbl_category_j.ToList();
			ViewBag.location = db.tbl_location.ToList();

			List<tbl_job> list = new List<tbl_job>();
			list.Add(item);
			vm_Job model = GetViewModel(list).FirstOrDefault();
			return View(model);
		}

		public IActionResult Search(string query, int category, int location)
		{
			string location_name = db.tbl_location.Find(location) == null ? "All Location" : db.tbl_location.Find(location).name;
			string category_name = db.tbl_category_j.Find(category) == null ? "All Category" : db.tbl_category_j.Find(category).name;

			ViewBag.Title = "Search (" + category_name + ") Jobs in " + location_name + (string.IsNullOrEmpty(query) ? "" : ": " + query);
			ViewBag.location = db.tbl_location.ToList();

			List<int> jobIDListInThisCategory = db.tbl_job_categories.Where(x => x.category_id == category || category == 0).Select(x => x.job_id).ToList();
			List<tbl_job> list = db.tbl_job.Where(x => x.status != "V" && x.is_publish && jobIDListInThisCategory.Any(a => a == x.id) && (x.location_id == location || location == 0)).ToList();
			List<vm_Job> models = GetViewModel(list);

			if (string.IsNullOrEmpty(query))
			{
				return View("grid", models);
			}
			else
			{
				List<vm_Job> matchedModels = new List<vm_Job>();
				List<int> all_match_ids = new List<int>();
				List<string> keywords = query.Split(' ').ToList().Select(x => x.Trim().ToLower()).Distinct().ToList();
				foreach (var k in keywords)
				{
					var match_ids = models
						.Where(x =>
						(x.JOB.name != null && x.JOB.name.ToLower().Contains(k))
						||
						(x.JOB.content != null && x.JOB.content.ToLower().Contains(k))
						)
						.Select(x => x.JOB.id).Distinct().ToList();
					all_match_ids.AddRange(match_ids);
				}
				var JOB_id_appear = (from d in all_match_ids
														 group d by new { id = d } into grp
														 select new { grp.Key.id, occurrence = grp.Count() }
														 ).OrderByDescending(x => x.occurrence).ToList();
				matchedModels = (from d in models
												 where JOB_id_appear.Any(a => a.id == d.JOB.id)
												 select new
												 {
													 item = d,
													 occurrence = JOB_id_appear.Where(x => x.id == d.JOB.id).Select(x => x.occurrence).FirstOrDefault(),
												 }).OrderByDescending(x => x.occurrence).ToList()
												 .Select(x => x.item).ToList();
				return View("grid", matchedModels);
			}
		}


		public IActionResult Create()
		{
			ViewBag.category = db.tbl_category_j.ToList();
			ViewBag.location = db.tbl_location.ToList();
			return View();
		}

		[HttpPost]
		public string Create(vm_ManageJob model)
		{
			string ErrorMessage = "";
			try
			{
				db.tbl_job.Add(model.JOB);
				db.SaveChanges();

				//_category -- add new record
				model.cate_ids = model.cate_ids == null ? new List<int>() : model.cate_ids;
				List<tbl_job_categories> tobeAdded_cate = (from s in model.cate_ids
																									 select new tbl_job_categories()
																									 {
																										 category_id = s,
																										 job_id = model.JOB.id,
																									 }).ToList();
				db.tbl_job_categories.AddRange(tobeAdded_cate);
				db.SaveChanges();

				//DETECT IF GOT ANY IMAGES ATTACHED
				if (model.FILES != null && model.FILES.Count > 0 && model.FILES[0] != null)
				{
					int c = 0;
					foreach (var i in model.FILES)
					{
						string FileName = i.FileName;
						string FileExtension = Path.GetExtension(FileName);
						string FilenameWithoutExtension = model.JOB.id.ToString() + "_" + c.ToString();
						string uniquemarking = "_" + Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss");
						string newName = FilenameWithoutExtension + uniquemarking + FileExtension;
						string url = new HomeController().UploadStorage(i, newName, "job");

						//SAVE INTO IMAGE TABLE
						tbl_job_images img = new tbl_job_images();
						img.job_id = model.JOB.id;
						img.file_path = url;
						db.tbl_job_images.Add(img);
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
			tbl_job item = db.tbl_job.Find(id);
			if (item == null)
			{
				return RedirectToAction("Index", "Home");
			}
			ViewBag.category = db.tbl_category_j.ToList();
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.IMGs = db.tbl_job_images.Where(x => x.job_id == id).ToList();
			vm_ManageJob model = new vm_ManageJob();
			model.JOB = item;
			model.ids_keptImg = db.tbl_job_images.Where(x => x.job_id == id).Select(x => x.id).ToList();
			model.cate_ids = db.tbl_job_categories.Where(x => x.job_id == id).Select(x => x.category_id).Distinct().ToList();
			return View(model);
		}


		[HttpPost]
		public string Edit(vm_ManageJob model)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_job.Find(model.JOB.id);
				if (checkExist == null)
				{
					ErrorMessage = "Job ID (" + model.JOB.id + ") doesn't exist in the system database.";
				}
				else
				{
					checkExist.edited_by = model.JOB.edited_by;
					checkExist.edited_date = model.JOB.edited_date;

					checkExist.name = model.JOB.name;
					checkExist.salary = model.JOB.salary;
					checkExist.content = model.JOB.content;
					checkExist.is_publish = model.JOB.is_publish;
					checkExist.location_id = model.JOB.location_id;
					db.SaveChanges();

					model.cate_ids = model.cate_ids == null ? new List<int>() : model.cate_ids;
					//_category -- remove unwanted record
					var curr_job_cate = db.tbl_job_categories.Where(x => x.job_id == model.JOB.id).ToList();
					var tobeDeleted_cate = curr_job_cate.Where(x => !model.cate_ids.Any(a => a == x.category_id)).ToList();
					db.tbl_job_categories.RemoveRange(tobeDeleted_cate);
					db.SaveChanges();
					//_category -- add new record
					List<tbl_job_categories> chosen_cate = (from s in model.cate_ids
																									select new tbl_job_categories()
																									{
																										category_id = s,
																										job_id = model.JOB.id,
																									}).ToList();
					var tobeAdded_cate = chosen_cate.Where(x => !curr_job_cate.Any(a => a.category_id == x.category_id)).ToList();
					db.tbl_job_categories.AddRange(tobeAdded_cate);
					db.SaveChanges();

					//delete if old images is deleted
					var currDB = db.tbl_job_images.Where(x => x.job_id == model.JOB.id).ToList();
					model.ids_keptImg = model.ids_keptImg == null ? new List<int>() : model.ids_keptImg;
					var tobeDeleted = currDB.Where(x => !model.ids_keptImg.Any(a => a == x.id)).ToList();
					//delete old images from db
					db.tbl_job_images.RemoveRange(tobeDeleted);
					db.SaveChanges();


					//DETECT IF GOT ANY IMAGES ATTACHED
					if (model.FILES != null && model.FILES.Count > 0 && model.FILES[0] != null)
					{
						int c = 0;
						foreach (var i in model.FILES)
						{
							string FileName = i.FileName;
							string FileExtension = Path.GetExtension(FileName);
							string FilenameWithoutExtension = model.JOB.id.ToString() + "_" + c.ToString();
							string uniquemarking = "_" + Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss");
							string newName = FilenameWithoutExtension + uniquemarking + FileExtension;
							string url = new HomeController().UploadStorage(i, newName, "job");

							//SAVE INTO IMG TABLE
							tbl_job_images img = new tbl_job_images();
							img.job_id = model.JOB.id;
							img.file_path = url;
							db.tbl_job_images.Add(img);
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
			return ErrorMessage;
		}

		public string Delete(int? id)
		{
			string ErrorMessage = "";
			string userid = HttpContext.Session.GetString("USERID").ToString();
			try
			{
				var checkExist = db.tbl_job.Find(id);
				if (checkExist == null)
				{
					ErrorMessage = "Job ID (" + id + ") doesn't exist in the system database.";
				}
				else
				{
					var record = db.tbl_job.Find(id);
					record.status = "V";
					record.edited_by = userid;
					record.edited_date = DateTime.Now;
					//also delete categories record
					var tobeDeleted = db.tbl_job_categories.Where(x => x.job_id == id).ToList();
					db.tbl_job_categories.RemoveRange(tobeDeleted);
					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			return ErrorMessage;
		}


		public IActionResult Employer(string id)
		{
			ViewBag.Title = "Jobs by all employers";
			ViewBag.location = db.tbl_location.ToList();
			List<tbl_job> list = db.tbl_job.Where(x => x.status != "V" && x.is_publish).ToList();
			List<vm_Job> models = new List<vm_Job>();
			if (id != "0")
			{
				var checkExist = db.tbl_user_profile.Find(id);
				if (checkExist != null)
				{
					ViewBag.Title = "Jobs by " + checkExist.real_name;
					list = list.Where(x => x.created_by == checkExist.userid).ToList();
				}
			}
			models = GetViewModel(list);
			return View("grid", models);
		}


	}
}
