using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFerreteriaJuanito.Migrations
{
    public partial class Tercera_Modificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarroComprasidCarro",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CarroCompras",
                columns: table => new
                {
                    idCarro = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idUsuario = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarroCompras", x => x.idCarro);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CarroComprasidCarro",
                table: "Productos",
                column: "CarroComprasidCarro");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_CarroCompras_CarroComprasidCarro",
                table: "Productos",
                column: "CarroComprasidCarro",
                principalTable: "CarroCompras",
                principalColumn: "idCarro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_CarroCompras_CarroComprasidCarro",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "CarroCompras");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CarroComprasidCarro",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "CarroComprasidCarro",
                table: "Productos");
        }
    }
}
