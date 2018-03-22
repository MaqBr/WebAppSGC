using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGC.Infrastructure.Migrations
{
    public partial class AlteraNomeTabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_cliente",
                table: "Tb_cliente");

            migrationBuilder.RenameTable(
                name: "Tb_cliente",
                newName: "Cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Tb_cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_cliente",
                table: "Tb_cliente",
                column: "ClienteId");
        }
    }
}
