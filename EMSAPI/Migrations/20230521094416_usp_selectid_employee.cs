using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMSAPI.Migrations
{
    public partial class usp_selectid_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE usp_selectid_employee
                            @Id INT
                        AS
                        BEGIN
                            SELECT * FROM Employees WHERE Id = @Id;
                        END";
            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE usp_selectid_employee";
            migrationBuilder.Sql(sp);
        }
    }
}
