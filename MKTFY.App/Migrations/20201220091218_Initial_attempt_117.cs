using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MKTFY.App.Migrations
{
    public partial class Initial_attempt_117 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Asscociated_listingId = table.Column<int>(nullable: true),
                    buyerId = table.Column<string>(nullable: true),
                    sellerId = table.Column<string>(nullable: true),
                    createdOn = table.Column<DateTime>(nullable: false),
                    complete = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Listings_Asscociated_listingId",
                        column: x => x.Asscociated_listingId,
                        principalTable: "Listings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_buyerId",
                        column: x => x.buyerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_sellerId",
                        column: x => x.sellerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Asscociated_listingId",
                table: "Transactions",
                column: "Asscociated_listingId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_buyerId",
                table: "Transactions",
                column: "buyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_sellerId",
                table: "Transactions",
                column: "sellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
