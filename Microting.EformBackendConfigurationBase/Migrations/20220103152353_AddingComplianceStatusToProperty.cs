﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microting.EformBackendConfigurationBase.Migrations
{
    public partial class AddingComplianceStatusToProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComplianceStatus",
                table: "PropertieVersions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ComplianceStatus",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComplianceStatus",
                table: "PropertieVersions");

            migrationBuilder.DropColumn(
                name: "ComplianceStatus",
                table: "Properties");
        }
    }
}
