using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Senac.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Cpf = table.Column<string>(nullable: true),
                    DiasRetorno = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeiculosLeves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Cor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculosLeves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeiculosPesados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true),
                    Ano = table.Column<int>(nullable: false),
                    Preco = table.Column<double>(nullable: false),
                    Restricoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeiculosPesados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    DataLocacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacoes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocacaoVeiculosLeves",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IdLocacao = table.Column<int>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: true),
                    IdVeiculoLeve = table.Column<int>(nullable: false),
                    VeiculoLeveId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocacaoVeiculosLeves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocacaoVeiculosLeves_Locacoes_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocacaoVeiculosLeves_VeiculosLeves_VeiculoLeveId",
                        column: x => x.VeiculoLeveId,
                        principalTable: "VeiculosLeves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocacaoVeiculosPesados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdLocacao = table.Column<int>(nullable: false),
                    LocacaoId = table.Column<int>(nullable: true),
                    IdVeiculoPesado = table.Column<int>(nullable: false),
                    VeiculoPesadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocacaoVeiculosPesados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocacaoVeiculosPesados_Locacoes_LocacaoId",
                        column: x => x.LocacaoId,
                        principalTable: "Locacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocacaoVeiculosPesados_VeiculosPesados_VeiculoPesadoId",
                        column: x => x.VeiculoPesadoId,
                        principalTable: "VeiculosPesados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculosLeves_LocacaoId",
                table: "LocacaoVeiculosLeves",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculosLeves_VeiculoLeveId",
                table: "LocacaoVeiculosLeves",
                column: "VeiculoLeveId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculosPesados_LocacaoId",
                table: "LocacaoVeiculosPesados",
                column: "LocacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_LocacaoVeiculosPesados_VeiculoPesadoId",
                table: "LocacaoVeiculosPesados",
                column: "VeiculoPesadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacoes_ClienteId",
                table: "Locacoes",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocacaoVeiculosLeves");

            migrationBuilder.DropTable(
                name: "LocacaoVeiculosPesados");

            migrationBuilder.DropTable(
                name: "VeiculosLeves");

            migrationBuilder.DropTable(
                name: "Locacoes");

            migrationBuilder.DropTable(
                name: "VeiculosPesados");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
