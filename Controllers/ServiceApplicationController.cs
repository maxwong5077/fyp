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
	public class ServiceApplicationController : Controller
	{
		private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

		public IActionResult Apply()//i apply
		{
			ViewBag.Title = "My service applications";
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_s.ToList();
			string userid = HttpContext.Session.GetString("USERID").ToString();
			var list = db.tbl_service_applications.Where(x => x.status != "V" && x.created_by == userid).ToList();
			List<vm_ServiceApplication> model = GetViewModel(list);
			return View("table", model);
		}

		public IActionResult Receive()//i receive
		{
			ViewBag.Title = "Service applications received";
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_s.ToList();
			string userid = HttpContext.Session.GetString("USERID").ToString();
			var list = db.tbl_service_applications.Where(x => x.status != "V" && x.service_posted_by == userid).ToList();
			List<vm_ServiceApplication> model = GetViewModel(list);
			return View("table", model);
		}

		public IActionResult All()
		{
			ViewBag.Title = "All service applications";
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_s.ToList();
			var list = db.tbl_service_applications.Where(x => x.status != "V").ToList();
			List<vm_ServiceApplication> model = GetViewModel(list);
			return View("table", model);
		}

		public List<vm_ServiceApplication> GetViewModel(List<tbl_service_applications> list)
		{
			List<vm_ServiceApplication> models = (from o in list
																						select new vm_ServiceApplication()
																						{
																							APPLICATION = o,
																							SERVICE = db.tbl_service.Find(o.service_id),
																							CATEGORIES = db.tbl_service_categories.Where(x => x.service_id == o.service_id).Select(x => x.category_id).ToList(),
																							IMAGEPATHS = db.tbl_service_images.Where(x => x.service_id == o.service_id).Select(x => x.file_path).ToList(),
																						}).ToList();
			return models;
		}

		public string SetStatus(int id, string newstatus, string userid)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_service_applications.Find(id);
				if (checkExist == null)
				{
					ErrorMessage = "Service application ID (" + id + ") doesn't exist in the system database.";
				}
				else
				{
					checkExist.status = newstatus;
					checkExist.edited_by = userid;
					checkExist.edited_date = DateTime.Now;
					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			return ErrorMessage;
		}

		public string Create(int id, string userid)
		{
			string ErrorMessage = "";
			DateTime now = DateTime.Now;
			try
			{
				var checkExist = db.tbl_service.Find(id);
				var user = db.tbl_user_profile.Find(userid);
				if (checkExist == null)
				{
					ErrorMessage = "Service ID (" + id + ") doesn't exist in the system database.";
				}
				else if (user == null)
				{
					ErrorMessage = "User ID (" + userid + ") doesn't exist in the system database.";
				}
				else
				{
					tbl_service_applications item = new tbl_service_applications();
					item.service_id = checkExist.id;
					item.service_posted_by = checkExist.created_by;
					item.status = "A";
					item.created_by = userid;
					item.created_date = now;
					item.edited_by = userid;
					item.edited_date = now;
					db.tbl_service_applications.Add(item);
					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			return ErrorMessage;
		}

		public IActionResult Rate(int? id)
		{
			var userid = HttpContext.Session.GetString("USERID");
			if (string.IsNullOrEmpty(userid))
				return RedirectToAction("Index", "Home");
			if (id == null)
				return RedirectToAction("Index", "Home");
			tbl_service_applications model = db.tbl_service_applications.Find(id);
			if (model == null)
				return RedirectToAction("Index", "Home");
			if (model.created_by != userid)
				return RedirectToAction("Index", "Home");
			return View(model);
		}

		[HttpPost]
		public string Rate(tbl_service_applications model)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_service_applications.Find(model.id);
				if (checkExist == null)
				{
					ErrorMessage = "Micro Job Application ID (" + model.id + ") doesn't exist in the system database.";
				}
				else
				{
					checkExist.rating = model.rating;
					checkExist.review = model.review;
					checkExist.edited_date = DateTime.Now;
					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			return ErrorMessage;
		}

	}
}
