using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Senac.Migrations
{
    public partial class ChangeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocacaoVeiculosLeves_Locacoes_LocacaoId",
                table: "LocacaoVeiculosLeves");

            migrationBuilder.DropForeignKey(
                name: "FK_LocacaoVeiculosLeves_VeiculosLeves_VeiculoLeveId",
                table: "LocacaoVeiculosLeves");

            migrationBuilder.DropForeignKey(
                name: "FK_LocacaoVeiculosPesados_Locacoes_LocacaoId",
                table: "LocacaoVeiculosPesados");

            migrationBuilder.DropForeignKey(
                name: "FK_LocacaoVeiculosPesados_VeiculosPesados_VeiculoPesadoId",
                table: "LocacaoVeiculosPesados");

            migrationBuilder.DropForeignKey(
                name: "FK_Locacoes_Clientes_ClienteId",
                table: "Locacoes");

            migrationBuilder.DropIndex(
                name: "IX_Locacoes_ClienteId",
                table: "Locacoes");

            migrationBuilder.DropIndex(
                name: "IX_LocacaoVeiculosPesados_LocacaoId",
                table: "LocacaoVeiculosPesados");

            migrationBuilder.DropIndex(
                name: "IX_LocacaoVeiculosPesados_VeiculoPesadoId",
                table: "LocacaoVeiculosPesados");

            migrationBuilder.DropIndex(
                name: "IX_LocacaoVeiculosLeves_LocacaoId",
                table: "LocacaoVeiculosLeves");

            migrationBuilder.DropIndex(
                name: "IX_LocacaoVeiculosLeves_VeiculoLeveId",
                table: "LocacaoVeiculosLeves");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Locacoes");

            migrationBuilder.DropColumn(
                name: "LocacaoId",
                table: "LocacaoVeiculosPesados");

            migrationBuilder.DropColumn(
                name: "VeiculoPesadoId",
                table: "LocacaoVeiculosPesados");

            migrationBuilder.DropColumn(
                name: "LocacaoId",
                table: "LocacaoVeiculosLeves");

            migrationBuilder.DropColumn(
                name: "VeiculoLeveId",
                table: "LocacaoVeiculosLeves");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "LocacaoVeiculosLeves",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Locacoes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocacaoId",
                table: "LocacaoVeiculosPesados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoPesadoId",
                table: "LocacaoVeiculosPesados",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "LocacaoVeiculosLeves",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "LocacaoId",
                table: "LocacaoVeiculosLeves",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeiculoLeveId",
                table: "LocacaoVeiculosLeves",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_ClienteId",
                table: "Locacoes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculosPesados_LocacaoId",
                table: "LocacaoVeiculosPesados",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculosPesados_VeiculoPesadoId",
                table: "LocacaoVeiculosPesados",
                column: "VeiculoPesadoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculosLeves_LocacaoId",
                table: "LocacaoVeiculosLeves",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculosLeves_VeiculoLeveId",
                table: "LocacaoVeiculosLeves",
                column: "VeiculoLeveId");

            migrationBuilder.AddForeignKey(
                name: "FK_LocacaoVeiculosLeves_Locacoes_LocacaoId",
                table: "LocacaoVeiculosLeves",
                column: "LocacaoId",
                principalTable: "Locacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocacaoVeiculosLeves_VeiculosLeves_VeiculoLeveId",
                table: "LocacaoVeiculosLeves",
                column: "VeiculoLeveId",
                principalTable: "VeiculosLeves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocacaoVeiculosPesados_Locacoes_LocacaoId",
                table: "LocacaoVeiculosPesados",
                column: "LocacaoId",
                principalTable: "Locacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LocacaoVeiculosPesados_VeiculosPesados_VeiculoPesadoId",
                table: "LocacaoVeiculosPesados",
                column: "VeiculoPesadoId",
                principalTable: "VeiculosPesados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locacoes_Clientes_ClienteId",
                table: "Locacoes",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
