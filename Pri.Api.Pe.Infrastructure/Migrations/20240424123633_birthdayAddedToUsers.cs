using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Api.Pe.Infrastructure.Migrations
{
    public partial class birthdayAddedToUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("200f88bd-b2d2-40d6-911a-298ed3e45f88"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("643b31d2-1b7b-4817-80ac-7c83e6bd8a7c"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("6e2f2665-f135-40fd-ad31-553b5cbc5608"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("9461ac78-2c5f-4577-bbeb-cd2551d2fd3c"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("9921d7bd-95fd-422a-94bf-6cca3ba7193f"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("ac4cb22b-6cf9-4137-8714-32873499cd0b"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("baecb136-f3f7-4e00-b8bf-80b7b19c1c73"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("d5aeb192-a9ce-4721-8f49-4778232e2fd7"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("f043dec9-0aa8-406b-bb80-5e54f064ece2"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("ff518c73-1b8d-40a9-9ec3-6b539dfe5624"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("1cadb656-4da5-4a3a-983d-b7ea4201f50f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("516bfea4-50f2-484b-9263-06543721980c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("97137476-aff3-4719-b14f-35d5718a628b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("fdf53031-87c4-44f5-bb6c-a8149cb18042"), new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("b8cf6d3d-a5d8-4a22-b97e-ebd5855a4733") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("bead2b7a-449f-4ae3-9d63-6512573e43d4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("d6a3334a-463e-4381-a503-afdfaf25f113") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("d722f79f-93e9-480e-b070-728955029e23") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("f2890345-d8d9-455a-bbd0-62c7a4c8be36") });

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0a9230c7-b555-42e8-9531-2c43741b2d9e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("0d22757f-37fa-4000-9002-9e77f5610008"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("37ec2304-81b2-4a7c-8edc-ec342dde029f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("41abd2fa-bd36-43ee-a043-340034366718"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("5132de27-cad5-4ca6-9c5f-225b6273f17f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6505b212-3dc4-4b2d-9fc7-1d27ac049c0f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c31ebeab-26d4-4891-966b-e56120acee20"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e1d27203-6d4b-49bf-ac8a-ec6fc214f145"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("eb1e1522-d985-49c9-8a81-05ddd080b835"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f0dfbd91-230b-42d6-b94b-578dcf777b16"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("32387935-5a13-4ba4-a4ed-02ee5172a406"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4daa2a5a-0d6d-4b6d-bb87-383a7684071a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6b36f138-38d8-4ecc-b989-dd04b048c7bb"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6cb99ba6-44dd-4a5a-a562-5306f43e9b28"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("934d946b-bc01-4a93-a298-2fbf7b191d0c"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("937f5dd7-7d34-4aff-8b2c-5f0b82153efe"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a007117d-c9a4-4c7b-86ea-e1d280c722a8"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("cb002623-5463-4a68-9494-1aaab4de2074"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("cb233d74-deda-4a32-85c9-a0b679f2f7ad"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d4889cea-b60d-43e6-ab14-01ef58da30c7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("00b1cd09-339c-42e9-9f59-6b721331eb65"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("2637d36d-4c9e-4e01-aca4-ab3866ae9744"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("34d14ecb-33be-4696-bed9-0465398faf3c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4403bedc-0d89-4793-8f21-380fd9680c7e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("447abb77-d290-420d-b78f-c74b61394d8f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("468848a5-679b-4fe0-8b03-74e90fc0c751"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("60f13d0a-0a51-4efc-8c73-dc7611b74e6d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9932052f-3e95-418a-8942-5070d72eecd4"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("bbfcf658-f96b-4996-a6df-4bb43f851ee1"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c9bfda14-666a-41e8-a734-8f27fbd582fb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e0204ca7-47e2-4d8f-ac46-869e8fd8b70d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e42cc64d-d081-494f-9f77-20be7de0922e"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("5a3fe95e-b371-44d1-86e2-b6bf5fb97886"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("e2a3809f-b985-48bc-8769-bb435a3204f7"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("ed1bf698-df1c-429e-8759-eaef61241f2e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("408fbf17-984e-43c5-8794-5be95044ea17"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fdf53031-87c4-44f5-bb6c-a8149cb18042"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1cadb656-4da5-4a3a-983d-b7ea4201f50f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("516bfea4-50f2-484b-9263-06543721980c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97137476-aff3-4719-b14f-35d5718a628b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8cf6d3d-a5d8-4a22-b97e-ebd5855a4733"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bead2b7a-449f-4ae3-9d63-6512573e43d4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d6a3334a-463e-4381-a503-afdfaf25f113"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d722f79f-93e9-480e-b070-728955029e23"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f2890345-d8d9-455a-bbd0-62c7a4c8be36"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("017ad50d-efc1-47ef-a799-0e74c4c1e330"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1a41b746-a5e0-4e52-8cee-ee8c02271f5c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("412e2398-0488-45aa-88ee-4ae03981f54e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5fe23f48-b440-4fd0-a132-3db8437feda6"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("69f40e2f-c64f-42e9-ac3d-841fb92b0ed2"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a94f3130-9fa8-464f-b3fc-ea1541a4327c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c4e34fcc-1514-4dbc-9124-aa569dc51a28"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d495591e-b0bc-4010-9ee0-ce537589e82d"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("d5fa2f0b-0eda-406b-9c3d-c6813ee1dded"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("fdb1c55e-e631-4445-a59a-ed3b466e0caa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "ApplicationStatus",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("5a3fe95e-b371-44d1-86e2-b6bf5fb97886"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2a3809f-b985-48bc-8769-bb435a3204f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed1bf698-df1c-429e-8759-eaef61241f2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), "f3a5c0fa-05dd-4e71-bc21-227f2c6a8d30", "Employee", "EMPLOYEE" },
                    { new Guid("fdf53031-87c4-44f5-bb6c-a8149cb18042"), "f9092f0b-b753-4acf-8083-4732e1425a1c", "Employer", "EMPLOYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { new Guid("1cadb656-4da5-4a3a-983d-b7ea4201f50f"), 0, "ef30a85c-0b73-4f5c-9fb4-5e9d5418c13e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@test.com", true, "User", "8", false, null, "USER8@TEST.COM", "USER8", "AQAAAAEAACcQAAAAEHKCBKdL+D6tWP7vOZk/vCsCAapcMRXR1hq4KnwGERFVDmvl2V1cKmFa9KrlV3AUGA==", null, false, "234b6822-e91f-4c36-a548-82998e4d3869", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0"), 0, "cacae661-0ec2-41a0-9742-fa823705ae6a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@test.com", true, "User", "2", false, null, "USER2@TEST.COM", "USER2", "AQAAAAEAACcQAAAAEPb74XlWHeifWN1McfZ9kHlZVFO62mxdIyNKGJD2NPKS+zKtzzVgTVea8NZdPTm1iA==", null, false, "f13cb576-8b38-47a2-a4d9-03d0b43b7b09", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { new Guid("516bfea4-50f2-484b-9263-06543721980c"), 0, "8da9e0d2-92d0-4da6-8927-0f29f8c4f18b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@test.com", true, "User", "3", false, null, "USER3@TEST.COM", "USER3", "AQAAAAEAACcQAAAAEEpgHSOgxD85m3d0GFVUGLK+dUyrpPayj0+cx7PHrfhxDvc/HBbLZLsI5AEHVAPvqQ==", null, false, "8b2a773f-a326-43c8-89ef-5d185aab8753", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { new Guid("97137476-aff3-4719-b14f-35d5718a628b"), 0, "4dbec063-18c5-418b-8133-c4e89901e9be", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@test.com", true, "User", "6", false, null, "USER6@TEST.COM", "USER6", "AQAAAAEAACcQAAAAEAPo7H5Q0KsClVW8Ypa2oaFoOh1PEZLJdDeey0XBKx/AeOFqNqaYzz+CTH/WSfyGrA==", null, false, "6e5ca000-3de1-4d54-92ff-19a08b727ff4", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), 0, "bb168ba2-15a7-4c09-9c9c-3022d3d06e75", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@test.com", true, "User", "1", false, null, "USER1@TEST.COM", "USER1", "AQAAAAEAACcQAAAAECygkabIwdD2CACrxnEEyWoN0JSW7J4dEbsU7jZTRE9KoW7oNi3wLHFvzxS4FHAE4Q==", null, false, "9b1be47a-9480-466d-8513-b529dd2c6332", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { new Guid("b8cf6d3d-a5d8-4a22-b97e-ebd5855a4733"), 0, "704dad85-01a7-4484-913a-f09b380f6778", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@test.com", true, "User", "7", false, null, "USER7@TEST.COM", "USER7", "AQAAAAEAACcQAAAAEOF85YU6Ec4yxH27c4F5YS693KMNZ9ZylzdljJiHSBGCa6Nq71a5ZPuCeSCLZKi3ug==", null, false, "eec5af2b-eb32-4991-ab41-07c86f2dc38b", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { new Guid("bead2b7a-449f-4ae3-9d63-6512573e43d4"), 0, "c0e576d3-72b7-4e79-aa2a-6981017d1ed6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@test.com", true, "User", "4", false, null, "USER4@TEST.COM", "USER4", "AQAAAAEAACcQAAAAED3dpYMFwccu2g+oFGEbrWCU4YzPl1B5N5W7+X42yLo1pY7y8SdCxjXxBoIRJxlClw==", null, false, "afd6ceca-6892-44fe-b7b7-4fd14a4fb8fe", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { new Guid("d6a3334a-463e-4381-a503-afdfaf25f113"), 0, "f09d7003-9af5-409f-96ea-6a8d1e688073", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@test.com", true, "User", "5", false, null, "USER5@TEST.COM", "USER5", "AQAAAAEAACcQAAAAELI7w1c09McdMvahaXZogJWJXZEhgT2TehZ5we2FEhFTQZpbZ7d18T+JHB87UxxqrA==", null, false, "3e5b949b-29bb-41de-84aa-a8b2b0126052", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { new Guid("d722f79f-93e9-480e-b070-728955029e23"), 0, "653048e7-02e9-416f-82aa-8fdb3e3b36f9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@test.com", true, "User", "9", false, null, "USER9@TEST.COM", "USER9", "AQAAAAEAACcQAAAAEJBaG6FeMCZJE2BRiv3pXUnZkgX2Mz7Nf4BOQDmtPQO2FY976cZcC2gDYNtllcmvpw==", null, false, "53130005-7144-415e-8a43-da474dd64c26", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { new Guid("f2890345-d8d9-455a-bbd0-62c7a4c8be36"), 0, "d7acefd1-5450-4904-b533-5407c17a68ad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@test.com", true, "User", "10", false, null, "USER10@TEST.COM", "USER10", "AQAAAAEAACcQAAAAED7V1TRnqVfQxsv0tboOvJ2+hTsRmO1BoFcsJ/8zGTmiapp1wlhT86Yloky1z6PBKQ==", null, false, "bc33f8ed-c3d0-4b7c-8f30-1e0880a7ce29", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("00b1cd09-339c-42e9-9f59-6b721331eb65"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gardening", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2637d36d-4c9e-4e01-aca4-ab3866ae9744"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34d14ecb-33be-4696-bed9-0465398faf3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sewing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4403bedc-0d89-4793-8f21-380fd9680c7e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Painting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("447abb77-d290-420d-b78f-c74b61394d8f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("468848a5-679b-4fe0-8b03-74e90fc0c751"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Driving", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("60f13d0a-0a51-4efc-8c73-dc7611b74e6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Language", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9932052f-3e95-418a-8942-5070d72eecd4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maths", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbfcf658-f96b-4996-a6df-4bb43f851ee1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Photography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9bfda14-666a-41e8-a734-8f27fbd582fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teaching", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e0204ca7-47e2-4d8f-ac46-869e8fd8b70d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Writing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e42cc64d-d081-494f-9f77-20be7de0922e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleaning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("1cadb656-4da5-4a3a-983d-b7ea4201f50f") },
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0") },
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("516bfea4-50f2-484b-9263-06543721980c") },
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("97137476-aff3-4719-b14f-35d5718a628b") },
                    { new Guid("fdf53031-87c4-44f5-bb6c-a8149cb18042"), new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a") },
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("b8cf6d3d-a5d8-4a22-b97e-ebd5855a4733") },
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("bead2b7a-449f-4ae3-9d63-6512573e43d4") },
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("d6a3334a-463e-4381-a503-afdfaf25f113") },
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("d722f79f-93e9-480e-b070-728955029e23") },
                    { new Guid("408fbf17-984e-43c5-8794-5be95044ea17"), new Guid("f2890345-d8d9-455a-bbd0-62c7a4c8be36") }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Created", "Description", "EmployerId", "Name", "Salary", "Updated" },
                values: new object[,]
                {
                    { new Guid("017ad50d-efc1-47ef-a799-0e74c4c1e330"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job2 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job2", 20.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a41b746-a5e0-4e52-8cee-ee8c02271f5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job10 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job10", 100.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("412e2398-0488-45aa-88ee-4ae03981f54e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job7 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job7", 70.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5fe23f48-b440-4fd0-a132-3db8437feda6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job8 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job8", 80.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69f40e2f-c64f-42e9-ac3d-841fb92b0ed2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job5 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job5", 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a94f3130-9fa8-464f-b3fc-ea1541a4327c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job1 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job1", 10.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4e34fcc-1514-4dbc-9124-aa569dc51a28"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job9 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job9", 90.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d495591e-b0bc-4010-9ee0-ce537589e82d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job3 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job3", 30.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5fa2f0b-0eda-406b-9c3d-c6813ee1dded"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job4 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job4", 40.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fdb1c55e-e631-4445-a59a-ed3b466e0caa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job6 description", new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), "Job6", 60.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Created", "ReceiverId", "SenderId", "Updated" },
                values: new object[,]
                {
                    { new Guid("0a9230c7-b555-42e8-9531-2c43741b2d9e"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d6a3334a-463e-4381-a503-afdfaf25f113"), new Guid("bead2b7a-449f-4ae3-9d63-6512573e43d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d22757f-37fa-4000-9002-9e77f5610008"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0"), new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37ec2304-81b2-4a7c-8edc-ec342dde029f"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d722f79f-93e9-480e-b070-728955029e23"), new Guid("1cadb656-4da5-4a3a-983d-b7ea4201f50f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41abd2fa-bd36-43ee-a043-340034366718"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1cadb656-4da5-4a3a-983d-b7ea4201f50f"), new Guid("b8cf6d3d-a5d8-4a22-b97e-ebd5855a4733"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5132de27-cad5-4ca6-9c5f-225b6273f17f"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8cf6d3d-a5d8-4a22-b97e-ebd5855a4733"), new Guid("97137476-aff3-4719-b14f-35d5718a628b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6505b212-3dc4-4b2d-9fc7-1d27ac049c0f"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f2890345-d8d9-455a-bbd0-62c7a4c8be36"), new Guid("d722f79f-93e9-480e-b070-728955029e23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c31ebeab-26d4-4891-966b-e56120acee20"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bead2b7a-449f-4ae3-9d63-6512573e43d4"), new Guid("516bfea4-50f2-484b-9263-06543721980c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1d27203-6d4b-49bf-ac8a-ec6fc214f145"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), new Guid("f2890345-d8d9-455a-bbd0-62c7a4c8be36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb1e1522-d985-49c9-8a81-05ddd080b835"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("516bfea4-50f2-484b-9263-06543721980c"), new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0dfbd91-230b-42d6-b94b-578dcf777b16"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("97137476-aff3-4719-b14f-35d5718a628b"), new Guid("d6a3334a-463e-4381-a503-afdfaf25f113"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Created", "Rating", "RevieweeId", "ReviewerId", "Updated" },
                values: new object[,]
                {
                    { new Guid("32387935-5a13-4ba4-a4ed-02ee5172a406"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("d6a3334a-463e-4381-a503-afdfaf25f113"), new Guid("bead2b7a-449f-4ae3-9d63-6512573e43d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4daa2a5a-0d6d-4b6d-bb87-383a7684071a"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0"), new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b36f138-38d8-4ecc-b989-dd04b048c7bb"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("1cadb656-4da5-4a3a-983d-b7ea4201f50f"), new Guid("b8cf6d3d-a5d8-4a22-b97e-ebd5855a4733"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6cb99ba6-44dd-4a5a-a562-5306f43e9b28"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("f2890345-d8d9-455a-bbd0-62c7a4c8be36"), new Guid("d722f79f-93e9-480e-b070-728955029e23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("934d946b-bc01-4a93-a298-2fbf7b191d0c"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("97137476-aff3-4719-b14f-35d5718a628b"), new Guid("d6a3334a-463e-4381-a503-afdfaf25f113"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("937f5dd7-7d34-4aff-8b2c-5f0b82153efe"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("b8cf6d3d-a5d8-4a22-b97e-ebd5855a4733"), new Guid("97137476-aff3-4719-b14f-35d5718a628b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a007117d-c9a4-4c7b-86ea-e1d280c722a8"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("bead2b7a-449f-4ae3-9d63-6512573e43d4"), new Guid("516bfea4-50f2-484b-9263-06543721980c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb002623-5463-4a68-9494-1aaab4de2074"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("d722f79f-93e9-480e-b070-728955029e23"), new Guid("1cadb656-4da5-4a3a-983d-b7ea4201f50f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb233d74-deda-4a32-85c9-a0b679f2f7ad"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b115be95-4c8e-41a3-ba1e-899e73b2a87a"), new Guid("f2890345-d8d9-455a-bbd0-62c7a4c8be36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4889cea-b60d-43e6-ab14-01ef58da30c7"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("516bfea4-50f2-484b-9263-06543721980c"), new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CandidateId", "Created", "JobId", "Salary", "StatusId", "Updated" },
                values: new object[,]
                {
                    { new Guid("200f88bd-b2d2-40d6-911a-298ed3e45f88"), new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1a41b746-a5e0-4e52-8cee-ee8c02271f5c"), 0.0, new Guid("ed1bf698-df1c-429e-8759-eaef61241f2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("643b31d2-1b7b-4817-80ac-7c83e6bd8a7c"), new Guid("97137476-aff3-4719-b14f-35d5718a628b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69f40e2f-c64f-42e9-ac3d-841fb92b0ed2"), 0.0, new Guid("e2a3809f-b985-48bc-8769-bb435a3204f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e2f2665-f135-40fd-ad31-553b5cbc5608"), new Guid("516bfea4-50f2-484b-9263-06543721980c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("017ad50d-efc1-47ef-a799-0e74c4c1e330"), 0.0, new Guid("e2a3809f-b985-48bc-8769-bb435a3204f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9461ac78-2c5f-4577-bbeb-cd2551d2fd3c"), new Guid("d6a3334a-463e-4381-a503-afdfaf25f113"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5fa2f0b-0eda-406b-9c3d-c6813ee1dded"), 0.0, new Guid("ed1bf698-df1c-429e-8759-eaef61241f2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9921d7bd-95fd-422a-94bf-6cca3ba7193f"), new Guid("1cadb656-4da5-4a3a-983d-b7ea4201f50f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("412e2398-0488-45aa-88ee-4ae03981f54e"), 0.0, new Guid("ed1bf698-df1c-429e-8759-eaef61241f2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac4cb22b-6cf9-4137-8714-32873499cd0b"), new Guid("f2890345-d8d9-455a-bbd0-62c7a4c8be36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c4e34fcc-1514-4dbc-9124-aa569dc51a28"), 0.0, new Guid("5a3fe95e-b371-44d1-86e2-b6bf5fb97886"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("baecb136-f3f7-4e00-b8bf-80b7b19c1c73"), new Guid("bead2b7a-449f-4ae3-9d63-6512573e43d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d495591e-b0bc-4010-9ee0-ce537589e82d"), 0.0, new Guid("5a3fe95e-b371-44d1-86e2-b6bf5fb97886"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5aeb192-a9ce-4721-8f49-4778232e2fd7"), new Guid("d722f79f-93e9-480e-b070-728955029e23"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5fe23f48-b440-4fd0-a132-3db8437feda6"), 0.0, new Guid("e2a3809f-b985-48bc-8769-bb435a3204f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f043dec9-0aa8-406b-bb80-5e54f064ece2"), new Guid("3bc600f9-9d3b-41f2-8fdc-7ddb0e992bb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a94f3130-9fa8-464f-b3fc-ea1541a4327c"), 0.0, new Guid("ed1bf698-df1c-429e-8759-eaef61241f2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff518c73-1b8d-40a9-9ec3-6b539dfe5624"), new Guid("b8cf6d3d-a5d8-4a22-b97e-ebd5855a4733"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fdb1c55e-e631-4445-a59a-ed3b466e0caa"), 0.0, new Guid("5a3fe95e-b371-44d1-86e2-b6bf5fb97886"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
