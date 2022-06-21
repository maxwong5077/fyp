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
	public class JobApplicationController : Controller
	{
		private readonly EasyJobHunterDBContext db = new EasyJobHunterDBContext();

		public IActionResult Apply()//i apply
		{
			ViewBag.Title = "My job applications";
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_j.ToList();
			string userid = HttpContext.Session.GetString("USERID").ToString();
			var list = db.tbl_job_applications.Where(x => x.status != "V" && x.created_by == userid).ToList();
			List<vm_JobApplication> model = GetViewModel(list);
			return View("table",model);
		}

		public IActionResult Receive()//i receive
		{
			ViewBag.Title = "Job applications received";
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_j.ToList();
			string userid = HttpContext.Session.GetString("USERID").ToString();
			var list = db.tbl_job_applications.Where(x => x.status != "V" && x.job_posted_by == userid).ToList();
			List<vm_JobApplication> model = GetViewModel(list);
			return View("table", model);
		}		

		public IActionResult All()
		{
			ViewBag.Title = "All job applications";
			ViewBag.location = db.tbl_location.ToList();
			ViewBag.category = db.tbl_category_j.ToList();
			var list = db.tbl_job_applications.Where(x => x.status != "V").ToList();
			List<vm_JobApplication> model = GetViewModel(list);
			return View("table", model);
		}

		public List<vm_JobApplication> GetViewModel(List<tbl_job_applications> list)
		{
			List<vm_JobApplication> models = (from o in list
																				select new vm_JobApplication()
																				{
																					APPLICATION = o,
																					JOB = db.tbl_job.Find(o.job_id),
																					CATEGORIES = db.tbl_job_categories.Where(x=>x.job_id == o.job_id).Select(x=>x.category_id).ToList(),
																					IMAGEPATHS = db.tbl_job_images.Where(x => x.job_id == o.job_id).Select(x => x.file_path).ToList(),
																				}).ToList();
			return models;
		}

		public string SetStatus(int id, string newstatus, string userid)
		{
			string ErrorMessage = "";
			try
			{
				var checkExist = db.tbl_job_applications.Find(id);
				if (checkExist == null)
				{
					ErrorMessage = "Job application ID (" + id + ") doesn't exist in the system database.";
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
				var checkExist = db.tbl_job.Find(id);
				var user = db.tbl_user_profile.Find(userid);
				if (checkExist == null)
				{
					ErrorMessage = "Job ID (" + id + ") doesn't exist in the system database.";
				}
				else if (user == null)
				{
					ErrorMessage = "User ID (" + userid + ") doesn't exist in the system database.";
				}
				else if (user.role != "SEEKER")
				{
					ErrorMessage = "User ID (" + userid + ") is not belong to job seeker role.";
				}
				else if (user.role == "SEEKER")
				{
					var pendingApplication = db.tbl_job_applications.Where(x => x.created_by == userid && x.status == "A" && x.job_id == id).FirstOrDefault();
					if(pendingApplication != null)
					{
						ErrorMessage = "You have applied this job on " + Convert.ToDateTime(pendingApplication.created_date).ToString("yyyy-MM-dd HH:mm") + ". Kindly wait for employer to respond to the application.";
					}
					else
					{
						tbl_job_applications item = new tbl_job_applications();
						item.job_id = checkExist.id;
						item.job_posted_by = checkExist.created_by;
						item.status = "A";
						item.created_by = userid;
						item.created_date = now;
						item.edited_by = userid;
						item.edited_date = now;
						db.tbl_job_applications.Add(item);
						db.SaveChanges();
					}
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
