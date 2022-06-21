using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyJobHunter.Migrations
{
    public partial class altertables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_by",
                table: "tbl_service_images");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "tbl_service_images");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "tbl_location");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "tbl_location");

            migrationBuilder.DropColumn(
                name: "edited_by",
                table: "tbl_location");

            migrationBuilder.DropColumn(
                name: "edited_date",
                table: "tbl_location");

            migrationBuilder.DropColumn(
                name: "status",
                table: "tbl_location");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "tbl_job_images");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "tbl_job_images");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "tbl_category_s");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "tbl_category_s");

            migrationBuilder.DropColumn(
                name: "edited_by",
                table: "tbl_category_s");

            migrationBuilder.DropColumn(
                name: "edited_date",
                table: "tbl_category_s");

            migrationBuilder.DropColumn(
                name: "status",
                table: "tbl_category_s");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "tbl_category_j");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "tbl_category_j");

            migrationBuilder.DropColumn(
                name: "edited_by",
                table: "tbl_category_j");

            migrationBuilder.DropColumn(
                name: "edited_date",
                table: "tbl_category_j");

            migrationBuilder.DropColumn(
                name: "status",
                table: "tbl_category_j");

            migrationBuilder.AddColumn<string>(
                name: "service_posted_by",
                table: "tbl_service_applications",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "job_posted_by",
                table: "tbl_job_applications",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "service_posted_by",
                table: "tbl_service_applications");

            migrationBuilder.DropColumn(
                name: "job_posted_by",
                table: "tbl_job_applications");

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                table: "tbl_service_images",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "tbl_service_images",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                table: "tbl_location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "tbl_location",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "edited_by",
                table: "tbl_location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "edited_date",
                table: "tbl_location",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "tbl_location",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                table: "tbl_job_images",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "tbl_job_images",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                table: "tbl_category_s",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "tbl_category_s",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "edited_by",
                table: "tbl_category_s",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "edited_date",
                table: "tbl_category_s",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "tbl_category_s",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                table: "tbl_category_j",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "tbl_category_j",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "edited_by",
                table: "tbl_category_j",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "edited_date",
                table: "tbl_category_j",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "tbl_category_j",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");
        }
    }
}
