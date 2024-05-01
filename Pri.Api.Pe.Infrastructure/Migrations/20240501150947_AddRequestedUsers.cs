using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Api.Pe.Infrastructure.Migrations
{
    public partial class AddRequestedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("3fa3b5c5-085c-4013-bba4-6b2db2863fcb"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("44f81a83-73eb-44b5-8d8f-dbe2cfdd60eb"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("4c9f6d9b-041d-4b1b-b2db-01bac7776cd8"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("7cbd0c17-03a0-4cab-aad1-e9b11a8e3d8e"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("a0db7b01-2bff-4f07-afb5-6808d723788c"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("ac7fd910-1160-4244-b0ed-a5ad462a96e0"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("ad3bd743-2aa2-4671-9e1b-37bb98de0ac6"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("b339115b-b092-4910-aaee-cfb8b172eeb5"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("b7104ffa-1753-404b-b927-cb1bbd4e0da8"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("ef17eea0-c42b-4e7f-9922-2d1e72324e9e"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("030748c6-bc97-4b90-ad2c-8a4a68e42aa4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a37ba1db-ffe2-4c48-b673-e226e2aef206"), new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("4340cfc6-b2ab-4237-8b42-051672d4cc84") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("45b9931b-c0ab-4b50-854d-823d2d5eca03") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("516746f5-bbfb-4142-9feb-2137bf13f214") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("5a74e57d-b6af-4f18-82f1-abe45525b0d5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("7191028b-dc33-4e2e-b370-f8a8536993e3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("7b810efd-2974-4ca3-9a0c-cea7f612c07f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("f8a17ace-43f0-4fcc-b670-b5a06bfb99e7") });

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0f3b4f69-c601-42bd-af85-e843b5fbd327"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("2b46d955-30d9-43ea-afc6-9fa5733b5273"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3a419532-920d-4386-a23f-e33328e832b9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("4b970176-a33d-4748-a4c0-35184cb590a4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5009fe16-5535-4b36-a789-34eedcce7f46"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("78a71677-1c60-4462-99b4-2c587cb009b2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8b98ced1-7ee7-4fee-a391-ac05ecf7e518"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("cc98ec63-ea9d-4cdc-9386-aa6fbd77ae2f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f81ee746-5e28-4b20-90eb-0d44c683a448"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("fc103acc-36a3-4f58-9eb8-224f264aa057"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("23fde802-f5d1-4334-9370-bbfc53acaadf"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3a789810-1d02-481f-beb7-05cbcd0dcbfa"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3b5c883e-8562-4b7c-a72d-69b387dd2aa7"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("45cf86e2-4fb8-4601-a3c9-bbad06136db2"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("697423d7-ec46-447a-9264-59cc31e876a6"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6c83c3ee-b588-46c6-ae1d-85ef49779fc2"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7a34da19-409e-4966-aed6-9dc4c048c00e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("8b21a4b1-cf51-4323-ab4f-8f8ee2bc0c39"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ba8408ee-c712-40a1-800d-c10792b2406e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("c61e15a5-34e1-47a5-b5ec-c0b6112b2c98"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("508dbaf0-c5f6-4ed4-82a3-10d327d38dd9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("5ff80d34-aa0e-43cc-8451-7384045f1353"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7c1cd1ea-bfeb-4eea-a928-7d162654bcbc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("951f271f-acc0-44a6-a733-a818a6df08de"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("97cc32a8-8952-4243-a842-69d739f7df67"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("98dbdba7-3814-4841-a875-866f9fb55b22"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ab46049d-d86a-449b-a183-253dce046019"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ee535dd0-b8e1-4a91-94e4-2a725de99ed2"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("eeb546f6-c760-4813-adb8-7023c974335e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f5b4af01-fcb4-4a56-91c9-1e62aa651cc3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f9bb50fa-0f29-4b44-b945-1f59a17cea92"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fccdc345-2aa1-47ad-87ca-02d9235eb95e"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("22441512-4460-4658-bffd-e835f54cbcc8"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("689579c8-29e9-403b-a80b-4c0da4375b52"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("71b404b0-8a68-42e5-9035-39db0db06999"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a37ba1db-ffe2-4c48-b673-e226e2aef206"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("030748c6-bc97-4b90-ad2c-8a4a68e42aa4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4340cfc6-b2ab-4237-8b42-051672d4cc84"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("45b9931b-c0ab-4b50-854d-823d2d5eca03"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("516746f5-bbfb-4142-9feb-2137bf13f214"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5a74e57d-b6af-4f18-82f1-abe45525b0d5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7191028b-dc33-4e2e-b370-f8a8536993e3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7b810efd-2974-4ca3-9a0c-cea7f612c07f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f8a17ace-43f0-4fcc-b670-b5a06bfb99e7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("314bc995-c591-4418-b8b4-d30b653b8309"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("360a05a0-fece-4a5f-a7c7-78540dbf8571"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("38ecdf38-091c-4628-9aa9-23aa4d6b6d28"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("404a12b9-ce05-4471-9e70-f266e8c7f16e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("45d0eeb0-9920-42fc-82cd-bc7168b1f4a8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("50b23130-4a49-495e-947a-76561bf4b735"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6a339207-b51b-431c-a12e-7628f9d93f3b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("af24c937-fda1-4287-91e6-28faa37e60c7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("f34b03bc-4650-44ae-a6b0-c5ad584f2832"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fc0c3de2-b1a1-4703-aa2b-f0ab2a2b0008"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"));

            migrationBuilder.InsertData(
                table: "ApplicationStatus",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("a5ff6af1-e61f-498d-b271-95fcb0afee43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbe395c7-1169-4986-91d7-544c23c23109"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9381599-e1cc-49f5-8c0d-d6744770071c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), "2e22cecd-72bb-433c-a9e5-a218d845fb82", "Employee", "EMPLOYEE" },
                    { new Guid("b37d454e-3138-4fef-875e-5cc9e784e20c"), "4950e6ee-d2d7-4e03-8da0-f6e5d35341da", "Employer", "EMPLOYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { new Guid("0dae7d06-10da-4a43-80e6-5e6a5fa225b4"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "45b20740-ac35-4047-97fc-d2cea9ab0b74", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@test.com", true, "User", "3", false, null, "USER3@TEST.COM", "USER3", "AQAAAAEAACcQAAAAEMxJTeTtDUCipFZNz6hXEcpcXUd5Xb9+XHxB3bxod8L3qhCqEoF+KVdmN8vT/A+I5w==", null, false, "f42228d7-b4a9-4f7d-9953-14ee19150858", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { new Guid("19531dcf-cc65-48fe-b5c1-14a08ed84b0b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2ff665ce-777a-4f5e-a2d5-fb0ee108a721", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@test.com", true, "User", "10", false, null, "USER10@TEST.COM", "USER10", "AQAAAAEAACcQAAAAECipyUhAr3xmeba0qtYt9WCcuvfKPmEMQm0NmUuycQkx7Wad315btwCuBf9B1oknHg==", null, false, "e9f5dfd4-14f9-40c2-bb59-d3e7c068b681", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { new Guid("44850771-875a-4df9-8f92-2cee3c5d28df"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c3d24dd2-b982-4bf6-8071-822babf0f7e2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@test.com", true, "User", "9", false, null, "USER9@TEST.COM", "USER9", "AQAAAAEAACcQAAAAENhwAJkHC1BWiXol8ta4B9I9u7MipNhDhlfEWRxUpNfP9f3e6g1sDUcSh6ttrlMF6Q==", null, false, "51a299c7-60f6-4b2b-bfa7-bf9630395ace", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "07959f04-5f0d-440e-9335-16e24320e3be", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@test.com", true, "User", "1", false, null, "USER1@TEST.COM", "USER1", "AQAAAAEAACcQAAAAEMq10VEZWDfkQCDknD5qcYfrard3iACahJR1GlqyQzE4y5jNIDWXUISk03gngqK7pw==", null, false, "efa501e9-16e1-46e1-b910-557fccca1b6c", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { new Guid("773f8e3f-d924-4726-9195-bc9fb0955c1d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "98ef37fe-3c1c-4330-84e0-7dcd84ac5e6b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@pri.be", false, "Seed", "Admin", false, null, null, null, "AQAAAAEAACcQAAAAEFzgtikAtFhu2ecJVeqVsiyQTaHQpjwnHsaOi+nXtatFXSt1ilpFOceVzYqHF6K7jg==", null, false, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PriAdmin" },
                    { new Guid("7ec059dc-736a-4fa0-b71e-9170db856c36"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "61cd65dc-2b3a-45e2-9bfd-cc3808ef928a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@pri.be", false, "Seed", "User", false, null, null, null, "AQAAAAEAACcQAAAAECHoQSHAUwd/aBrAcpd9lBg36aunMSwp/va82xtQweY6Mcb9sKL8eerx7RwrErUGkA==", null, false, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PriUser" },
                    { new Guid("825aee24-b164-4b0d-9dbd-f4f1881bd977"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "db11d053-d927-4856-8896-369a92af8e28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@test.com", true, "User", "6", false, null, "USER6@TEST.COM", "USER6", "AQAAAAEAACcQAAAAEPno2hY7xn5LeOV4yMyyLxXuQxpwcoSkBnQJfLdN+kfVj1tllNiEB6NyHgGyADh/bg==", null, false, "15195177-cc38-4bc1-8bfe-c77571558ed9", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { new Guid("97bf7a82-5fe1-4a68-910b-4a389d0112e0"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "832a3d4f-be21-4685-9f0f-84909dda2961", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@test.com", true, "User", "4", false, null, "USER4@TEST.COM", "USER4", "AQAAAAEAACcQAAAAEBXY3qKIypDH3/KGDWLn0K9T7H4pXwrBfB5mn/ye41NtndAwQ3/9/aO3qx/LV3F/tw==", null, false, "15c8899c-c022-4782-b3fd-13356742697f", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { new Guid("cc2c3b03-ac91-484f-a031-ffe8e167ceff"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5c31a30c-67ac-4a40-b58f-8c9679122fe7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@test.com", true, "User", "7", false, null, "USER7@TEST.COM", "USER7", "AQAAAAEAACcQAAAAEM0GwFaunne2fiIf/bNzQE+yMmU5IbLwKrVSvkCN0UlSjJ1EzDwItaZcK3+bPECvAw==", null, false, "0186eb9d-764b-4ed2-a0bc-773e5fa8edb2", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { new Guid("d31c3484-0b65-495c-aba5-1e49ced194c8"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cf39fb52-121a-432e-abea-84f1f9cc7104", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@test.com", true, "User", "2", false, null, "USER2@TEST.COM", "USER2", "AQAAAAEAACcQAAAAEL3ek5Crs3fyfHbNVzSo2W1gksFevG0wma1j0h1MMA+L7kASNVa0Q9CfQ+i3K98GXg==", null, false, "7b41b01e-78bc-459c-8d65-1a94837a6b23", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { new Guid("dea5dc4b-6425-4219-a558-afdfd1716056"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b8c62ae4-da7c-4a7c-98d2-043baffa0e71", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@test.com", true, "User", "8", false, null, "USER8@TEST.COM", "USER8", "AQAAAAEAACcQAAAAEGsSQXF2X/8HXIP37ub0UBJPxc6DcSR0CkIGTBIRIOBJL8gIRX+TO+qMNPamqlGe2Q==", null, false, "c9e9ce9c-b0b0-49d8-9a67-73908246ee77", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { new Guid("fc9e1515-032f-4915-a090-4941a73a5f0a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ddb8acf7-cff5-4757-b02a-978709db239f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@test.com", true, "User", "5", false, null, "USER5@TEST.COM", "USER5", "AQAAAAEAACcQAAAAELKnGphUTjyJFlEPyT2YGcBfEavOC9mji8xPBHbXZ8dluQTpURkoCwaBqKBiM2Y1MA==", null, false, "04e24fa1-6c62-4af1-ba33-d4f9942caee6", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("1f30652e-de04-46dc-818e-57546eca438c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2716f8c2-65da-463e-a12a-53322e5005de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sewing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30357a6c-e704-4d60-adc3-11973054838b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Painting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35ec3df0-da38-4ce8-ad9b-dc94831da93e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Driving", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40a9ac01-f650-4b46-8c2f-1c2abf7cef02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teaching", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52084af5-4f16-463d-b91c-8ec15a12bacd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("636861c3-3fce-4b6e-b9d2-76c021c9adfc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maths", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6993c48b-c8ee-4530-8ff8-64e9530f098c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gardening", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a3bccb0-feff-46b0-9cfc-7bbaddbf591b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Language", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("700dbc74-4cbc-49b9-a894-041c8cb41de6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleaning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c370aa61-b6f8-4a04-8598-f73448c210cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Photography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ecc3be73-165f-4c2f-a841-625ec9150d6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Writing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("0dae7d06-10da-4a43-80e6-5e6a5fa225b4") },
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("19531dcf-cc65-48fe-b5c1-14a08ed84b0b") },
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("44850771-875a-4df9-8f92-2cee3c5d28df") },
                    { new Guid("b37d454e-3138-4fef-875e-5cc9e784e20c"), new Guid("642df0fa-a51a-4a65-a30f-735135ec2303") },
                    { new Guid("b37d454e-3138-4fef-875e-5cc9e784e20c"), new Guid("773f8e3f-d924-4726-9195-bc9fb0955c1d") },
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("7ec059dc-736a-4fa0-b71e-9170db856c36") },
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("825aee24-b164-4b0d-9dbd-f4f1881bd977") },
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("97bf7a82-5fe1-4a68-910b-4a389d0112e0") },
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("cc2c3b03-ac91-484f-a031-ffe8e167ceff") },
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("d31c3484-0b65-495c-aba5-1e49ced194c8") },
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("dea5dc4b-6425-4219-a558-afdfd1716056") },
                    { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("fc9e1515-032f-4915-a090-4941a73a5f0a") }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Created", "Description", "EmployerId", "Name", "Salary", "Updated" },
                values: new object[,]
                {
                    { new Guid("0725f3ea-1ba2-4350-a853-2c2fe0d00869"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job1 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job1", 10.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08fa7db3-affe-482d-88d0-9cfbff494e3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job2 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job2", 20.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28b01933-0122-4aa9-9ecc-34c9b0ec2e99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job9 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job9", 90.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3de0e954-148f-4988-bf1f-fca5eeda5e37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job10 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job10", 100.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d8186a1-89b5-4b33-9592-50de5c63cc74"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job4 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job4", 40.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85577dee-7a78-48e2-9f2a-bd98a83214b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job6 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job6", 60.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90d1c0b4-6836-4e0d-88e0-c8f586e817a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job7 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job7", 70.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aed0cc12-829e-4d1f-9710-c0425cd024d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job8 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job8", 80.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd26c191-4c0c-4f47-aabd-02e68426f774"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job3 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job3", 30.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eaf12008-3130-4d06-b4c3-189a34dff167"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job5 description", new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), "Job5", 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Created", "ReceiverId", "SenderId", "Updated" },
                values: new object[,]
                {
                    { new Guid("3e8433a0-cb73-45d9-8d81-669c0d2ebfd5"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("825aee24-b164-4b0d-9dbd-f4f1881bd977"), new Guid("fc9e1515-032f-4915-a090-4941a73a5f0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6480d4a2-c5bf-4f68-99f4-093b6fa6d544"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ec059dc-736a-4fa0-b71e-9170db856c36"), new Guid("19531dcf-cc65-48fe-b5c1-14a08ed84b0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e084ac2-dae2-4e7d-a311-65ba3d2adbd4"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cc2c3b03-ac91-484f-a031-ffe8e167ceff"), new Guid("825aee24-b164-4b0d-9dbd-f4f1881bd977"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d041ebd-0575-4546-abaa-a04258d98bdb"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fc9e1515-032f-4915-a090-4941a73a5f0a"), new Guid("97bf7a82-5fe1-4a68-910b-4a389d0112e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("977ac140-dd39-44bd-8623-739822e2e22f"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("19531dcf-cc65-48fe-b5c1-14a08ed84b0b"), new Guid("44850771-875a-4df9-8f92-2cee3c5d28df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8c2ae49-e25d-49f9-b799-6390e06f7c16"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dea5dc4b-6425-4219-a558-afdfd1716056"), new Guid("cc2c3b03-ac91-484f-a031-ffe8e167ceff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4b867ca-fccb-4937-95d2-93f2c377ad33"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d31c3484-0b65-495c-aba5-1e49ced194c8"), new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b76d4534-66e1-4c11-b8e0-69f1f7c31b55"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("97bf7a82-5fe1-4a68-910b-4a389d0112e0"), new Guid("0dae7d06-10da-4a43-80e6-5e6a5fa225b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8f1f800-dcbf-4ca4-9876-787762cf9afb"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44850771-875a-4df9-8f92-2cee3c5d28df"), new Guid("dea5dc4b-6425-4219-a558-afdfd1716056"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebacc839-0381-4162-8f31-dabec3727d2c"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0dae7d06-10da-4a43-80e6-5e6a5fa225b4"), new Guid("d31c3484-0b65-495c-aba5-1e49ced194c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Created", "Rating", "RevieweeId", "ReviewerId", "Updated" },
                values: new object[,]
                {
                    { new Guid("15acfb83-70d1-4c73-a2d4-e713231d0998"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("19531dcf-cc65-48fe-b5c1-14a08ed84b0b"), new Guid("44850771-875a-4df9-8f92-2cee3c5d28df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a59c158-9c21-45c7-9608-b9c3515790ce"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("dea5dc4b-6425-4219-a558-afdfd1716056"), new Guid("cc2c3b03-ac91-484f-a031-ffe8e167ceff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e113e58-24af-4bba-802a-9eea4c04dcd6"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("825aee24-b164-4b0d-9dbd-f4f1881bd977"), new Guid("fc9e1515-032f-4915-a090-4941a73a5f0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95bd655c-c9f2-485f-a181-a59bd48d5497"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("7ec059dc-736a-4fa0-b71e-9170db856c36"), new Guid("19531dcf-cc65-48fe-b5c1-14a08ed84b0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac90871a-bdf7-460f-b14a-0c8a86202923"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("0dae7d06-10da-4a43-80e6-5e6a5fa225b4"), new Guid("d31c3484-0b65-495c-aba5-1e49ced194c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae94c023-1953-4964-9cd9-8fd3329099dc"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("44850771-875a-4df9-8f92-2cee3c5d28df"), new Guid("dea5dc4b-6425-4219-a558-afdfd1716056"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba38fff6-e8b0-4be4-ae72-4a41dbb3814e"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("cc2c3b03-ac91-484f-a031-ffe8e167ceff"), new Guid("825aee24-b164-4b0d-9dbd-f4f1881bd977"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc539441-7759-4bf7-94c7-176cc53406e9"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("d31c3484-0b65-495c-aba5-1e49ced194c8"), new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c5d3945c-547f-412e-822a-e0726746e29f"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("97bf7a82-5fe1-4a68-910b-4a389d0112e0"), new Guid("0dae7d06-10da-4a43-80e6-5e6a5fa225b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd623110-79f8-4001-b2c0-c4cba982976d"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("fc9e1515-032f-4915-a090-4941a73a5f0a"), new Guid("97bf7a82-5fe1-4a68-910b-4a389d0112e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CandidateId", "Created", "JobId", "Salary", "StatusId", "Updated" },
                values: new object[,]
                {
                    { new Guid("1acfacf6-3366-4e81-a8f9-a4798045f18c"), new Guid("19531dcf-cc65-48fe-b5c1-14a08ed84b0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("28b01933-0122-4aa9-9ecc-34c9b0ec2e99"), 0.0, new Guid("bbe395c7-1169-4986-91d7-544c23c23109"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b75d43b-644d-4092-be4c-4e8fa95e594d"), new Guid("97bf7a82-5fe1-4a68-910b-4a389d0112e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bd26c191-4c0c-4f47-aabd-02e68426f774"), 0.0, new Guid("bbe395c7-1169-4986-91d7-544c23c23109"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e632a85-c61b-4f90-8902-aae13d7ca0b5"), new Guid("dea5dc4b-6425-4219-a558-afdfd1716056"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("90d1c0b4-6836-4e0d-88e0-c8f586e817a0"), 0.0, new Guid("d9381599-e1cc-49f5-8c0d-d6744770071c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("747c8a78-c178-47c3-bf5f-80d4501e9c2e"), new Guid("44850771-875a-4df9-8f92-2cee3c5d28df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aed0cc12-829e-4d1f-9710-c0425cd024d6"), 0.0, new Guid("a5ff6af1-e61f-498d-b271-95fcb0afee43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96af8f60-fba3-4117-bedf-6251ea272cbd"), new Guid("cc2c3b03-ac91-484f-a031-ffe8e167ceff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("85577dee-7a78-48e2-9f2a-bd98a83214b2"), 0.0, new Guid("bbe395c7-1169-4986-91d7-544c23c23109"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4a84d27-b663-4aca-bf12-31472581ffa1"), new Guid("fc9e1515-032f-4915-a090-4941a73a5f0a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d8186a1-89b5-4b33-9592-50de5c63cc74"), 0.0, new Guid("d9381599-e1cc-49f5-8c0d-d6744770071c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd53459a-9705-456b-8722-4db9e74de91f"), new Guid("0dae7d06-10da-4a43-80e6-5e6a5fa225b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("08fa7db3-affe-482d-88d0-9cfbff494e3a"), 0.0, new Guid("a5ff6af1-e61f-498d-b271-95fcb0afee43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cfbcb2f3-c633-4073-8c35-70606f72fda8"), new Guid("d31c3484-0b65-495c-aba5-1e49ced194c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0725f3ea-1ba2-4350-a853-2c2fe0d00869"), 0.0, new Guid("d9381599-e1cc-49f5-8c0d-d6744770071c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d839367c-09a9-486f-9366-551aea5789ba"), new Guid("825aee24-b164-4b0d-9dbd-f4f1881bd977"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eaf12008-3130-4d06-b4c3-189a34dff167"), 0.0, new Guid("a5ff6af1-e61f-498d-b271-95fcb0afee43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb99f4ae-1333-4ac9-9f88-f9d46b0c507b"), new Guid("7ec059dc-736a-4fa0-b71e-9170db856c36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3de0e954-148f-4988-bf1f-fca5eeda5e37"), 0.0, new Guid("d9381599-e1cc-49f5-8c0d-d6744770071c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("1acfacf6-3366-4e81-a8f9-a4798045f18c"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("1b75d43b-644d-4092-be4c-4e8fa95e594d"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("6e632a85-c61b-4f90-8902-aae13d7ca0b5"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("747c8a78-c178-47c3-bf5f-80d4501e9c2e"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("96af8f60-fba3-4117-bedf-6251ea272cbd"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("c4a84d27-b663-4aca-bf12-31472581ffa1"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("cd53459a-9705-456b-8722-4db9e74de91f"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("cfbcb2f3-c633-4073-8c35-70606f72fda8"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("d839367c-09a9-486f-9366-551aea5789ba"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("fb99f4ae-1333-4ac9-9f88-f9d46b0c507b"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("0dae7d06-10da-4a43-80e6-5e6a5fa225b4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("19531dcf-cc65-48fe-b5c1-14a08ed84b0b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("44850771-875a-4df9-8f92-2cee3c5d28df") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b37d454e-3138-4fef-875e-5cc9e784e20c"), new Guid("642df0fa-a51a-4a65-a30f-735135ec2303") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b37d454e-3138-4fef-875e-5cc9e784e20c"), new Guid("773f8e3f-d924-4726-9195-bc9fb0955c1d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("7ec059dc-736a-4fa0-b71e-9170db856c36") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("825aee24-b164-4b0d-9dbd-f4f1881bd977") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("97bf7a82-5fe1-4a68-910b-4a389d0112e0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("cc2c3b03-ac91-484f-a031-ffe8e167ceff") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("d31c3484-0b65-495c-aba5-1e49ced194c8") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("dea5dc4b-6425-4219-a558-afdfd1716056") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"), new Guid("fc9e1515-032f-4915-a090-4941a73a5f0a") });

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3e8433a0-cb73-45d9-8d81-669c0d2ebfd5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6480d4a2-c5bf-4f68-99f4-093b6fa6d544"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7e084ac2-dae2-4e7d-a311-65ba3d2adbd4"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("8d041ebd-0575-4546-abaa-a04258d98bdb"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("977ac140-dd39-44bd-8623-739822e2e22f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("a8c2ae49-e25d-49f9-b799-6390e06f7c16"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b4b867ca-fccb-4937-95d2-93f2c377ad33"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b76d4534-66e1-4c11-b8e0-69f1f7c31b55"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d8f1f800-dcbf-4ca4-9876-787762cf9afb"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ebacc839-0381-4162-8f31-dabec3727d2c"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("15acfb83-70d1-4c73-a2d4-e713231d0998"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("2a59c158-9c21-45c7-9608-b9c3515790ce"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("2e113e58-24af-4bba-802a-9eea4c04dcd6"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("95bd655c-c9f2-485f-a181-a59bd48d5497"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ac90871a-bdf7-460f-b14a-0c8a86202923"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ae94c023-1953-4964-9cd9-8fd3329099dc"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ba38fff6-e8b0-4be4-ae72-4a41dbb3814e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("bc539441-7759-4bf7-94c7-176cc53406e9"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("c5d3945c-547f-412e-822a-e0726746e29f"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("fd623110-79f8-4001-b2c0-c4cba982976d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1f30652e-de04-46dc-818e-57546eca438c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2716f8c2-65da-463e-a12a-53322e5005de"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("30357a6c-e704-4d60-adc3-11973054838b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("35ec3df0-da38-4ce8-ad9b-dc94831da93e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("40a9ac01-f650-4b46-8c2f-1c2abf7cef02"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("52084af5-4f16-463d-b91c-8ec15a12bacd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("636861c3-3fce-4b6e-b9d2-76c021c9adfc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6993c48b-c8ee-4530-8ff8-64e9530f098c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6a3bccb0-feff-46b0-9cfc-7bbaddbf591b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("700dbc74-4cbc-49b9-a894-041c8cb41de6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c370aa61-b6f8-4a04-8598-f73448c210cb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ecc3be73-165f-4c2f-a841-625ec9150d6d"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("a5ff6af1-e61f-498d-b271-95fcb0afee43"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("bbe395c7-1169-4986-91d7-544c23c23109"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("d9381599-e1cc-49f5-8c0d-d6744770071c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2c94bf82-cd5f-481f-9f33-61a83d79655a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b37d454e-3138-4fef-875e-5cc9e784e20c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0dae7d06-10da-4a43-80e6-5e6a5fa225b4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19531dcf-cc65-48fe-b5c1-14a08ed84b0b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("44850771-875a-4df9-8f92-2cee3c5d28df"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("773f8e3f-d924-4726-9195-bc9fb0955c1d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ec059dc-736a-4fa0-b71e-9170db856c36"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("825aee24-b164-4b0d-9dbd-f4f1881bd977"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97bf7a82-5fe1-4a68-910b-4a389d0112e0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cc2c3b03-ac91-484f-a031-ffe8e167ceff"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d31c3484-0b65-495c-aba5-1e49ced194c8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dea5dc4b-6425-4219-a558-afdfd1716056"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fc9e1515-032f-4915-a090-4941a73a5f0a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0725f3ea-1ba2-4350-a853-2c2fe0d00869"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("08fa7db3-affe-482d-88d0-9cfbff494e3a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("28b01933-0122-4aa9-9ecc-34c9b0ec2e99"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3de0e954-148f-4988-bf1f-fca5eeda5e37"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5d8186a1-89b5-4b33-9592-50de5c63cc74"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("85577dee-7a78-48e2-9f2a-bd98a83214b2"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("90d1c0b4-6836-4e0d-88e0-c8f586e817a0"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("aed0cc12-829e-4d1f-9710-c0425cd024d6"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("bd26c191-4c0c-4f47-aabd-02e68426f774"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("eaf12008-3130-4d06-b4c3-189a34dff167"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("642df0fa-a51a-4a65-a30f-735135ec2303"));

            migrationBuilder.InsertData(
                table: "ApplicationStatus",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("22441512-4460-4658-bffd-e835f54cbcc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("689579c8-29e9-403b-a80b-4c0da4375b52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71b404b0-8a68-42e5-9035-39db0db06999"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("a37ba1db-ffe2-4c48-b673-e226e2aef206"), "e0571461-51e7-4fa5-b6da-01e256268514", "Employer", "EMPLOYER" },
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), "9c8a7429-dfe2-43ca-a133-473e139fb412", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { new Guid("030748c6-bc97-4b90-ad2c-8a4a68e42aa4"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "76f5ab9e-1608-4924-9673-e47d06b143af", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@test.com", true, "User", "6", false, null, "USER6@TEST.COM", "USER6", "AQAAAAEAACcQAAAAEIK9Yrmggs3LeUukGBBsruYVOpgLsB73YeVS2NVc1TuqCsoyphbRZOzqz1qyOswbLg==", null, false, "9c3b6b5b-4945-4441-98ec-de4754f25e97", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "667361b2-f89b-46ba-b7f9-2f000ac73ca9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@test.com", true, "User", "1", false, null, "USER1@TEST.COM", "USER1", "AQAAAAEAACcQAAAAEIFmKJiLRaPFZAkaRXKkRrw3q9ALC/SdfSH9zfEGW62pmeflY0F+SqPCRhrQpIWkzQ==", null, false, "d6c115e7-89b2-4686-9fe0-342a14cbb184", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { new Guid("4340cfc6-b2ab-4237-8b42-051672d4cc84"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0a22cdd0-b392-441e-bfb0-c2d407f286f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@test.com", true, "User", "5", false, null, "USER5@TEST.COM", "USER5", "AQAAAAEAACcQAAAAEG2jYoMHGbpk+mxITaInAo495xsT9ygexQGQj/DvZGYn15wEyKWtabMwxuLOxRViYA==", null, false, "1a0cb510-aaae-4105-8fad-4e9d64435edc", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { new Guid("45b9931b-c0ab-4b50-854d-823d2d5eca03"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3577fa2b-d2ab-4525-9072-2b87da8f1911", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@test.com", true, "User", "4", false, null, "USER4@TEST.COM", "USER4", "AQAAAAEAACcQAAAAEHLB1Io7zRgNL57uQvdw7W6IJqwqGFxI3bf0GpNHBhfqYzdXyaGYZnwxVlaj6STvhw==", null, false, "c579ff47-6edc-48e3-8556-02aba5bda210", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dd1e11a1-cacb-49ae-8301-307c43bb2ece", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@test.com", true, "User", "2", false, null, "USER2@TEST.COM", "USER2", "AQAAAAEAACcQAAAAEJYDbzrpSMlzuSurpLK1gyP3fsPGog4E1hVM6keszTBgJGxUavGkERPUsAQ62yAp8g==", null, false, "f48d21de-5c29-4116-a342-662a64e9ce60", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { new Guid("516746f5-bbfb-4142-9feb-2137bf13f214"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa90b982-e315-492a-8ff3-a23ec27f7b58", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@test.com", true, "User", "8", false, null, "USER8@TEST.COM", "USER8", "AQAAAAEAACcQAAAAEIaT6j7sDNkT708BLbcQOhV1MBTDuUnDRo3t32ehknomwWV38+EY7paFmFL5Rn+YDw==", null, false, "48967b98-bff8-40bf-9edf-3895f3f275f9", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { new Guid("5a74e57d-b6af-4f18-82f1-abe45525b0d5"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5fec5c61-2f31-4589-a7a5-70948fecddd5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@test.com", true, "User", "7", false, null, "USER7@TEST.COM", "USER7", "AQAAAAEAACcQAAAAENJ+d4xNxvTvkXeNwBE1a6FTKA7KYrKxmy8UWFlnXxg21Cwf9IhIhbirLo8VehaDDw==", null, false, "cb84c5ec-3665-473d-808d-cb900455c001", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { new Guid("7191028b-dc33-4e2e-b370-f8a8536993e3"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cf35156-686f-4ad7-a033-47be277d9af7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@test.com", true, "User", "10", false, null, "USER10@TEST.COM", "USER10", "AQAAAAEAACcQAAAAEN3pgrT0yIXECWUx1WgIuUhK0v0uTKm7zugNcxQPVj/CyBlJseXYIvzy+61U5QEHGA==", null, false, "2a5e7834-c719-4128-8df0-df94bb8a72db", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { new Guid("7b810efd-2974-4ca3-9a0c-cea7f612c07f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5f3531df-745b-45e4-91d4-57b9431c3e21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@test.com", true, "User", "9", false, null, "USER9@TEST.COM", "USER9", "AQAAAAEAACcQAAAAEEBxnyR0Ya3pf/PU3NKO/l5PIF5t5K2qSIKeh/DiBtKnoH9ucH8UyM61fA7Sit2D2Q==", null, false, "8f69f06e-4f1a-4e48-a564-d6fa405e592c", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { new Guid("f8a17ace-43f0-4fcc-b670-b5a06bfb99e7"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ca07e0a4-d786-48bc-bb22-0d2050addb09", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@test.com", true, "User", "3", false, null, "USER3@TEST.COM", "USER3", "AQAAAAEAACcQAAAAEN2EaaoFpVTOpk5KCObKAkhz74R1hBBd+mTkrMbKa+Zvin9hwCOywx7wRj1XmIQg+A==", null, false, "6c94de2c-39e4-4fc8-be90-3350ff5e8cac", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("508dbaf0-c5f6-4ed4-82a3-10d327d38dd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sewing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ff80d34-aa0e-43cc-8451-7384045f1353"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Driving", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c1cd1ea-bfeb-4eea-a928-7d162654bcbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teaching", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("951f271f-acc0-44a6-a733-a818a6df08de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Writing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97cc32a8-8952-4243-a842-69d739f7df67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98dbdba7-3814-4841-a875-866f9fb55b22"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Language", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab46049d-d86a-449b-a183-253dce046019"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleaning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee535dd0-b8e1-4a91-94e4-2a725de99ed2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maths", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eeb546f6-c760-4813-adb8-7023c974335e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gardening", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5b4af01-fcb4-4a56-91c9-1e62aa651cc3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Photography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9bb50fa-0f29-4b44-b945-1f59a17cea92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Painting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fccdc345-2aa1-47ad-87ca-02d9235eb95e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("030748c6-bc97-4b90-ad2c-8a4a68e42aa4") },
                    { new Guid("a37ba1db-ffe2-4c48-b673-e226e2aef206"), new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc") },
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("4340cfc6-b2ab-4237-8b42-051672d4cc84") },
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("45b9931b-c0ab-4b50-854d-823d2d5eca03") },
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0") },
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("516746f5-bbfb-4142-9feb-2137bf13f214") },
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("5a74e57d-b6af-4f18-82f1-abe45525b0d5") },
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("7191028b-dc33-4e2e-b370-f8a8536993e3") },
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("7b810efd-2974-4ca3-9a0c-cea7f612c07f") },
                    { new Guid("f68c2dac-72aa-46b3-b0c2-b6fdc0b08171"), new Guid("f8a17ace-43f0-4fcc-b670-b5a06bfb99e7") }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Created", "Description", "EmployerId", "Name", "Salary", "Updated" },
                values: new object[,]
                {
                    { new Guid("314bc995-c591-4418-b8b4-d30b653b8309"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job4 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job4", 40.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("360a05a0-fece-4a5f-a7c7-78540dbf8571"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job3 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job3", 30.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("38ecdf38-091c-4628-9aa9-23aa4d6b6d28"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job8 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job8", 80.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("404a12b9-ce05-4471-9e70-f266e8c7f16e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job10 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job10", 100.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45d0eeb0-9920-42fc-82cd-bc7168b1f4a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job1 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job1", 10.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50b23130-4a49-495e-947a-76561bf4b735"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job7 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job7", 70.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a339207-b51b-431c-a12e-7628f9d93f3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job6 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job6", 60.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af24c937-fda1-4287-91e6-28faa37e60c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job9 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job9", 90.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f34b03bc-4650-44ae-a6b0-c5ad584f2832"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job2 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job2", 20.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc0c3de2-b1a1-4703-aa2b-f0ab2a2b0008"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job5 description", new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), "Job5", 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Created", "ReceiverId", "SenderId", "Updated" },
                values: new object[,]
                {
                    { new Guid("0f3b4f69-c601-42bd-af85-e843b5fbd327"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f8a17ace-43f0-4fcc-b670-b5a06bfb99e7"), new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b46d955-30d9-43ea-afc6-9fa5733b5273"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45b9931b-c0ab-4b50-854d-823d2d5eca03"), new Guid("f8a17ace-43f0-4fcc-b670-b5a06bfb99e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a419532-920d-4386-a23f-e33328e832b9"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b810efd-2974-4ca3-9a0c-cea7f612c07f"), new Guid("516746f5-bbfb-4142-9feb-2137bf13f214"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b970176-a33d-4748-a4c0-35184cb590a4"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4340cfc6-b2ab-4237-8b42-051672d4cc84"), new Guid("45b9931b-c0ab-4b50-854d-823d2d5eca03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5009fe16-5535-4b36-a789-34eedcce7f46"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("516746f5-bbfb-4142-9feb-2137bf13f214"), new Guid("5a74e57d-b6af-4f18-82f1-abe45525b0d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78a71677-1c60-4462-99b4-2c587cb009b2"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0"), new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b98ced1-7ee7-4fee-a391-ac05ecf7e518"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5a74e57d-b6af-4f18-82f1-abe45525b0d5"), new Guid("030748c6-bc97-4b90-ad2c-8a4a68e42aa4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc98ec63-ea9d-4cdc-9386-aa6fbd77ae2f"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7191028b-dc33-4e2e-b370-f8a8536993e3"), new Guid("7b810efd-2974-4ca3-9a0c-cea7f612c07f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f81ee746-5e28-4b20-90eb-0d44c683a448"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("030748c6-bc97-4b90-ad2c-8a4a68e42aa4"), new Guid("4340cfc6-b2ab-4237-8b42-051672d4cc84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc103acc-36a3-4f58-9eb8-224f264aa057"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), new Guid("7191028b-dc33-4e2e-b370-f8a8536993e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Created", "Rating", "RevieweeId", "ReviewerId", "Updated" },
                values: new object[,]
                {
                    { new Guid("23fde802-f5d1-4334-9370-bbfc53acaadf"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("f8a17ace-43f0-4fcc-b670-b5a06bfb99e7"), new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a789810-1d02-481f-beb7-05cbcd0dcbfa"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("7191028b-dc33-4e2e-b370-f8a8536993e3"), new Guid("7b810efd-2974-4ca3-9a0c-cea7f612c07f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b5c883e-8562-4b7c-a72d-69b387dd2aa7"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("030748c6-bc97-4b90-ad2c-8a4a68e42aa4"), new Guid("4340cfc6-b2ab-4237-8b42-051672d4cc84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45cf86e2-4fb8-4601-a3c9-bbad06136db2"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), new Guid("7191028b-dc33-4e2e-b370-f8a8536993e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("697423d7-ec46-447a-9264-59cc31e876a6"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("5a74e57d-b6af-4f18-82f1-abe45525b0d5"), new Guid("030748c6-bc97-4b90-ad2c-8a4a68e42aa4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c83c3ee-b588-46c6-ae1d-85ef49779fc2"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0"), new Guid("14a9c196-1a36-4870-ae9b-0fe36bedb7bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a34da19-409e-4966-aed6-9dc4c048c00e"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("516746f5-bbfb-4142-9feb-2137bf13f214"), new Guid("5a74e57d-b6af-4f18-82f1-abe45525b0d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b21a4b1-cf51-4323-ab4f-8f8ee2bc0c39"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("45b9931b-c0ab-4b50-854d-823d2d5eca03"), new Guid("f8a17ace-43f0-4fcc-b670-b5a06bfb99e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba8408ee-c712-40a1-800d-c10792b2406e"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("4340cfc6-b2ab-4237-8b42-051672d4cc84"), new Guid("45b9931b-c0ab-4b50-854d-823d2d5eca03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c61e15a5-34e1-47a5-b5ec-c0b6112b2c98"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("7b810efd-2974-4ca3-9a0c-cea7f612c07f"), new Guid("516746f5-bbfb-4142-9feb-2137bf13f214"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CandidateId", "Created", "JobId", "Salary", "StatusId", "Updated" },
                values: new object[,]
                {
                    { new Guid("3fa3b5c5-085c-4013-bba4-6b2db2863fcb"), new Guid("516746f5-bbfb-4142-9feb-2137bf13f214"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("50b23130-4a49-495e-947a-76561bf4b735"), 0.0, new Guid("22441512-4460-4658-bffd-e835f54cbcc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44f81a83-73eb-44b5-8d8f-dbe2cfdd60eb"), new Guid("7191028b-dc33-4e2e-b370-f8a8536993e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("af24c937-fda1-4287-91e6-28faa37e60c7"), 0.0, new Guid("689579c8-29e9-403b-a80b-4c0da4375b52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c9f6d9b-041d-4b1b-b2db-01bac7776cd8"), new Guid("45b9931b-c0ab-4b50-854d-823d2d5eca03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("360a05a0-fece-4a5f-a7c7-78540dbf8571"), 0.0, new Guid("689579c8-29e9-403b-a80b-4c0da4375b52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7cbd0c17-03a0-4cab-aad1-e9b11a8e3d8e"), new Guid("030748c6-bc97-4b90-ad2c-8a4a68e42aa4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fc0c3de2-b1a1-4703-aa2b-f0ab2a2b0008"), 0.0, new Guid("71b404b0-8a68-42e5-9035-39db0db06999"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0db7b01-2bff-4f07-afb5-6808d723788c"), new Guid("5a74e57d-b6af-4f18-82f1-abe45525b0d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a339207-b51b-431c-a12e-7628f9d93f3b"), 0.0, new Guid("689579c8-29e9-403b-a80b-4c0da4375b52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac7fd910-1160-4244-b0ed-a5ad462a96e0"), new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("404a12b9-ce05-4471-9e70-f266e8c7f16e"), 0.0, new Guid("22441512-4460-4658-bffd-e835f54cbcc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad3bd743-2aa2-4671-9e1b-37bb98de0ac6"), new Guid("4b3d8e5c-96e1-4bc1-a308-1a9022a828c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45d0eeb0-9920-42fc-82cd-bc7168b1f4a8"), 0.0, new Guid("22441512-4460-4658-bffd-e835f54cbcc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b339115b-b092-4910-aaee-cfb8b172eeb5"), new Guid("4340cfc6-b2ab-4237-8b42-051672d4cc84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("314bc995-c591-4418-b8b4-d30b653b8309"), 0.0, new Guid("22441512-4460-4658-bffd-e835f54cbcc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7104ffa-1753-404b-b927-cb1bbd4e0da8"), new Guid("f8a17ace-43f0-4fcc-b670-b5a06bfb99e7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f34b03bc-4650-44ae-a6b0-c5ad584f2832"), 0.0, new Guid("71b404b0-8a68-42e5-9035-39db0db06999"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef17eea0-c42b-4e7f-9922-2d1e72324e9e"), new Guid("7b810efd-2974-4ca3-9a0c-cea7f612c07f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38ecdf38-091c-4628-9aa9-23aa4d6b6d28"), 0.0, new Guid("71b404b0-8a68-42e5-9035-39db0db06999"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
