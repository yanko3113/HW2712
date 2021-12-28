using Microsoft.EntityFrameworkCore.Migrations;

namespace HW27122021.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_inventario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    producto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cantidadAntigua = table.Column<int>(type: "int", nullable: false),
                    cantidadNueva = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__inventario", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_inventario");
        }
    }
}
