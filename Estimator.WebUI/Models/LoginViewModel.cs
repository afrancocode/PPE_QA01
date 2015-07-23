using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Estimator.WebUI.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Please provide a valid Login", AllowEmptyStrings = false)]
		[Display(Name = "User Name: ")]
		public string Login { get; set; }

		[Required(ErrorMessage = "Please provide a password", AllowEmptyStrings = false)]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}