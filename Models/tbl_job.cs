using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyJobHunter.Models
{
  public class tbl_job
  {
    [Key]
    public int id { get; set; }

    [Required]
    [StringLength(100)]
    public string name { get; set; }

    [Required]
    [StringLength(50)]
    public string salary { get; set; }

    [Column(TypeName = "text")]
    public string content { get; set; }

    public bool is_publish { get; set; }

    public int location_id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? created_date { get; set; }

    [Required]
    [StringLength(50)]
    public string created_by { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? edited_date { get; set; }

    [Required]
    [StringLength(50)]
    public string edited_by { get; set; }

    [Required]
    [StringLength(1)]
    public string status { get; set; }
    
  }
}