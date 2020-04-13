﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Model
{
    public class Category
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
