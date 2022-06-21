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
	public class UserProfileController : Controller
	{
		private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

		public IActionResult Index()
		{
			return View(db.tbl_user_profile.Where(x => x.status != "V"));
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public string Create(tbl_user_profile model)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_user_profile.Where(x => x.userid == model.userid).FirstOrDefault();
				if (checkExist != null)
				{
					ErrorMessage = "Username (" + model.userid + ") already exists in the system database. Please try another unique username.";
				}
				else
				{
					db.tbl_user_profile.Add(model);
					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			return ErrorMessage;
		}

		public IActionResult Edit(string id)
		{
			tbl_user_profile model = db.tbl_user_profile.Find(id);
			if (model == null)
			{
				return RedirectToAction("Index", "Home");
			}
			return View(model);
		}

		[HttpPost]
		public string Edit(tbl_user_profile model)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_user_profile.Find(model.userid);
				if (checkExist == null)
				{
					ErrorMessage = "User doesn't exist in the system database.";
				}
				else
				{
					//profile
					checkExist.edited_by = model.edited_by;
					checkExist.edited_date = model.edited_date;

					checkExist.userid = model.userid;
					checkExist.email = model.email;
					checkExist.real_name = model.real_name;
					checkExist.contactno = model.contactno;
					checkExist.password = model.password;
					checkExist.address = model.address;
					checkExist.role = model.role;

					db.SaveChanges();

				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			return ErrorMessage;
		}

		public string Delete(string id)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_user_profile.Find(id);
				if (checkExist == null)
				{
					ErrorMessage = "User ID (" + id + ") doesn't exist in the system database.";
				}
				else
				{
					checkExist.status = "V";
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
