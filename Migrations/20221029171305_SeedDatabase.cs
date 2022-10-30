using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('MAKE1')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('MAKE2')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('MAKE3')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('MAKE1-ModelA',(SELECT ID FROM Makes where Name = 'Make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('MAKE1-ModelB',1)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('MAKE1-ModelC',1)");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('MAKE2-ModelA',2)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('MAKE2-ModelB',2)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('MAKE2-ModelC',2)");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('MAKE3-ModelA',3)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('MAKE3-ModelB',3)");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('MAKE3-ModelC',3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Makes where Name in ('Make1','Make2','Make3')");
        }
    }
}
