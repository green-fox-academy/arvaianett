using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TodoSQL.Migrations
{
    public partial class TodoDatabaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Todos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Todos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Todos");
        }
    }
}
