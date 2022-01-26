﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies4Joel.Models
{
    public class ApplicationResponse
    {
       [Key]
       [Required]
       public int MovieID { get; set; }

       [Required]
       public string Category { get; set; }

       [Required]
       public string Title { get; set; }

       [Required]
       public ushort Year { get; set; }

       [Required]
       public string Director { get; set; }

       [Required]
       public string Rating { get; set; } 

       public bool Edited { get; set; } //optional

       public string LentTo { get; set; } //optional

       public string Notes { get; set; } //optional
    }
}
