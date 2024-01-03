using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TE.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beneficiary",
                columns: table => new
                {
                    CIN = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyContactPhone = table.Column<string>(name: "MyContact_Phone", type: "nvarchar(max)", nullable: false),
                    MyContactAdress = table.Column<string>(name: "MyContact_Adress", type: "nvarchar(max)", nullable: false),
                    MyContactEmail = table.Column<string>(name: "MyContact_Email", type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiary", x => x.CIN);
                });

            migrationBuilder.CreateTable(
                name: "Donator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyContactPhone = table.Column<string>(name: "MyContact_Phone", type: "nvarchar(max)", nullable: false),
                    MyContactAdress = table.Column<string>(name: "MyContact_Adress", type: "nvarchar(max)", nullable: false),
                    MyContactEmail = table.Column<string>(name: "MyContact_Email", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Donation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    MyDonatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donation_Donator_MyDonatorId",
                        column: x => x.MyDonatorId,
                        principalTable: "Donator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kafala",
                columns: table => new
                {
                    DonatorFk = table.Column<int>(type: "int", nullable: false),
                    BeneficiaryFk = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kafala", x => new { x.BeneficiaryFk, x.DonatorFk });
                    table.ForeignKey(
                        name: "FK_Kafala_Beneficiary_BeneficiaryFk",
                        column: x => x.BeneficiaryFk,
                        principalTable: "Beneficiary",
                        principalColumn: "CIN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kafala_Donator_DonatorFk",
                        column: x => x.DonatorFk,
                        principalTable: "Donator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donation_MyDonatorId",
                table: "Donation",
                column: "MyDonatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Kafala_DonatorFk",
                table: "Kafala",
                column: "DonatorFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donation");

            migrationBuilder.DropTable(
                name: "Kafala");

            migrationBuilder.DropTable(
                name: "Beneficiary");

            migrationBuilder.DropTable(
                name: "Donator");
        }
    }
}
