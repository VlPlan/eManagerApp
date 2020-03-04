using Microsoft.EntityFrameworkCore.Migrations;

namespace eManager.DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "143c73e2-4520-48b1-b622-fca4e783d2b6", "5a21a97c-5936-4d40-98bf-78f015a2989f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "be939f5e-783f-4550-97c8-4d6e3b6f2c51", "7292f74d-e266-4ae9-b9d5-d23e1c57764e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7292f74d-e266-4ae9-b9d5-d23e1c57764e", "51056c56-da75-462f-bd24-08ca4ae69f98" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "be939f5e-783f-4550-97c8-4d6e3b6f2c51", "2a4a2f8f-c869-40bb-9abd-bb85ad3c02e0" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1df07fd-76fe-4c82-9905-8fe146fc50ce", "b631e660-2695-47e6-ae1e-452186c68000", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a0c0dd3-eea5-4532-95df-d782d630777b", "489a3aaa-5c83-4257-8524-3be470bb401b", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "babe480c-8b1a-4b82-80fd-ebd1c2bacaab", 0, "ccb31d42-e51e-47ed-a8c3-37e01fbeac07", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "SUPPLIER", "AQAAAAEAACcQAAAAEE9r0Fo/nvIIMxKyQIE5aHOhW0ZUGU0bZ7Ezko9lNTw7MvyiFI+iWoqzAWM/5sXg/Q==", null, false, "", false, "supplier" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "babe480c-8b1a-4b82-80fd-ebd1c2bacaab", "a1df07fd-76fe-4c82-9905-8fe146fc50ce" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2a0c0dd3-eea5-4532-95df-d782d630777b", "489a3aaa-5c83-4257-8524-3be470bb401b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "babe480c-8b1a-4b82-80fd-ebd1c2bacaab", "a1df07fd-76fe-4c82-9905-8fe146fc50ce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "a1df07fd-76fe-4c82-9905-8fe146fc50ce", "b631e660-2695-47e6-ae1e-452186c68000" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "babe480c-8b1a-4b82-80fd-ebd1c2bacaab", "ccb31d42-e51e-47ed-a8c3-37e01fbeac07" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7292f74d-e266-4ae9-b9d5-d23e1c57764e", "51056c56-da75-462f-bd24-08ca4ae69f98", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "143c73e2-4520-48b1-b622-fca4e783d2b6", "5a21a97c-5936-4d40-98bf-78f015a2989f", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "be939f5e-783f-4550-97c8-4d6e3b6f2c51", 0, "2a4a2f8f-c869-40bb-9abd-bb85ad3c02e0", "supplier@mail.com", true, null, false, null, "supplier@mail.com", "SUPPLIER", "AQAAAAEAACcQAAAAEDwrmgBUgIQtpdxGSRjlMdcTVrtustdl66Sr77nIGCOaQ9SYPWOfLfzPpSa5NqP4kg==", null, false, "", false, "supplier" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "be939f5e-783f-4550-97c8-4d6e3b6f2c51", "7292f74d-e266-4ae9-b9d5-d23e1c57764e" });
        }
    }
}
