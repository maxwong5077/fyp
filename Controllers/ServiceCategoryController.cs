using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using EasyJobHunter.Models;
using EasyJobHunter.ViewModel;
using System.IO;

namespace EasyJobHunter.Controllers
{
	public class ServiceCategoryController : Controller
	{
		private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

		public IActionResult Index()
		{
			List<tbl_category_s> list = db.tbl_category_s.ToList();
			List<vm_Category_S> model = GetViewModel(list);
			return View(model);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public string Create(vm_Category_S model)
		{
			string ErrorMessage = "";
			try
			{
				db.tbl_category_s.Add(model.CATEGORY);
				db.SaveChanges();
				//DETECT IF GOT ANY IMAGES ATTACHED
				if (model.FILE != null)
				{
					string FileName = model.FILE.FileName;
					string FileExtension = Path.GetExtension(FileName);
					string FilenameWithoutExtension = model.CATEGORY.id.ToString();
					string uniquemarking = "_" + Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss");
					string newName = FilenameWithoutExtension + uniquemarking + FileExtension;
					string url = new HomeController().UploadStorage(model.FILE, newName, "category-s");
					model.CATEGORY.file_path = url;
					db.SaveChanges();
				}
			}
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
			tbl_category_s item = db.tbl_category_s.Find(id);
			if (item == null)
			{
				return RedirectToAction("Index", "Home");
			}
			List<tbl_category_s> list = new List<tbl_category_s>();
			list.Add(item);
			vm_Category_S model = GetViewModel(list).FirstOrDefault();
			return View(model);
		}

		[HttpPost]
		public string Edit(vm_Category_S model)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_category_s.Find(model.CATEGORY.id);
				if (checkExist == null)
				{
					ErrorMessage = "Service Category ID (" + model.CATEGORY.id + ") doesn't exist in the system database.";
				}
				else
				{
					checkExist.name = model.CATEGORY.name;

					if (model.CATEGORY.file_path == "undefined" || string.IsNullOrEmpty(model.CATEGORY.file_path))
						checkExist.file_path = null;
					else
						checkExist.file_path = model.CATEGORY.file_path;

					//DETECT IF GOT ANY IMAGES ATTACHED
					if (model.FILE != null)
					{
						string FileName = model.FILE.FileName;
						string FileExtension = Path.GetExtension(FileName);
						string FilenameWithoutExtension = model.CATEGORY.id.ToString();
						string uniquemarking = "_" + Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss");
						string newName = FilenameWithoutExtension + uniquemarking + FileExtension;
						string url = new HomeController().UploadStorage(model.FILE, newName, "category-s");
						model.CATEGORY.file_path = url;
					}
					db.SaveChanges();
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
			try
			{
				var checkExist = db.tbl_category_s.Find(id);
				if (checkExist == null)
				{
					ErrorMessage = "Service Category ID (" + id + ") doesn't exist in the system database.";
				}
				else
				{
					db.tbl_category_s.Remove(checkExist);
					//also delete categories record
					var tobeDeleted = db.tbl_service_categories.Where(x => x.category_id == id).ToList();
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

		public List<vm_Category_S> GetViewModel(List<tbl_category_s> list)
		{
			List<vm_Category_S> models = (from d in list
																		select new vm_Category_S()
																		{
																			CATEGORY = d,
																			FILE = null,
																			dependent = db.tbl_service_categories.Where(x => x.category_id == d.id).Count(),
																		}).ToList();
			return models;
		}

	}
}
