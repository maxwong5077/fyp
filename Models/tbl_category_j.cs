using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyJobHunter.Models
{
  public class tbl_category_j
  {
    [Key]
    public int id { get; set; }

    [Required]
    [StringLength(100)]
    public string name { get; set; }

    
    [StringLength(150)]
    public string file_path { get; set; }
  }
}