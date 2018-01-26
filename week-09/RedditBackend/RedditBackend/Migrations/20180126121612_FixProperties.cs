using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RedditBackend.Migrations
{
    public partial class FixProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Votes");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vote",
                table: "Votes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Vote",
                table: "Votes");

            migrationBuilder.AddColumn<string>(
                name: "Score",
                table: "Votes",
                nullable: true);
        }
    }
}
