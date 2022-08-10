using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EstudoProjetoAPI.Data.Migrations
{
    public partial class CriaraTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Login",
                columns: table => new
                {
                    IdLogin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Login", x => x.IdLogin);
                });

            migrationBuilder.CreateTable(
                name: "tb_Administrador",
                columns: table => new
                {
                    IdAdmin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAdm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Login = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Administrador", x => x.IdAdmin);
                    table.ForeignKey(
                        name: "FK_tb_Administrador_tb_Login_Id_Login",
                        column: x => x.Id_Login,
                        principalTable: "tb_Login",
                        principalColumn: "IdLogin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Login = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_tb_Usuario_tb_Login_Id_Login",
                        column: x => x.Id_Login,
                        principalTable: "tb_Login",
                        principalColumn: "IdLogin",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cmmplemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_tb_Endereco_tb_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Processo",
                columns: table => new
                {
                    IdProcesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProcesso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroProcesso = table.Column<int>(type: "int", nullable: false),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Processo", x => x.IdProcesso);
                    table.ForeignKey(
                        name: "FK_tb_Processo_tb_Usuario_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Ocorrencia",
                columns: table => new
                {
                    IdOcorrencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroOcorrencia = table.Column<int>(type: "int", nullable: false),
                    DataOcorrencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcessoIdProcesso = table.Column<int>(type: "int", nullable: true),
                    Id_Processo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Ocorrencia", x => x.IdOcorrencia);
                    table.ForeignKey(
                        name: "FK_tb_Ocorrencia_tb_Processo_ProcessoIdProcesso",
                        column: x => x.ProcessoIdProcesso,
                        principalTable: "tb_Processo",
                        principalColumn: "IdProcesso",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    QtdePagamento = table.Column<int>(type: "int", nullable: false),
                    Id_Ocorrencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pagamento", x => x.IdPagamento);
                    table.ForeignKey(
                        name: "FK_tb_Pagamento_tb_Ocorrencia_Id_Ocorrencia",
                        column: x => x.Id_Ocorrencia,
                        principalTable: "tb_Ocorrencia",
                        principalColumn: "IdOcorrencia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Administrador_Id_Login",
                table: "tb_Administrador",
                column: "Id_Login");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Endereco_Id_Usuario",
                table: "tb_Endereco",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Ocorrencia_ProcessoIdProcesso",
                table: "tb_Ocorrencia",
                column: "ProcessoIdProcesso");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pagamento_Id_Ocorrencia",
                table: "tb_Pagamento",
                column: "Id_Ocorrencia");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Processo_Id_Usuario",
                table: "tb_Processo",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Usuario_Id_Login",
                table: "tb_Usuario",
                column: "Id_Login");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Administrador");

            migrationBuilder.DropTable(
                name: "tb_Endereco");

            migrationBuilder.DropTable(
                name: "tb_Pagamento");

            migrationBuilder.DropTable(
                name: "tb_Ocorrencia");

            migrationBuilder.DropTable(
                name: "tb_Processo");

            migrationBuilder.DropTable(
                name: "tb_Usuario");

            migrationBuilder.DropTable(
                name: "tb_Login");
        }
    }
}
