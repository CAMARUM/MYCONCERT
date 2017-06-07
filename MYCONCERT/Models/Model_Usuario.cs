using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MYCONCERT.Models
{
        public class LoginViewModel
        {
        [Required]
        [EmailAddress]
            public string Email { get; set; }
        }
    }