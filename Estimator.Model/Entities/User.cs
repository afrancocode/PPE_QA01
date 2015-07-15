using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Estimator.Model.Entities
{
    public class User
    {
        public int Id { get; set; }
		[Required(ErrorMessage="Please provide a valid Login", AllowEmptyStrings=false)]
		[Display(Name="User Name:")]
        public string Login { get; set; }
        public string Name { get; set; }
		[Required(ErrorMessage="Please provide password",AllowEmptyStrings=false)]
		[DataType(DataType.Password)]
        public string Password { get; set; }
		[HiddenInput(DisplayValue=false)]
        public string Role { get; set; }
    }
}
