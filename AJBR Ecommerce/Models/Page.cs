﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AJBR_Ecommerce.Models
{
    public class Page
    {
        [Key]
        public int  Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int Sorting { get; set; }
    }
}
