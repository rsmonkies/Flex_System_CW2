using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class initinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b2fe996-e27c-4d23-bb30-0520511208bf", "9ec8bd45-ea7d-4050-a3ce-dfbb5693bc2f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d21c025-0e07-4871-932e-31cd14559389", "525d6006-7dfc-498d-bdb1-2d896213e07a", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e233b554-2bff-4ded-96c2-f889e1b06ab6", "2dea7abb-3dc8-4a46-b90a-13184562175b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffa0dacd-c85f-4408-af7e-a731aaaa474d", "1e4ea0c2-262c-4a78-926d-520a67eb65af", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "66bea231-265f-4ccd-b418-becff85fe2c6", 0, "f01b099d-04ce-485e-821c-5e00097412a8", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEO9Y4PjIxNQjI+FIyDSy/nyvLfCiXPPVqr29A6LcMx052zH9I74EfmqteJ+xm1bA0g==", null, false, "28956696-a3e9-4663-84ee-e1290554c067", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e233b554-2bff-4ded-96c2-f889e1b06ab6", "66bea231-265f-4ccd-b418-becff85fe2c6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b2fe996-e27c-4d23-bb30-0520511208bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d21c025-0e07-4871-932e-31cd14559389");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffa0dacd-c85f-4408-af7e-a731aaaa474d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e233b554-2bff-4ded-96c2-f889e1b06ab6", "66bea231-265f-4ccd-b418-becff85fe2c6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e233b554-2bff-4ded-96c2-f889e1b06ab6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66bea231-265f-4ccd-b418-becff85fe2c6");

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
        }
    }
}
