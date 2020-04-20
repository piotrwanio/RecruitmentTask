using DataAnnotationsExtensions;
using RecruitmentTask.UI.LocalResource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentTask.UI.Models
{
    public class User
    {
        [MaxLength(30, ErrorMessageResourceType = typeof(ErrorMessages), ErrorMessageResourceName = "MaxLength")]
        [RegularExpression(@"^[a-zA-Z]+$"
                           , ErrorMessageResourceType = typeof(ErrorMessages), ErrorMessageResourceName = "OnlyLetters")]
        [Display(Name = "Username", ResourceType = typeof(Resource))]
        public string Username { get; set; }

        [EmailAddress(ErrorMessageResourceType = typeof(ErrorMessages), ErrorMessageResourceName = "Email")]
        [Display(Name = "Email", ResourceType = typeof(Resource))]
        public string Email { get; set; }
    }
}