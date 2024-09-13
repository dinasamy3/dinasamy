using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp4.Migrations
{
    /// <inheritdoc />
    public partial class v : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_departmentId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_departmentId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "employees");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_employees_DeptId",
                table: "employees",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DeptId",
                table: "employees",
                column: "DeptId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DeptId",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_DeptId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "employees");

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_departmentId",
                table: "employees",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_departmentId",
                table: "employees",
                column: "departmentId",
                principalTable: "departments",
                principalColumn: "Id");
        }
    }
}
