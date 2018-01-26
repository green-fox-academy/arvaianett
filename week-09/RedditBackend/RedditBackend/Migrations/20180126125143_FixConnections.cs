using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RedditBackend.Migrations
{
    public partial class FixConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Votes_VotesVoteId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_VotesVoteId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "VotesVoteId",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "VotesVoteId",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_VotesVoteId",
                table: "Posts",
                column: "VotesVoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Votes_VotesVoteId",
                table: "Posts",
                column: "VotesVoteId",
                principalTable: "Votes",
                principalColumn: "VoteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
