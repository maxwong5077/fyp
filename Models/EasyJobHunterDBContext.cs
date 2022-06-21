using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyJobHunter.Models
{
  public class EasyJobHunterDBContext : DbContext
  {
    public EasyJobHunterDBContext(DbContextOptions<EasyJobHunterDBContext> options)
        : base(options)
    {
    }
    public EasyJobHunterDBContext()
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=tcp:easyjobhunter.database.windows.net,1433;Initial Catalog=EasyJobHunter_DB;Persist Security Info=False;User ID=easyjobhunter_admin;Password=Easy1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
    public DbSet<tbl_category_j> tbl_category_j { get; set; }
    public DbSet<tbl_category_s> tbl_category_s { get; set; }

    public DbSet<tbl_job> tbl_job { get; set; }
    public DbSet<tbl_job_applications> tbl_job_applications { get; set; }
    public DbSet<tbl_job_categories> tbl_job_categories { get; set; }
    public DbSet<tbl_job_images> tbl_job_images { get; set; }

    public DbSet<tbl_location> tbl_location { get; set; }

    public DbSet<tbl_service> tbl_service { get; set; }
    public DbSet<tbl_service_applications> tbl_service_applications { get; set; }
    public DbSet<tbl_service_categories> tbl_service_categories { get; set; }
    public DbSet<tbl_service_images> tbl_service_images { get; set; }

    public DbSet<tbl_user_profile> tbl_user_profile { get; set; }
    public DbSet<tbl_carousel_image> tbl_carousel_image { get; set; }
  }
}
