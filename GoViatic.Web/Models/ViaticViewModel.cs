﻿using GoViatic.Web.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoViatic.Web.Models
{
    public class ViaticViewModel : Viatic
    {
        public int TripId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Pet Type")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a viatic concept.")]
        public int ViaticTypeId { get; set; }

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

        public new IEnumerable<SelectListItem> ViaticType { get; set; }


    }
}
