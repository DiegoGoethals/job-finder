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
                    { new Guid("66f6913c-6a6a-4b42-8d6b-c3e02d89db5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c172676e-19e9-4582-b798-d3efee72e2ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f32e1f64-a7f9-488b-9952-cbb7fa738f47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), "90efa95d-33fe-43be-a432-dc8b406a50cf", "Employee", "EMPLOYEE" },
                    { new Guid("6e364dc8-9d74-4c8c-a58d-7f88ec048ec4"), "7e64f817-dcca-4060-b9f9-e253cfecab77", "Employer", "EMPLOYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { new Guid("2450bfe3-6f14-4dcd-a303-fc5269301eda"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f197ccb9-3e85-40e5-969b-522fffc5332d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@test.com", true, "User", "3", false, null, "USER3@TEST.COM", "USER3", "AQAAAAEAACcQAAAAEE5z2K2LXxViyRGng0xw5sBCfQRLCDtsl3PSkxnUgbz3/0Ru8J7TMdcL+fj0vPNGeg==", null, false, "06fe8b6c-b535-4538-8ac2-cf8506544003", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { new Guid("279f9707-f610-4409-a8f8-3bb5ac0d12ee"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "30c51f38-888e-405c-bb01-6ed39dab828c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@test.com", true, "User", "4", false, null, "USER4@TEST.COM", "USER4", "AQAAAAEAACcQAAAAEKOP8zsVJM1nOjdC2MMZg2hnSZdHKjIv9yIXoDurTP0xgBksYAYrOxOwpl/hxDgwWg==", null, false, "35fb298b-1bf6-452b-9fce-635b822fa495", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { new Guid("54693490-d13b-4f1a-9963-ba5991175bd9"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f477a825-bcfb-4a7b-9bfc-2a4636eb1da4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@test.com", true, "User", "7", false, null, "USER7@TEST.COM", "USER7", "AQAAAAEAACcQAAAAEIE1mvP+bwBM5W9CFs+IOpNBDXkfE1wwJLuZHg/7ivoilcBF2lltJ0Xm4oxaox4eag==", null, false, "4bc10cd9-9a54-47a1-9f4a-e6295f52d7d8", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { new Guid("5d9561f9-7ce0-4aa2-bc92-c7a826d1a998"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5c845ac3-7401-4e52-885f-1c61c2f1d04c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@test.com", true, "User", "6", false, null, "USER6@TEST.COM", "USER6", "AQAAAAEAACcQAAAAENIEKRD7UlkphfRm5FQ3holEc+hlomooZv/BjLS4lm8Vd6e7TwMvExN3Fddf8XSfGg==", null, false, "d61df80d-0c96-4781-9997-95df23c10c78", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { new Guid("67cf48e0-381c-49f9-a98a-c46fffe0b1f5"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b1f827b3-b047-425c-a761-d81ac3b85c44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@pri.be", true, "Seed", "Admin", false, null, "ADMIN@PRI.BE", "PRIADMIN", "AQAAAAEAACcQAAAAEK3UhUBhctZ65kyHzTgey1smiQFqDcyvezDb7YvSFX15JbkLGE+Nhyr6nqsOYXndfA==", null, false, "262baea8-dfbb-46a6-bf1a-99c95c12fcb9", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PriAdmin" },
                    { new Guid("8256d54a-adc9-4c13-b430-36e462764deb"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "19c47e0a-d05c-4ebd-854d-136a5c38af45", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@pri.be", true, "Seed", "User", false, null, "USER@PRI.BE", "PRIUSER", "AQAAAAEAACcQAAAAEEjQNaGo4vq3G+Rc0MyJnTNRuIzR8qSV015E03g6F1Bszdc/nPSgDF5LWC+xf3rZcQ==", null, false, "80baf0e4-86b1-44ec-999e-98a1d5d58fe7", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PriUser" },
                    { new Guid("a1f1a7bb-25ff-4887-a076-b90d7598d534"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "95d7ba98-6fc0-494d-99f4-66ab0b135e6a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@test.com", true, "User", "8", false, null, "USER8@TEST.COM", "USER8", "AQAAAAEAACcQAAAAENrRm3Ti66pBOVRDsOJRkfo/PxnsWek9evN2A/VHsjKQC7eEDSb+DLrCWptq9mvzrg==", null, false, "3b62a731-40ce-44cc-877c-5d958fdaf937", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { new Guid("beb3df18-bbfe-4dd7-b911-26929942fd0c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d19bd59b-ffc4-49cc-8b7f-31b024776df6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@test.com", true, "User", "2", false, null, "USER2@TEST.COM", "USER2", "AQAAAAEAACcQAAAAEKBHzrpU+6Hf9wIWsTGBNakLyFTL1/3SJOG5KOk87zKiYaSvF9DJeusCBRcJQODU+g==", null, false, "900c6b08-672d-422f-a6ac-0420533373f3", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2" },
                    { new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "560bd52f-a213-4c0e-924c-8badecb077bf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@test.com", true, "User", "1", false, null, "USER1@TEST.COM", "USER1", "AQAAAAEAACcQAAAAENFcxBBl3CMJrTVjiYZRjRSTU/QCUsG/1bqCkCFqUzjNP+rfI3e4dOm3exO5s5HDpA==", null, false, "d168167c-8145-41a0-9406-3ace685b908a", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { new Guid("d9d59f68-e255-4547-bb08-a648d0ca1c8a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6b5661d2-7f86-473c-9698-81cbc0b79446", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@test.com", true, "User", "10", false, null, "USER10@TEST.COM", "USER10", "AQAAAAEAACcQAAAAECcIZ+raCFymBIr60ClSLz3S4vgctZdEM1UZhngX86WH2XbR8YrDe7JFCuxrs+4Wkg==", null, false, "158b6c7e-e4f2-407c-8c4b-89268fe1b0dc", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { new Guid("ef6ac2a7-9744-46b1-9f16-88befa7a5aa3"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "27761332-6eb1-425f-932f-0df98a8bf293", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@test.com", true, "User", "9", false, null, "USER9@TEST.COM", "USER9", "AQAAAAEAACcQAAAAECmNRZgtWZM77fppeFauEJfMWyQHh18wJPG+5qsdxABtTLvjPc45AyZGtvUuzWTk8A==", null, false, "a4aa4f41-5f8e-4c99-bb36-b0ecf8226c3e", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { new Guid("fa8125ac-58bc-4594-93e4-0c05303d4b46"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5080582a-fa6a-4790-8f0d-24378771893c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@test.com", true, "User", "5", false, null, "USER5@TEST.COM", "USER5", "AQAAAAEAACcQAAAAEP7bJBJRWaUFL5DtzAvv1PXbv5tzSdiUB8Mlkw+EaD+AE7XBuCewcs2PpAj1nYSHJQ==", null, false, "947e2a8d-fdab-40f7-a02c-81841e5cf4fd", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("28f727e9-3fa0-4138-ae66-46b6fc61c046"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3436816b-3e96-4be0-9c2e-3403f084d51b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sewing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c8051bf-6c4d-4241-ba2f-b203020130bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Writing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e22175f-597f-4247-827f-247255ee510a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gardening", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76206eaf-98fb-4a42-9a83-403a1697f209"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Painting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ccdb8b6-37cc-41cc-9a9c-16917bbf07b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Language", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81623705-ffc2-49dd-acdf-63c9759e687e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a36f2a1f-5d9d-4517-8a8d-57c366fc599c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Driving", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf1975fb-f8b7-4a2d-82b1-a3ffea52820c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teaching", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6170a7c-2259-4695-945b-36cdd37f0a52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleaning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f35b3e15-9e41-4999-bee9-a3cb71acecdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maths", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4243339-e0ae-4388-badb-9100858540a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Photography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("2450bfe3-6f14-4dcd-a303-fc5269301eda") },
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("279f9707-f610-4409-a8f8-3bb5ac0d12ee") },
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("54693490-d13b-4f1a-9963-ba5991175bd9") },
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("5d9561f9-7ce0-4aa2-bc92-c7a826d1a998") },
                    { new Guid("6e364dc8-9d74-4c8c-a58d-7f88ec048ec4"), new Guid("67cf48e0-381c-49f9-a98a-c46fffe0b1f5") },
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("8256d54a-adc9-4c13-b430-36e462764deb") },
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("a1f1a7bb-25ff-4887-a076-b90d7598d534") },
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("beb3df18-bbfe-4dd7-b911-26929942fd0c") },
                    { new Guid("6e364dc8-9d74-4c8c-a58d-7f88ec048ec4"), new Guid("c83d7acc-a238-4f58-9375-03104a08f919") },
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("d9d59f68-e255-4547-bb08-a648d0ca1c8a") },
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("ef6ac2a7-9744-46b1-9f16-88befa7a5aa3") },
                    { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("fa8125ac-58bc-4594-93e4-0c05303d4b46") }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Created", "Description", "EmployerId", "Name", "Salary", "Updated" },
                values: new object[,]
                {
                    { new Guid("1533a99b-64d8-47aa-8f0c-10df01d93e4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job7 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job7", 70.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e139a48-d013-4f65-9f11-d9673af889d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job8 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job8", 80.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("306c7179-62cc-47d3-8297-87c088316d54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job4 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job4", 40.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3d693462-f31b-47ae-917c-c28f8173d395"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job2 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job2", 20.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b5196aa-5897-47c9-917d-4a8901c5516c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job9 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job9", 90.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("507e0060-6182-4b0f-ac52-42c9e15a0bcb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job5 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job5", 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a386cc9-4126-45ec-ac5a-6235497a04ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job10 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job10", 100.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f4b814f-7074-4b65-9456-10946dd67c81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job3 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job3", 30.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77de4b89-8a38-47d1-963e-1f7b687cb54e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job6 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job6", 60.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd6f48ee-22c8-4516-91de-adef11c11c81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job1 description", new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), "Job1", 10.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Created", "ReceiverId", "SenderId", "Updated" },
                values: new object[,]
                {
                    { new Guid("20f3ca45-c984-46cd-ac48-8ebfe7131a2a"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef6ac2a7-9744-46b1-9f16-88befa7a5aa3"), new Guid("a1f1a7bb-25ff-4887-a076-b90d7598d534"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44341c88-555e-46a6-b4fe-3b49ff67b2f3"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("beb3df18-bbfe-4dd7-b911-26929942fd0c"), new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6865ad78-f46a-4c92-840f-265f929568da"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a1f1a7bb-25ff-4887-a076-b90d7598d534"), new Guid("54693490-d13b-4f1a-9963-ba5991175bd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70958dba-41a4-44eb-a542-cc3260fe190c"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9d59f68-e255-4547-bb08-a648d0ca1c8a"), new Guid("ef6ac2a7-9744-46b1-9f16-88befa7a5aa3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a006d7c-6a87-4f9c-a333-97845e2cc088"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fa8125ac-58bc-4594-93e4-0c05303d4b46"), new Guid("279f9707-f610-4409-a8f8-3bb5ac0d12ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a25cca0-a741-4b18-904f-13dbb4c3bfab"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d9561f9-7ce0-4aa2-bc92-c7a826d1a998"), new Guid("fa8125ac-58bc-4594-93e4-0c05303d4b46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b45e7ed8-3670-4b79-af5c-f5adcbf5fef9"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8256d54a-adc9-4c13-b430-36e462764deb"), new Guid("d9d59f68-e255-4547-bb08-a648d0ca1c8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5ac4519-9a03-4b03-a4ef-ec4ae0c9c18f"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("279f9707-f610-4409-a8f8-3bb5ac0d12ee"), new Guid("2450bfe3-6f14-4dcd-a303-fc5269301eda"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e099eee5-2b63-4443-9e3c-718c910854a2"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2450bfe3-6f14-4dcd-a303-fc5269301eda"), new Guid("beb3df18-bbfe-4dd7-b911-26929942fd0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f02a305e-69f8-4f91-99cf-b4e8fcee967b"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("54693490-d13b-4f1a-9963-ba5991175bd9"), new Guid("5d9561f9-7ce0-4aa2-bc92-c7a826d1a998"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Created", "Rating", "RevieweeId", "ReviewerId", "Updated" },
                values: new object[,]
                {
                    { new Guid("26ad27df-7b92-4286-bedc-3350edd065f6"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("a1f1a7bb-25ff-4887-a076-b90d7598d534"), new Guid("54693490-d13b-4f1a-9963-ba5991175bd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6aec831a-efb8-485e-9e27-2ead714b9bb8"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("2450bfe3-6f14-4dcd-a303-fc5269301eda"), new Guid("beb3df18-bbfe-4dd7-b911-26929942fd0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77b073f8-1d7f-466d-aa16-abef81200fc9"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("d9d59f68-e255-4547-bb08-a648d0ca1c8a"), new Guid("ef6ac2a7-9744-46b1-9f16-88befa7a5aa3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a689220b-21a4-4e77-b63d-5a920db8b116"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("ef6ac2a7-9744-46b1-9f16-88befa7a5aa3"), new Guid("a1f1a7bb-25ff-4887-a076-b90d7598d534"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc555007-de72-47f1-845d-946f92a9b0d7"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("54693490-d13b-4f1a-9963-ba5991175bd9"), new Guid("5d9561f9-7ce0-4aa2-bc92-c7a826d1a998"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c724ff9d-021b-4039-82f7-0d9ec285e556"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("fa8125ac-58bc-4594-93e4-0c05303d4b46"), new Guid("279f9707-f610-4409-a8f8-3bb5ac0d12ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf4329a8-6aa0-4b3c-804b-8870aa14c178"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("279f9707-f610-4409-a8f8-3bb5ac0d12ee"), new Guid("2450bfe3-6f14-4dcd-a303-fc5269301eda"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebea3121-e224-40c1-8a4d-a42b6db94db1"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("5d9561f9-7ce0-4aa2-bc92-c7a826d1a998"), new Guid("fa8125ac-58bc-4594-93e4-0c05303d4b46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f49175cc-272f-40ed-97d3-e83ec94129f0"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("8256d54a-adc9-4c13-b430-36e462764deb"), new Guid("d9d59f68-e255-4547-bb08-a648d0ca1c8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc9c1579-74d4-4b53-96f6-290eaf18a80e"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("beb3df18-bbfe-4dd7-b911-26929942fd0c"), new Guid("c83d7acc-a238-4f58-9375-03104a08f919"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CandidateId", "Created", "JobId", "Salary", "StatusId", "Updated" },
                values: new object[,]
                {
                    { new Guid("04354825-43f9-423a-8f8f-5a9de7e451ad"), new Guid("beb3df18-bbfe-4dd7-b911-26929942fd0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bd6f48ee-22c8-4516-91de-adef11c11c81"), 0.0, new Guid("f32e1f64-a7f9-488b-9952-cbb7fa738f47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28756f65-9aea-4cfb-a04a-245fcd3dfe67"), new Guid("279f9707-f610-4409-a8f8-3bb5ac0d12ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f4b814f-7074-4b65-9456-10946dd67c81"), 0.0, new Guid("c172676e-19e9-4582-b798-d3efee72e2ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2fb8d064-6fa7-4551-ad92-f4351ed63a42"), new Guid("54693490-d13b-4f1a-9963-ba5991175bd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("77de4b89-8a38-47d1-963e-1f7b687cb54e"), 0.0, new Guid("c172676e-19e9-4582-b798-d3efee72e2ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3cca1f47-1456-4a86-bb6f-86c6548f4826"), new Guid("2450bfe3-6f14-4dcd-a303-fc5269301eda"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d693462-f31b-47ae-917c-c28f8173d395"), 0.0, new Guid("66f6913c-6a6a-4b42-8d6b-c3e02d89db5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bffc899-246b-41ea-973e-12a362507e3b"), new Guid("fa8125ac-58bc-4594-93e4-0c05303d4b46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("306c7179-62cc-47d3-8297-87c088316d54"), 0.0, new Guid("f32e1f64-a7f9-488b-9952-cbb7fa738f47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d2ec355-5090-4f88-a534-103c67401830"), new Guid("ef6ac2a7-9744-46b1-9f16-88befa7a5aa3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2e139a48-d013-4f65-9f11-d9673af889d8"), 0.0, new Guid("66f6913c-6a6a-4b42-8d6b-c3e02d89db5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c246882-320d-4ba9-bd24-637fbf12b99c"), new Guid("d9d59f68-e255-4547-bb08-a648d0ca1c8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b5196aa-5897-47c9-917d-4a8901c5516c"), 0.0, new Guid("c172676e-19e9-4582-b798-d3efee72e2ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ddf4a5f-3980-4665-af07-44cabd653dab"), new Guid("8256d54a-adc9-4c13-b430-36e462764deb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a386cc9-4126-45ec-ac5a-6235497a04ae"), 0.0, new Guid("f32e1f64-a7f9-488b-9952-cbb7fa738f47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6dd5a25-9655-4c5d-b803-f79f1e920dba"), new Guid("5d9561f9-7ce0-4aa2-bc92-c7a826d1a998"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("507e0060-6182-4b0f-ac52-42c9e15a0bcb"), 0.0, new Guid("66f6913c-6a6a-4b42-8d6b-c3e02d89db5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cfd4d6be-8b28-45db-98c8-34b13a734e07"), new Guid("a1f1a7bb-25ff-4887-a076-b90d7598d534"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1533a99b-64d8-47aa-8f0c-10df01d93e4b"), 0.0, new Guid("f32e1f64-a7f9-488b-9952-cbb7fa738f47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("04354825-43f9-423a-8f8f-5a9de7e451ad"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("28756f65-9aea-4cfb-a04a-245fcd3dfe67"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("2fb8d064-6fa7-4551-ad92-f4351ed63a42"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("3cca1f47-1456-4a86-bb6f-86c6548f4826"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("5bffc899-246b-41ea-973e-12a362507e3b"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("8d2ec355-5090-4f88-a534-103c67401830"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("9c246882-320d-4ba9-bd24-637fbf12b99c"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("9ddf4a5f-3980-4665-af07-44cabd653dab"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("b6dd5a25-9655-4c5d-b803-f79f1e920dba"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("cfd4d6be-8b28-45db-98c8-34b13a734e07"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("2450bfe3-6f14-4dcd-a303-fc5269301eda") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("279f9707-f610-4409-a8f8-3bb5ac0d12ee") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("54693490-d13b-4f1a-9963-ba5991175bd9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("5d9561f9-7ce0-4aa2-bc92-c7a826d1a998") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6e364dc8-9d74-4c8c-a58d-7f88ec048ec4"), new Guid("67cf48e0-381c-49f9-a98a-c46fffe0b1f5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("8256d54a-adc9-4c13-b430-36e462764deb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("a1f1a7bb-25ff-4887-a076-b90d7598d534") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("beb3df18-bbfe-4dd7-b911-26929942fd0c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6e364dc8-9d74-4c8c-a58d-7f88ec048ec4"), new Guid("c83d7acc-a238-4f58-9375-03104a08f919") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("d9d59f68-e255-4547-bb08-a648d0ca1c8a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("ef6ac2a7-9744-46b1-9f16-88befa7a5aa3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"), new Guid("fa8125ac-58bc-4594-93e4-0c05303d4b46") });

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("20f3ca45-c984-46cd-ac48-8ebfe7131a2a"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("44341c88-555e-46a6-b4fe-3b49ff67b2f3"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("6865ad78-f46a-4c92-840f-265f929568da"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("70958dba-41a4-44eb-a542-cc3260fe190c"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9a006d7c-6a87-4f9c-a333-97845e2cc088"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("9a25cca0-a741-4b18-904f-13dbb4c3bfab"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("b45e7ed8-3670-4b79-af5c-f5adcbf5fef9"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("d5ac4519-9a03-4b03-a4ef-ec4ae0c9c18f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("e099eee5-2b63-4443-9e3c-718c910854a2"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f02a305e-69f8-4f91-99cf-b4e8fcee967b"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("26ad27df-7b92-4286-bedc-3350edd065f6"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6aec831a-efb8-485e-9e27-2ead714b9bb8"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("77b073f8-1d7f-466d-aa16-abef81200fc9"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("a689220b-21a4-4e77-b63d-5a920db8b116"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("bc555007-de72-47f1-845d-946f92a9b0d7"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("c724ff9d-021b-4039-82f7-0d9ec285e556"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("cf4329a8-6aa0-4b3c-804b-8870aa14c178"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ebea3121-e224-40c1-8a4d-a42b6db94db1"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f49175cc-272f-40ed-97d3-e83ec94129f0"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("fc9c1579-74d4-4b53-96f6-290eaf18a80e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("28f727e9-3fa0-4138-ae66-46b6fc61c046"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3436816b-3e96-4be0-9c2e-3403f084d51b"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("3c8051bf-6c4d-4241-ba2f-b203020130bb"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6e22175f-597f-4247-827f-247255ee510a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("76206eaf-98fb-4a42-9a83-403a1697f209"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7ccdb8b6-37cc-41cc-9a9c-16917bbf07b8"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("81623705-ffc2-49dd-acdf-63c9759e687e"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a36f2a1f-5d9d-4517-8a8d-57c366fc599c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("cf1975fb-f8b7-4a2d-82b1-a3ffea52820c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e6170a7c-2259-4695-945b-36cdd37f0a52"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f35b3e15-9e41-4999-bee9-a3cb71acecdc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f4243339-e0ae-4388-badb-9100858540a6"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("66f6913c-6a6a-4b42-8d6b-c3e02d89db5d"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("c172676e-19e9-4582-b798-d3efee72e2ee"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("f32e1f64-a7f9-488b-9952-cbb7fa738f47"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6553de03-560d-432c-8d87-9d77d2e49f46"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6e364dc8-9d74-4c8c-a58d-7f88ec048ec4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2450bfe3-6f14-4dcd-a303-fc5269301eda"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("279f9707-f610-4409-a8f8-3bb5ac0d12ee"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("54693490-d13b-4f1a-9963-ba5991175bd9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d9561f9-7ce0-4aa2-bc92-c7a826d1a998"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67cf48e0-381c-49f9-a98a-c46fffe0b1f5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8256d54a-adc9-4c13-b430-36e462764deb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a1f1a7bb-25ff-4887-a076-b90d7598d534"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("beb3df18-bbfe-4dd7-b911-26929942fd0c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d9d59f68-e255-4547-bb08-a648d0ca1c8a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ef6ac2a7-9744-46b1-9f16-88befa7a5aa3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fa8125ac-58bc-4594-93e4-0c05303d4b46"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1533a99b-64d8-47aa-8f0c-10df01d93e4b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2e139a48-d013-4f65-9f11-d9673af889d8"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("306c7179-62cc-47d3-8297-87c088316d54"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("3d693462-f31b-47ae-917c-c28f8173d395"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("4b5196aa-5897-47c9-917d-4a8901c5516c"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("507e0060-6182-4b0f-ac52-42c9e15a0bcb"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6a386cc9-4126-45ec-ac5a-6235497a04ae"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("6f4b814f-7074-4b65-9456-10946dd67c81"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("77de4b89-8a38-47d1-963e-1f7b687cb54e"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("bd6f48ee-22c8-4516-91de-adef11c11c81"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c83d7acc-a238-4f58-9375-03104a08f919"));

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
    }
}
