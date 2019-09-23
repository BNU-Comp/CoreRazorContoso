using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreRazorContoso.Migrations
{
    public partial class AnnotateCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Course",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Course",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80);
        }
    }
}
