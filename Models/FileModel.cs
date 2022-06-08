using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HW_3.Models
{
    public class FileModel
    {
        [Display(Name = "File Name")]
        public string Filename { get; set; }

        [Required(ErrorMessage ="Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase [] Files { get; set; }

    }
}