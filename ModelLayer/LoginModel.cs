using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class LoginModel
    {

        [Required]
        public string emailID { get; set; }     

        [Required]
        public string password { get; set; }

    }
}
