﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OgloszeniaDrobne.Migrations
{
    /// <inheritdoc />
    public partial class views : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Views",
                table: "Announcements");
        }
    }
}
