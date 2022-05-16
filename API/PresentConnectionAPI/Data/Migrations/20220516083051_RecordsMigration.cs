using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PresentConnectionAPI.Data.Migrations
{
    public partial class RecordsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Body = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "Body", "Title" },
                values: new object[] { 1, "This is the body of 1 record form the database made for present connection", "Record 1" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "Body", "Title" },
                values: new object[] { 2, "This is the body of 2 record form the database made for present connection", "Record 2" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "Body", "Title" },
                values: new object[] { 3, "This is the body of 3 record form the database made for present connection", "Record 3" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "Body", "Title" },
                values: new object[] { 4, "This is the body of 4 record form the database made for present connection", "Record 4" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "Body", "Title" },
                values: new object[] { 5, "This is the body of 5 record form the database made for present connection", "Record 5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
