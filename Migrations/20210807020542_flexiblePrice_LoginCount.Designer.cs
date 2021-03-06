// <auto-generated />
using System;
using EasyJobHunter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyJobHunter.Migrations
{
    [DbContext(typeof(EasyJobHunterDBContext))]
    [Migration("20210807020542_flexiblePrice_LoginCount")]
    partial class flexiblePrice_LoginCount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyJobHunter.Models.tbl_carousel_image", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("file_path")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("module")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tbl_carousel_image");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_category_j", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("file_path")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("tbl_category_j");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_category_s", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("file_path")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("tbl_category_s");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_job", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .HasColumnType("text");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("datetime");

                    b.Property<string>("edited_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("edited_date")
                        .HasColumnType("datetime");

                    b.Property<bool>("is_publish")
                        .HasColumnType("bit");

                    b.Property<int>("location_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("salary")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("id");

                    b.ToTable("tbl_job");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_job_applications", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("datetime");

                    b.Property<string>("edited_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("edited_date")
                        .HasColumnType("datetime");

                    b.Property<int>("job_id")
                        .HasColumnType("int");

                    b.Property<string>("job_posted_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("id");

                    b.ToTable("tbl_job_applications");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_job_categories", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("job_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_job_categories");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_job_images", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("file_path")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("job_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_job_images");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_location", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.ToTable("tbl_location");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_service", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .HasColumnType("text");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("datetime");

                    b.Property<string>("edited_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("edited_date")
                        .HasColumnType("datetime");

                    b.Property<bool>("is_publish")
                        .HasColumnType("bit");

                    b.Property<int>("location_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("id");

                    b.ToTable("tbl_service");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_service_applications", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("datetime");

                    b.Property<string>("edited_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("edited_date")
                        .HasColumnType("datetime");

                    b.Property<short>("rating")
                        .HasColumnType("smallint");

                    b.Property<string>("review")
                        .HasColumnType("text");

                    b.Property<int>("service_id")
                        .HasColumnType("int");

                    b.Property<string>("service_posted_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("id");

                    b.ToTable("tbl_service_applications");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_service_categories", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("service_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_service_categories");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_service_images", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("file_path")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("service_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tbl_service_images");
                });

            modelBuilder.Entity("EasyJobHunter.Models.tbl_user_profile", b =>
                {
                    b.Property<string>("userid")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("contactno")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("created_date")
                        .HasColumnType("datetime");

                    b.Property<string>("edited_by")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("edited_date")
                        .HasColumnType("datetime");

                    b.Property<string>("email")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("login_count")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("real_name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("role")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("userid");

                    b.ToTable("tbl_user_profile");
                });
#pragma warning restore 612, 618
        }
    }
}
