using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyJobHunter.Models
{
  public class tbl_user_profile
  {
    [Key]
    [StringLength(50)]
    public string userid { get; set; }

    [StringLength(60)]
    public string email { get; set; }

    [StringLength(100)]
    public string real_name { get; set; }

    [StringLength(30)]
    public string contactno { get; set; }

    [StringLength(30)]
    public string password { get; set; }

    [StringLength(100)]
    public string address { get; set; }

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

    [StringLength(30)]
    public string role { get; set; }

    public int login_count { get; set; }
  }
}
