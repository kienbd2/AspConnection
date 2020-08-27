﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Model
{

    public class Category 
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(255)]
        public string CategoryName { get; set; }

        [StringLength(255)]
        public string UrlSlug { get; set; }


        [StringLength(1024)]
        public string Description { get; set; }

    }

}