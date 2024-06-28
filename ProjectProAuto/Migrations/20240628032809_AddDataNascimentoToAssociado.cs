using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectProAuto.Migrations
{
    /// <inheritdoc />
    public partial class AddDataNascimentoToAssociado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "UsuarioModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "UsuarioModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "UsuarioModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "UsuarioModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "UsuarioModel");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "UsuarioModel");

            migrationBuilder.DropColumn(
                name: "Placa",
                table: "UsuarioModel");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "UsuarioModel");
        }
    }
}
