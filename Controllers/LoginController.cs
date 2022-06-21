using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EasyJobHunter.Models;
using EasyJobHunter.ViewModel;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EasyJobHunter.Controllers
{
	public class LoginController : Controller
	{
		private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

		// GET: Login
		public IActionResult Index()
		{			
			return View();			
		}

		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public string IsSessionValid()
		{
			var result = "";
			if (HttpContext.Session.GetString("USERID") == null)
			{
				result = "expired";
			}
			return result;
		}

		[HttpPost]
		public JsonResult Authenticate(vm_Login_Index model)
		{
			model.ErrorMessage = "";
			try
			{
				var uSER = db.tbl_user_profile.Where(x => x.userid == model.USERID).FirstOrDefault();
				if (uSER == null)
				{
					//wrong username
					model.ErrorMessage = "Login failed, wrong username.";
				}
				else
				{
					uSER = db.tbl_user_profile.Where(x => x.userid == model.USERID && x.password == model.PASSWD).FirstOrDefault();
					if (uSER == null)
					{
						//wrong password
						model.ErrorMessage = "Login failed, wrong password.";
					}
					else//correct matching of the userid & pw
					{
						//Check login count
						model.GOTO = uSER.login_count > 0 ? "Home" : "Profile";

						HttpContext.Session.SetString("USERID", uSER.userid);
						HttpContext.Session.SetString("NAME", uSER.real_name);
						HttpContext.Session.SetString("ROLE", uSER.role);

						uSER.login_count = uSER.login_count + 1;
						db.SaveChanges();
					}
				}
			}
			catch (Exception ex)
			{
				model.ErrorMessage = ex.Message;				
			}
			return Json(model);
		}

		[HttpPost]
		public string Register(vm_Login_Register model)
		{
			string ErrorMessage = "";
			try
			{
				var uSER = db.tbl_user_profile.Where(x => x.userid == model.USERID).FirstOrDefault();
				if (uSER != null)
				{
					//wrong username
					ErrorMessage = "User ID already exists.";
				}
				else
				{
					uSER = new tbl_user_profile();
					uSER.role = model.ROLE;
					uSER.real_name = model.NAME;
					uSER.userid = model.USERID;
					uSER.email = model.EMAIL;
					uSER.password = model.PASSWD;					
					uSER.created_by = model.USERID;
					uSER.created_date = DateTime.Now;
					uSER.edited_by = model.USERID;
					uSER.edited_date = uSER.created_date;
					uSER.status = "A";
					db.tbl_user_profile.Add(uSER);
					db.SaveChanges();
				}
				return ErrorMessage;
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.Message;
				return ErrorMessage;
			}
		}

		public IActionResult Logout()//no view
		{
			HttpContext.Session.Clear();
			return RedirectToAction("Index", "Home");
		}
	}
}