using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeOrderingApp.Migrations
{
    public partial class A1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Masalar_Katlar_KatId",
                table: "Masalar");

            migrationBuilder.DropForeignKey(
                name: "FK_Siparisler_Masalar_MasaId",
                table: "Siparisler");

            migrationBuilder.DropForeignKey(
                name: "FK_Siparisler_Urunler_UrunId",
                table: "Siparisler");

            migrationBuilder.RenameColumn(
                name: "KatId",
                table: "Masalar",
                newName: "katId");

            migrationBuilder.RenameIndex(
                name: "IX_Masalar_KatId",
                table: "Masalar",
                newName: "IX_Masalar_katId");

            migrationBuilder.AlterColumn<int>(
                name: "UrunId",
                table: "Siparisler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MasaId",
                table: "Siparisler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Siparisler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DateTimeDay",
                table: "Siparisler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DateTimeHour",
                table: "Siparisler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "SiparisDurum",
                table: "Siparisler",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "katId",
                table: "Masalar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Masalar_Katlar_katId",
                table: "Masalar",
                column: "katId",
                principalTable: "Katlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Siparisler_Masalar_MasaId",
                table: "Siparisler",
                column: "MasaId",
                principalTable: "Masalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Siparisler_Urunler_UrunId",
                table: "Siparisler",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Masalar_Katlar_katId",
                table: "Masalar");

            migrationBuilder.DropForeignKey(
                name: "FK_Siparisler_Masalar_MasaId",
                table: "Siparisler");

            migrationBuilder.DropForeignKey(
                name: "FK_Siparisler_Urunler_UrunId",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "DateTimeDay",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "DateTimeHour",
                table: "Siparisler");

            migrationBuilder.DropColumn(
                name: "SiparisDurum",
                table: "Siparisler");

            migrationBuilder.RenameColumn(
                name: "katId",
                table: "Masalar",
                newName: "KatId");

            migrationBuilder.RenameIndex(
                name: "IX_Masalar_katId",
                table: "Masalar",
                newName: "IX_Masalar_KatId");

            migrationBuilder.AlterColumn<int>(
                name: "UrunId",
                table: "Siparisler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MasaId",
                table: "Siparisler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KatId",
                table: "Masalar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Masalar_Katlar_KatId",
                table: "Masalar",
                column: "KatId",
                principalTable: "Katlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Siparisler_Masalar_MasaId",
                table: "Siparisler",
                column: "MasaId",
                principalTable: "Masalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Siparisler_Urunler_UrunId",
                table: "Siparisler",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
