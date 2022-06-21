using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyJobHunter.Models
{
  public class tbl_carousel_image
  {
    [Key]
    public int id { get; set; }
    [Required]
    [StringLength(150)]
    public string file_path { get; set; }

    public string module { get; set; }

  }
}