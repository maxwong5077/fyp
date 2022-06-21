using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyJobHunter.Migrations
{
    public partial class addtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_category_j",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    file_path = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    edited_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    edited_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_category_j", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_category_s",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    file_path = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    edited_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    edited_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_category_s", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_job",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    salary = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    content = table.Column<string>(type: "text", nullable: true),
                    is_publish = table.Column<bool>(type: "bit", nullable: false),
                    location_id = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    edited_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    edited_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_job", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_job_applications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_id = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    edited_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    edited_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_job_applications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_job_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_job_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_job_images",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_id = table.Column<int>(type: "int", nullable: false),
                    file_path = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_job_images", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_location",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    edited_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    edited_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_location", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_service",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    price = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    content = table.Column<string>(type: "text", nullable: true),
                    is_publish = table.Column<bool>(type: "bit", nullable: false),
                    location_id = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    edited_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    edited_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_service", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_service_applications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    rating = table.Column<short>(type: "smallint", nullable: false),
                    review = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    edited_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    edited_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_service_applications", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_service_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_service_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_service_images",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    service_id = table.Column<int>(type: "int", nullable: false),
                    file_path = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_service_images", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_user_profile",
                columns: table => new
                {
                    userid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    real_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    contactno = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    edited_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    edited_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    status = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    role = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_user_profile", x => x.userid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_category_j");

            migrationBuilder.DropTable(
                name: "tbl_category_s");

            migrationBuilder.DropTable(
                name: "tbl_job");

            migrationBuilder.DropTable(
                name: "tbl_job_applications");

            migrationBuilder.DropTable(
                name: "tbl_job_categories");

            migrationBuilder.DropTable(
                name: "tbl_job_images");

            migrationBuilder.DropTable(
                name: "tbl_location");

            migrationBuilder.DropTable(
                name: "tbl_service");

            migrationBuilder.DropTable(
                name: "tbl_service_applications");

            migrationBuilder.DropTable(
                name: "tbl_service_categories");

            migrationBuilder.DropTable(
                name: "tbl_service_images");

            migrationBuilder.DropTable(
                name: "tbl_user_profile");
        }
    }
}
