using Microsoft.EntityFrameworkCore.Migrations;

namespace Csharp_Seat_Booking_System.Migrations
{
    public partial class AddBookToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserReg",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: false),
                    Pwd = table.Column<string>(nullable: false),
                    Confirmpwd = table.Column<string>(nullable: false),
                    Uemail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReg", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserReg");
        }
    }
}
