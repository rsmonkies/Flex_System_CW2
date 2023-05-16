using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class amend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equpiments_Schedule_ClassScheduleId",
                table: "Equpiments");

            migrationBuilder.DropIndex(
                name: "IX_Equpiments_ClassScheduleId",
                table: "Equpiments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "242726d7-0514-43a4-876e-23958054b30f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f53571-8487-484c-bf4e-c0e69e4d5967");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa49cd6b-e1b3-4ab4-8e8c-fbbe1f38a998");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a5eb702-23be-4b60-b723-2621d9a60108", "0fed379d-1ce9-4602-a159-bdb943407c92" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a5eb702-23be-4b60-b723-2621d9a60108");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fed379d-1ce9-4602-a159-bdb943407c92");

            migrationBuilder.DropColumn(
                name: "ClassScheduleId",
                table: "Equpiments");

            migrationBuilder.CreateTable(
                name: "EquiptmentListEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EquiptmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClassScheduleId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquiptmentListEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquiptmentListEntry_Equpiments_EquiptmentId",
                        column: x => x.EquiptmentId,
                        principalTable: "Equpiments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquiptmentListEntry_Schedule_ClassScheduleId",
                        column: x => x.ClassScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d07cb4a-aae5-4ade-81f3-351172f624e5", "81cdaf23-8831-44fa-8422-eb539526385d", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c04b5f2a-08d3-4db8-96b5-731bea2cccb2", "059d73ba-6d8e-404b-ac92-05aa749cf7ab", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df290cd0-d575-4527-a596-ee1448b815c5", "cf9d4393-7ed7-49d9-814e-15935983f9b0", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0ede9a0-99c6-4d07-a69f-832559becbe0", "183d7364-9ed3-4953-8e17-a62d9d365edb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d433cca1-1c3f-4df1-bc88-90edf6fce895", 0, "7faad4dc-fe1d-4b09-9b03-bcd804c13be8", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEPzKo5D25qj17hkuddMJwJxy5KSn+TVx3nC3umIImIO32kGR5xo52ng+CSzjl1bDrg==", null, false, "862845ef-4666-4b2f-81e5-fcb16fe39e4b", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f0ede9a0-99c6-4d07-a69f-832559becbe0", "d433cca1-1c3f-4df1-bc88-90edf6fce895" });

            migrationBuilder.CreateIndex(
                name: "IX_EquiptmentListEntry_ClassScheduleId",
                table: "EquiptmentListEntry",
                column: "ClassScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_EquiptmentListEntry_EquiptmentId",
                table: "EquiptmentListEntry",
                column: "EquiptmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquiptmentListEntry");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d07cb4a-aae5-4ade-81f3-351172f624e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c04b5f2a-08d3-4db8-96b5-731bea2cccb2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df290cd0-d575-4527-a596-ee1448b815c5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0ede9a0-99c6-4d07-a69f-832559becbe0", "d433cca1-1c3f-4df1-bc88-90edf6fce895" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0ede9a0-99c6-4d07-a69f-832559becbe0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d433cca1-1c3f-4df1-bc88-90edf6fce895");

            migrationBuilder.AddColumn<int>(
                name: "ClassScheduleId",
                table: "Equpiments",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "242726d7-0514-43a4-876e-23958054b30f", "b3a2ee44-0a5d-47ea-8acb-0348797d2a53", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a5eb702-23be-4b60-b723-2621d9a60108", "0480fe20-3ec9-46e2-b754-210b3009125c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9f53571-8487-484c-bf4e-c0e69e4d5967", "b77c9ec9-8395-48d5-8632-26de100e2e40", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa49cd6b-e1b3-4ab4-8e8c-fbbe1f38a998", "8992a256-48a3-4a8d-827d-2e62b6ca7e4f", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0fed379d-1ce9-4602-a159-bdb943407c92", 0, "847d9241-7dc1-4664-8ba8-5956183bd92f", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFFOBkA3RFVj47qurBkGFHtOYXTr4vzcsx5WYigURum2vGuf7dpgb5SqGE8KKewEow==", null, false, "85a5a6d0-f92d-4862-a4b9-c0b74c388b58", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5a5eb702-23be-4b60-b723-2621d9a60108", "0fed379d-1ce9-4602-a159-bdb943407c92" });

            migrationBuilder.CreateIndex(
                name: "IX_Equpiments_ClassScheduleId",
                table: "Equpiments",
                column: "ClassScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equpiments_Schedule_ClassScheduleId",
                table: "Equpiments",
                column: "ClassScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");
        }
    }
}
