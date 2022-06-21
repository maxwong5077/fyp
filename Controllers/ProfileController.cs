using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyJobHunter.Models;
using EasyJobHunter.ViewModel;

namespace EasyJobHunter.Controllers
{
	public class ProfileController : Controller
	{
		private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

		public IActionResult Index()
		{
			string userid = HttpContext.Session.GetString("USERID")!=null? HttpContext.Session.GetString("USERID").ToString() : "";
			//profile
			tbl_user_profile user = db.tbl_user_profile.Find(userid);
			if (user == null)
			{
				return RedirectToAction("Index","Home");
			}
			return View(user);
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
					//checkExist.role = model.role;

					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
			}
			return ErrorMessage;
		}

		public IActionResult Detail(string id)
		{
			tbl_user_profile user = db.tbl_user_profile.Find(id);
			if (user == null)
			{
				return RedirectToAction("Index", "Home");
			}
			return View(user);
		}

	}
}
