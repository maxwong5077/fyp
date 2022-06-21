using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel; //change display name
using System.ComponentModel.DataAnnotations;//change data type

namespace EasyJobHunter.ViewModel
{
	public class vm_Login_Index
	{
		public string USERID { get; set; }
		public string ErrorMessage { get; set; }
		public string PASSWD { get; set; }
		public string GOTO { get; set; }//GO TO WHICH WEBSITE AFTER LOGIN
	}

	public class vm_Login_Register
	{
		public string USERID { get; set; }
		public string NAME { get; set; }
		public string ErrorMessage { get; set; }
		public string PASSWD { get; set; }
		public string PASSWD_CON { get; set; }
		public string EMAIL { get; set; }
		public string ROLE { get; set; }
	}
}