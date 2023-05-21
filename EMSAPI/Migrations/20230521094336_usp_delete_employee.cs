using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMSAPI.Migrations
{
    public partial class usp_delete_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE usp_delete_employee
                            @Id INT
                        AS
                        BEGIN
                            DELETE FROM Employees WHERE Id = @Id;
                        END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE usp_delete_employee";
            migrationBuilder.Sql(sp);
        }
    }
}
