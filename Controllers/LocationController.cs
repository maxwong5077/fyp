using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using EasyJobHunter.Models;
using EasyJobHunter.ViewModel;

namespace EasyJobHunter.Controllers
{
	public class LocationController : Controller
	{
		private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

		public IActionResult Index()
		{
			var list = db.tbl_location.ToList();
			List<vm_Location> models = (from d in list
																	select new vm_Location()
																	{
																		LOCATION = d,
																		dependent_j = db.tbl_job.Where(x=>x.status !="V" && x.location_id == d.id).Count(),
																		dependent_s = db.tbl_service.Where(x => x.status != "V" && x.location_id == d.id).Count(),
																	}).ToList();
			return View(models);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public string Create(tbl_location Location)
		{
			string ErrorMessage = "";
			try
			{
				db.tbl_location.Add(Location);
				db.SaveChanges();
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
			tbl_location Location = db.tbl_location.Find(id);
			if (Location == null)
			{
				return RedirectToAction("Index", "Home");
			}
			return View(Location);
		}

		[HttpPost]
		public string Edit(tbl_location Location)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_location.Find(Location.id);
				if (checkExist == null)
				{
					ErrorMessage = "Location ID (" + Location.id + ") doesn't exist in the system database.";
				}
				else
				{
					checkExist.name = Location.name;
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
				var checkExist = db.tbl_location.Find(id);
				if (checkExist == null)
				{
					ErrorMessage = "Location ID (" + id + ") doesn't exist in the system database.";
				}
				else
				{
					db.tbl_location.Remove(checkExist);
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
