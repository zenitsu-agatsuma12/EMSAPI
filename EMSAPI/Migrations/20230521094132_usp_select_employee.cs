using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMSAPI.Migrations
{
    public partial class usp_select_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE usp_select_employee
                        AS
                        BEGIN
                            SELECT * FROM Employees;
                        END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE usp_select_employee";
            migrationBuilder.Sql(sp);
        }

    }
}
