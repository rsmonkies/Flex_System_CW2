using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITS_System.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a905007c-6299-4f08-b669-7c860a0009ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aece007e-9cfc-439c-b94a-453ab9bc7c41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd7dd47a-fb5b-4901-aa9a-a281ed18a204");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e380bc7d-0d3d-4bd8-a07d-b2f20d798df5", "d4540ae2-29c4-4907-bac1-eee95ddcf9ab" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e380bc7d-0d3d-4bd8-a07d-b2f20d798df5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4540ae2-29c4-4907-bac1-eee95ddcf9ab");

            migrationBuilder.AddColumn<string>(
                name: "ClassName",
                table: "Bookings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c53295d-c710-4a9a-8c3a-50944c327f18", "279f83e6-aee2-43c5-9dbc-eae1f6c04aa5", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3a8a5422-5ada-463a-b944-f24dc60acd2e", "ec81e634-caaf-4909-8068-ecfb0332e247", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5154b819-d157-496b-95da-cc5371deb055", "6d94a3a6-34ba-4e3e-b48d-417d447d28a0", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abc602e1-8f03-45a0-8936-babfb468056c", "58de6e18-ede3-4f51-a155-bb4c9849c7ca", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5a5391f-e411-4f54-a174-15d88197045f", 0, "5c60448a-926f-4fd1-acf6-21800572292d", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEMChDbh/NOXGoWrZLKc+ZjxdzDYXoJOnRBeB0KmIr9fzeN/H47qwIey88QUDqWxDWw==", null, false, "1a800fb8-68d6-4c5a-89f5-011d2988bec3", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3a8a5422-5ada-463a-b944-f24dc60acd2e", "c5a5391f-e411-4f54-a174-15d88197045f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c53295d-c710-4a9a-8c3a-50944c327f18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5154b819-d157-496b-95da-cc5371deb055");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abc602e1-8f03-45a0-8936-babfb468056c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a8a5422-5ada-463a-b944-f24dc60acd2e", "c5a5391f-e411-4f54-a174-15d88197045f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a8a5422-5ada-463a-b944-f24dc60acd2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5a5391f-e411-4f54-a174-15d88197045f");

            migrationBuilder.DropColumn(
                name: "ClassName",
                table: "Bookings");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a905007c-6299-4f08-b669-7c860a0009ee", "97a79566-ba8e-41d4-a132-be482929cc5e", "Studio_Staff", "STUDIO_STAFF" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aece007e-9cfc-439c-b94a-453ab9bc7c41", "f896ea8c-ce74-43d8-a411-9a8ba1f3a131", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e380bc7d-0d3d-4bd8-a07d-b2f20d798df5", "6b3eb89a-dd5b-479b-a671-fd92f1023f7b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fd7dd47a-fb5b-4901-aa9a-a281ed18a204", "4348786f-ba30-4fa4-8e6b-a5fdbc5846d8", "Management_Team", "MANAGEMENT_TEAM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d4540ae2-29c4-4907-bac1-eee95ddcf9ab", 0, "27001aa8-e686-47c3-b8fe-1917a7d35064", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJMFxuYJATqDkUrItxVQe/puXbfT1rcctkR6Cn4h/0g6HkwcknSf2c3A2DGn90M3dw==", null, false, "b15ddce0-6eb0-4382-83f3-b5469cd3af34", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e380bc7d-0d3d-4bd8-a07d-b2f20d798df5", "d4540ae2-29c4-4907-bac1-eee95ddcf9ab" });
        }
    }
}
