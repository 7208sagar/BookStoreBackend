using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class ResetModel
    {

        [Required]
        public string emailID { get; set; }

        [Required]
        public string newpassword { get; set; }

    }
}
