﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektKrypto2.Migrations
{
    /// <inheritdoc />
    public partial class AddBalanceToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BalanceUsd",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BalanceUsd",
                table: "AspNetUsers");
        }
    }
}
