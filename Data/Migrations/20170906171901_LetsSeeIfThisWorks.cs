using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace testAuth.Data.Migrations
{
    public partial class LetsSeeIfThisWorks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDos",
                table: "ToDos");

            migrationBuilder.RenameTable(
                name: "ToDos",
                newName: "TodoModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoModel",
                table: "TodoModel",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoModel",
                table: "TodoModel");

            migrationBuilder.RenameTable(
                name: "TodoModel",
                newName: "ToDos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDos",
                table: "ToDos",
                column: "UserId");
        }
    }
}
