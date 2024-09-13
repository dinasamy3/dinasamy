using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp4.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employeeproject_employees_employeesId",
                table: "Employeeproject");

            migrationBuilder.DropForeignKey(
                name: "FK_Employeeproject_projects_projectsId",
                table: "Employeeproject");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DeptId",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employeeproject",
                table: "Employeeproject");

            migrationBuilder.DropIndex(
                name: "IX_Employeeproject_projectsId",
                table: "Employeeproject");

            migrationBuilder.RenameTable(
                name: "Employeeproject",
                newName: "EmployeeProject");

            migrationBuilder.RenameColumn(
                name: "projectsId",
                table: "EmployeeProject",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "employeesId",
                table: "EmployeeProject",
                newName: "EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeProjectId",
                table: "projects",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeptId",
                table: "employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeProjectId",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EmployeeProject",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeProject",
                table: "EmployeeProject",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_projects_EmployeeId",
                table: "projects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_projects_EmployeeProjectId",
                table: "projects",
                column: "EmployeeProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_EmployeeProjectId",
                table: "employees",
                column: "EmployeeProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_EmployeeProject_EmployeeProjectId",
                table: "employees",
                column: "EmployeeProjectId",
                principalTable: "EmployeeProject",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DeptId",
                table: "employees",
                column: "DeptId",
                principalTable: "departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_EmployeeProject_EmployeeProjectId",
                table: "projects",
                column: "EmployeeProjectId",
                principalTable: "EmployeeProject",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_employees_EmployeeId",
                table: "projects",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_EmployeeProject_EmployeeProjectId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_DeptId",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_EmployeeProject_EmployeeProjectId",
                table: "projects");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_employees_EmployeeId",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_EmployeeId",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_EmployeeProjectId",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_employees_EmployeeProjectId",
                table: "employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeProject",
                table: "EmployeeProject");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "EmployeeProjectId",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "EmployeeProjectId",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EmployeeProject");

            migrationBuilder.RenameTable(
                name: "EmployeeProject",
                newName: "Employeeproject");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Employeeproject",
                newName: "projectsId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employeeproject",
                newName: "employeesId");

            migrationBuilder.AlterColumn<int>(
                name: "DeptId",
                table: "employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employeeproject",
                table: "Employeeproject",
                columns: new[] { "employeesId", "projectsId" });

            migrationBuilder.CreateIndex(
                name: "IX_Employeeproject_projectsId",
                table: "Employeeproject",
                column: "projectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employeeproject_employees_employeesId",
                table: "Employeeproject",
                column: "employeesId",
                principalTable: "employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employeeproject_projects_projectsId",
                table: "Employeeproject",
                column: "projectsId",
                principalTable: "projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_DeptId",
                table: "employees",
                column: "DeptId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
