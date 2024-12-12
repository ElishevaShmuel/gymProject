using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gym.DataNew.Migrations
{
    /// <inheritdoc />
    public partial class addef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Members_memberId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_teachers_teacherId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_memberId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_teacherId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "teacherId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "memberId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "memberId1",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "teacherId1",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_memberId1",
                table: "Courses",
                column: "memberId1");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_teacherId1",
                table: "Courses",
                column: "teacherId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Members_memberId1",
                table: "Courses",
                column: "memberId1",
                principalTable: "Members",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_teachers_teacherId1",
                table: "Courses",
                column: "teacherId1",
                principalTable: "teachers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Members_memberId1",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_teachers_teacherId1",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_memberId1",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_teacherId1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "memberId1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "teacherId1",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "teacherId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "memberId",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_memberId",
                table: "Courses",
                column: "memberId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_teacherId",
                table: "Courses",
                column: "teacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Members_memberId",
                table: "Courses",
                column: "memberId",
                principalTable: "Members",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_teachers_teacherId",
                table: "Courses",
                column: "teacherId",
                principalTable: "teachers",
                principalColumn: "Id");
        }
    }
}
