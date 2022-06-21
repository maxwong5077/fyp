using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyJobHunter.Models
{
  public class tbl_job_applications
  {
    [Key]
    public int id { get; set; }

    public int job_id { get; set; }

    [Required]
    [StringLength(50)]
    public string job_posted_by { get; set; }

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