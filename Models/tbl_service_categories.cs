using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyJobHunter.Models
{
  public class tbl_service_categories
  {
    [Key]
    public int id { get; set; }
    public int service_id { get; set; }
    public int category_id { get; set; }
  }
}