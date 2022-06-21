﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyJobHunter.Models
{
  public class tbl_job_images
  {
    [Key]
    public int id { get; set; }

    public int job_id { get; set; }

    [Required]
    [StringLength(150)]
    public string file_path { get; set; }

  }
}