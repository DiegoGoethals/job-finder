using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Api.Pe.Infrastructure.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApplicationStatus",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("1b0211e1-cbcc-4978-9760-726269a94c31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d84ecb0-c0a5-4016-a247-516993ef7437"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af772102-1331-4ea1-a516-62fb0eaa6e67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), "9b2b0b25-261e-40bc-9023-03cc9acd5d15", "Employee", "EMPLOYEE" },
                    { new Guid("ac1fc180-682b-4e47-a9fa-7eaed458dd50"), "d3c4c9e1-95e2-4a28-853c-9020064a376a", "Employer", "EMPLOYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Created", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Updated", "UserName" },
                values: new object[,]
                {
                    { new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), 0, "36eac91c-81bd-4bbc-9f98-85494bcfd33e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@test.com", true, "User", "1", false, null, "USER1@TEST.COM", "USER1", "AQAAAAEAACcQAAAAEJHx3qgCO0ZM3dGdN1nGgdliRGUYUCJeyGd916gtqyZ012czN9oEi+PDNmt5RUZUoQ==", null, false, "41115456-50ad-48af-b4ef-342a67cc68da", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1" },
                    { new Guid("1585f7aa-fd5f-42a5-a6c6-b340a0c052a5"), 0, "1d783ed1-ffbd-48fe-b093-b4fbb3d782b9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@test.com", true, "User", "6", false, null, "USER6@TEST.COM", "USER6", "AQAAAAEAACcQAAAAEPMlABuHkWJXPiwtoVafXyn23HfEZCSiz8NY+wmmstwEzmF2onj1ezCwE7UnTaHLww==", null, false, "6783d745-19fa-44bd-9eb0-4446e6443bf2", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6" },
                    { new Guid("3913ba19-ed63-4480-9c6b-4dac2cee6fb0"), 0, "a7db1cc0-5330-4e38-a5a8-fe3935f208a2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@test.com", true, "User", "4", false, null, "USER4@TEST.COM", "USER4", "AQAAAAEAACcQAAAAED12Gk1hmyr7rmvnSI4nWq+9l1spdnxl70ZAYN4dzzAgsyVoc1HoG0rHQKks/mALlw==", null, false, "705cf664-a292-4238-835b-ab2d8d27b89f", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4" },
                    { new Guid("58be952f-8294-4428-8d39-c123a686e3ce"), 0, "b8281462-f6b7-4e89-9786-258a18c4f24f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@test.com", true, "User", "7", false, null, "USER7@TEST.COM", "USER7", "AQAAAAEAACcQAAAAEPXmtt5pJ5i4KLL+5ctiTtTpjLh/aSDTNEe3Kz51n4ny3ZeZgoQjwJETVajlDbk0+Q==", null, false, "444f1916-f3dd-400c-bd65-efe47f167aa5", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7" },
                    { new Guid("854b2992-8b8e-4b58-aefa-dab3eb7d9c66"), 0, "ac92d149-df33-4547-8ca9-b7da6e3af788", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@test.com", true, "User", "9", false, null, "USER9@TEST.COM", "USER9", "AQAAAAEAACcQAAAAEHM00UYkflefiyLVII0fTLUlvmg6gKz0BThv15NtbLNI/T4HVkLaT48GQ+YcNuWSLA==", null, false, "5863928b-c516-4c16-aabf-6940077dd430", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9" },
                    { new Guid("9a2e9cf2-7de5-48f0-ba28-9150e335fa60"), 0, "eea83f73-9071-44ff-bca7-9a6290499f44", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@test.com", true, "User", "5", false, null, "USER5@TEST.COM", "USER5", "AQAAAAEAACcQAAAAEFh/KVpAagkKfD3APcKJJ3zIMA3DzOSPOq6RDldHopDAG8jFz/UZN7jEQsUL9udjJQ==", null, false, "94a835ed-2d03-4779-8be6-af63e6ba3819", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5" },
                    { new Guid("a9140311-167f-438d-adb6-6349ca165e01"), 0, "8a9fca63-8304-4b21-8560-23697d050742", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@test.com", true, "User", "10", false, null, "USER10@TEST.COM", "USER10", "AQAAAAEAACcQAAAAELhqZ3gWUI67W8qull6bGPUrewjAyNKqizAM92zuuru94m+EzgWTjJEyZOs7tqiWSA==", null, false, "64b5981a-ca70-4581-8b8e-f42412273413", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10" },
                    { new Guid("c3478c11-1d4f-427c-80bb-c7de61ddac6c"), 0, "08cd6781-959c-43a7-b493-db35931c3b6d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@test.com", true, "User", "3", false, null, "USER3@TEST.COM", "USER3", "AQAAAAEAACcQAAAAEHcbCyt+HXxjmmCBE8U+ko8MZNgJhKtdffTspyvM48QeHZffvQA4IjjkT0XgLE2SKw==", null, false, "9b1c5cb5-086c-46ce-9f78-1b871c0be11c", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3" },
                    { new Guid("cd0fba66-bf5c-4624-84f2-f7af13a7ea9a"), 0, "08b44ecf-ef29-43d7-8b5f-2ee41254db4c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@test.com", true, "User", "8", false, null, "USER8@TEST.COM", "USER8", "AQAAAAEAACcQAAAAEFa0yZuj2izd5l5STQwfky7rgrfZIs6nI4R17RShRo4geP+g+LbS6vx2MKIJPj6amw==", null, false, "b43abceb-e5c6-48da-bb93-5e695ad0049a", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8" },
                    { new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1"), 0, "248d8b82-0933-41e5-948a-73df51089794", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@test.com", true, "User", "2", false, null, "USER2@TEST.COM", "USER2", "AQAAAAEAACcQAAAAEPttxXkpdbDZF81Gu5sAwLBdoFYE4QaFq62XzoS+o7pPG1hmHp7zUpuiII9mJPkGBw==", null, false, "86600bfd-43b5-4e3f-a18c-d2f4626c6ee6", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Created", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("03c62cb0-cc8d-4647-8792-726d5e533c6a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Painting", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e660e60-a3bb-43bd-a5a0-e778c0f46323"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teaching", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6db4cea2-d68e-42f2-81e5-3904f796bf5d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Writing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6df87cc8-45df-4dd0-abad-5508a4aee37c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gardening", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("755bfb5f-38ff-47cb-8656-e47ecec598f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maths", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("981a674c-92ea-4164-a260-95423b8d2046"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Photography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a488656c-e6b9-4621-a74c-3191d486d49d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Driving", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c64a777b-49d4-4b8e-b352-a6c513382916"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programming", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c99c4370-fc97-4916-b64c-89d3cdcbf4de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Language", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce74fe74-e002-4e01-99be-96426661e8ee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cooking", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d372a2e7-3071-4547-a4bc-8fa8de471199"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cleaning", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("efdd5ae5-a08c-401d-9586-6ed75c960117"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sewing", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ac1fc180-682b-4e47-a9fa-7eaed458dd50"), new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d") },
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("1585f7aa-fd5f-42a5-a6c6-b340a0c052a5") },
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("3913ba19-ed63-4480-9c6b-4dac2cee6fb0") },
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("58be952f-8294-4428-8d39-c123a686e3ce") },
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("854b2992-8b8e-4b58-aefa-dab3eb7d9c66") },
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("9a2e9cf2-7de5-48f0-ba28-9150e335fa60") },
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("a9140311-167f-438d-adb6-6349ca165e01") },
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("c3478c11-1d4f-427c-80bb-c7de61ddac6c") },
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("cd0fba66-bf5c-4624-84f2-f7af13a7ea9a") },
                    { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1") }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Created", "Description", "EmployerId", "Name", "Salary", "Updated" },
                values: new object[,]
                {
                    { new Guid("0b3b1e7c-90e8-4c8f-bcd7-d24d4b5b0c0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job7 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job7", 70.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("104bf1a3-c708-4c0a-9d97-102956d4e9a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job4 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job4", 40.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e09a542-14d7-482b-baee-578b39ae2feb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job10 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job10", 100.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2320310e-49cb-4774-9e7d-0092cb186ff7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job2 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job2", 20.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35e01063-1ce1-4b0b-aa6b-1e096128cf3f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job1 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job1", 10.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("51b0e977-3982-4e2e-b86e-8bda2d2f3b27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job5 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job5", 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bd157d1-3a3e-43d6-a4b4-e65729852f90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job9 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job9", 90.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79868ef1-4886-41ac-96f0-814789e574db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job8 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job8", 80.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0786985-34dd-4cf3-ad93-4532fdb9a43b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job3 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job3", 30.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7b3674b-1132-44bc-ab24-51bc7e2473c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Job6 description", new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), "Job6", 60.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Created", "ReceiverId", "SenderId", "Updated" },
                values: new object[,]
                {
                    { new Guid("3bf02b86-46c5-4f72-879a-c3d1e9dda8c5"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a2e9cf2-7de5-48f0-ba28-9150e335fa60"), new Guid("3913ba19-ed63-4480-9c6b-4dac2cee6fb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("415c84dc-f9a8-43a2-a582-0b2c2da0507f"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3478c11-1d4f-427c-80bb-c7de61ddac6c"), new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49179607-bc52-4628-88f2-952976ec74ca"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a9140311-167f-438d-adb6-6349ca165e01"), new Guid("854b2992-8b8e-4b58-aefa-dab3eb7d9c66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75e2b60e-e1c6-466c-bc20-3cca908e6dd0"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd0fba66-bf5c-4624-84f2-f7af13a7ea9a"), new Guid("58be952f-8294-4428-8d39-c123a686e3ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bef0f64-ab98-4adc-8f9c-1b28ef6a2763"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1"), new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88c7fc6f-6ff0-44a0-81a9-16168bc39e5e"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("58be952f-8294-4428-8d39-c123a686e3ce"), new Guid("1585f7aa-fd5f-42a5-a6c6-b340a0c052a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c510b276-ce7d-4ddb-8040-99c571c1cdaf"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3913ba19-ed63-4480-9c6b-4dac2cee6fb0"), new Guid("c3478c11-1d4f-427c-80bb-c7de61ddac6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7118ef0-42c9-4b05-acba-0fc5fa1cdebf"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("854b2992-8b8e-4b58-aefa-dab3eb7d9c66"), new Guid("cd0fba66-bf5c-4624-84f2-f7af13a7ea9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebd4316a-84a6-401c-9afa-294fc72e0d98"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), new Guid("a9140311-167f-438d-adb6-6349ca165e01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7749618-ed85-4b1c-ae54-75bdf3baac44"), "Seeded message", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1585f7aa-fd5f-42a5-a6c6-b340a0c052a5"), new Guid("9a2e9cf2-7de5-48f0-ba28-9150e335fa60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "Created", "Rating", "RevieweeId", "ReviewerId", "Updated" },
                values: new object[,]
                {
                    { new Guid("0a5c651f-676b-4e79-8836-bea000b31eb8"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), new Guid("a9140311-167f-438d-adb6-6349ca165e01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f7878bc-b881-472a-9963-f30d502d8841"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("cd0fba66-bf5c-4624-84f2-f7af13a7ea9a"), new Guid("58be952f-8294-4428-8d39-c123a686e3ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f2191ad-3e94-4404-a714-6f878ee67ba2"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1"), new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7db4a96f-4249-4e26-89df-fad534f0bd98"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("9a2e9cf2-7de5-48f0-ba28-9150e335fa60"), new Guid("3913ba19-ed63-4480-9c6b-4dac2cee6fb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88dfe6e5-18c2-44bd-ae87-1ca49bad276a"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new Guid("a9140311-167f-438d-adb6-6349ca165e01"), new Guid("854b2992-8b8e-4b58-aefa-dab3eb7d9c66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9357a592-87be-416b-a5b4-6eb2365d5d80"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new Guid("c3478c11-1d4f-427c-80bb-c7de61ddac6c"), new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d98f53d9-6468-4454-9494-b3b42051155b"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new Guid("58be952f-8294-4428-8d39-c123a686e3ce"), new Guid("1585f7aa-fd5f-42a5-a6c6-b340a0c052a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e0923a26-7a9b-4c5a-b654-cb199e3d902c"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("3913ba19-ed63-4480-9c6b-4dac2cee6fb0"), new Guid("c3478c11-1d4f-427c-80bb-c7de61ddac6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea8537f9-247c-4767-8654-10beb351588e"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new Guid("854b2992-8b8e-4b58-aefa-dab3eb7d9c66"), new Guid("cd0fba66-bf5c-4624-84f2-f7af13a7ea9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbc9dafb-8dc2-489e-9707-60193de0c4cd"), "Seeded review", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("1585f7aa-fd5f-42a5-a6c6-b340a0c052a5"), new Guid("9a2e9cf2-7de5-48f0-ba28-9150e335fa60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "Id", "CandidateId", "Created", "JobId", "Salary", "StatusId", "Updated" },
                values: new object[,]
                {
                    { new Guid("0ef0b567-b0dd-487c-a8db-8fb6f471c063"), new Guid("c3478c11-1d4f-427c-80bb-c7de61ddac6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2320310e-49cb-4774-9e7d-0092cb186ff7"), 0.0, new Guid("1b0211e1-cbcc-4978-9760-726269a94c31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1db21d58-a38b-4822-b5de-88291af8de74"), new Guid("58be952f-8294-4428-8d39-c123a686e3ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c7b3674b-1132-44bc-ab24-51bc7e2473c8"), 0.0, new Guid("8d84ecb0-c0a5-4016-a247-516993ef7437"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a600fc3-18e0-4246-8a9d-fa506df6814a"), new Guid("1585f7aa-fd5f-42a5-a6c6-b340a0c052a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("51b0e977-3982-4e2e-b86e-8bda2d2f3b27"), 0.0, new Guid("1b0211e1-cbcc-4978-9760-726269a94c31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6fa20086-f4ed-4c8f-8c17-be46087dde7c"), new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1e09a542-14d7-482b-baee-578b39ae2feb"), 0.0, new Guid("af772102-1331-4ea1-a516-62fb0eaa6e67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b024f123-c20c-49ca-a646-e018eecd9fc5"), new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("35e01063-1ce1-4b0b-aa6b-1e096128cf3f"), 0.0, new Guid("af772102-1331-4ea1-a516-62fb0eaa6e67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e007f2e1-8ee3-4d5e-87b4-cad0d6d586c4"), new Guid("3913ba19-ed63-4480-9c6b-4dac2cee6fb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a0786985-34dd-4cf3-ad93-4532fdb9a43b"), 0.0, new Guid("8d84ecb0-c0a5-4016-a247-516993ef7437"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e58af8b4-e4c2-4ea9-b071-24b90df9fd13"), new Guid("854b2992-8b8e-4b58-aefa-dab3eb7d9c66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79868ef1-4886-41ac-96f0-814789e574db"), 0.0, new Guid("1b0211e1-cbcc-4978-9760-726269a94c31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec68daaf-24c7-4589-bd2d-3e8572c5bf7e"), new Guid("9a2e9cf2-7de5-48f0-ba28-9150e335fa60"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("104bf1a3-c708-4c0a-9d97-102956d4e9a9"), 0.0, new Guid("af772102-1331-4ea1-a516-62fb0eaa6e67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f322608f-2166-4aed-9238-36b610fa0824"), new Guid("a9140311-167f-438d-adb6-6349ca165e01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5bd157d1-3a3e-43d6-a4b4-e65729852f90"), 0.0, new Guid("8d84ecb0-c0a5-4016-a247-516993ef7437"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3e32823-6123-4e98-8a76-48e8c5078090"), new Guid("cd0fba66-bf5c-4624-84f2-f7af13a7ea9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0b3b1e7c-90e8-4c8f-bcd7-d24d4b5b0c0b"), 0.0, new Guid("af772102-1331-4ea1-a516-62fb0eaa6e67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("0ef0b567-b0dd-487c-a8db-8fb6f471c063"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("1db21d58-a38b-4822-b5de-88291af8de74"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("3a600fc3-18e0-4246-8a9d-fa506df6814a"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("6fa20086-f4ed-4c8f-8c17-be46087dde7c"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("b024f123-c20c-49ca-a646-e018eecd9fc5"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("e007f2e1-8ee3-4d5e-87b4-cad0d6d586c4"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("e58af8b4-e4c2-4ea9-b071-24b90df9fd13"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("ec68daaf-24c7-4589-bd2d-3e8572c5bf7e"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("f322608f-2166-4aed-9238-36b610fa0824"));

            migrationBuilder.DeleteData(
                table: "Applications",
                keyColumn: "Id",
                keyValue: new Guid("f3e32823-6123-4e98-8a76-48e8c5078090"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ac1fc180-682b-4e47-a9fa-7eaed458dd50"), new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("1585f7aa-fd5f-42a5-a6c6-b340a0c052a5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("3913ba19-ed63-4480-9c6b-4dac2cee6fb0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("58be952f-8294-4428-8d39-c123a686e3ce") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("854b2992-8b8e-4b58-aefa-dab3eb7d9c66") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("9a2e9cf2-7de5-48f0-ba28-9150e335fa60") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("a9140311-167f-438d-adb6-6349ca165e01") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("c3478c11-1d4f-427c-80bb-c7de61ddac6c") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("cd0fba66-bf5c-4624-84f2-f7af13a7ea9a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"), new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1") });

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("3bf02b86-46c5-4f72-879a-c3d1e9dda8c5"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("415c84dc-f9a8-43a2-a582-0b2c2da0507f"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("49179607-bc52-4628-88f2-952976ec74ca"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("75e2b60e-e1c6-466c-bc20-3cca908e6dd0"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("7bef0f64-ab98-4adc-8f9c-1b28ef6a2763"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("88c7fc6f-6ff0-44a0-81a9-16168bc39e5e"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c510b276-ce7d-4ddb-8040-99c571c1cdaf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("c7118ef0-42c9-4b05-acba-0fc5fa1cdebf"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("ebd4316a-84a6-401c-9afa-294fc72e0d98"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("f7749618-ed85-4b1c-ae54-75bdf3baac44"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("0a5c651f-676b-4e79-8836-bea000b31eb8"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("5f7878bc-b881-472a-9963-f30d502d8841"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("6f2191ad-3e94-4404-a714-6f878ee67ba2"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7db4a96f-4249-4e26-89df-fad534f0bd98"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("88dfe6e5-18c2-44bd-ae87-1ca49bad276a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("9357a592-87be-416b-a5b4-6eb2365d5d80"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d98f53d9-6468-4454-9494-b3b42051155b"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e0923a26-7a9b-4c5a-b654-cb199e3d902c"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("ea8537f9-247c-4767-8654-10beb351588e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("fbc9dafb-8dc2-489e-9707-60193de0c4cd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("03c62cb0-cc8d-4647-8792-726d5e533c6a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0e660e60-a3bb-43bd-a5a0-e778c0f46323"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6db4cea2-d68e-42f2-81e5-3904f796bf5d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6df87cc8-45df-4dd0-abad-5508a4aee37c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("755bfb5f-38ff-47cb-8656-e47ecec598f9"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("981a674c-92ea-4164-a260-95423b8d2046"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a488656c-e6b9-4621-a74c-3191d486d49d"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c64a777b-49d4-4b8e-b352-a6c513382916"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c99c4370-fc97-4916-b64c-89d3cdcbf4de"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("ce74fe74-e002-4e01-99be-96426661e8ee"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d372a2e7-3071-4547-a4bc-8fa8de471199"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("efdd5ae5-a08c-401d-9586-6ed75c960117"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("1b0211e1-cbcc-4978-9760-726269a94c31"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("8d84ecb0-c0a5-4016-a247-516993ef7437"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatus",
                keyColumn: "Id",
                keyValue: new Guid("af772102-1331-4ea1-a516-62fb0eaa6e67"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("80a5cc24-b3d1-424f-a7e7-cec18b09baa9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ac1fc180-682b-4e47-a9fa-7eaed458dd50"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1585f7aa-fd5f-42a5-a6c6-b340a0c052a5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3913ba19-ed63-4480-9c6b-4dac2cee6fb0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("58be952f-8294-4428-8d39-c123a686e3ce"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("854b2992-8b8e-4b58-aefa-dab3eb7d9c66"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9a2e9cf2-7de5-48f0-ba28-9150e335fa60"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a9140311-167f-438d-adb6-6349ca165e01"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3478c11-1d4f-427c-80bb-c7de61ddac6c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cd0fba66-bf5c-4624-84f2-f7af13a7ea9a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5138d37-773e-494c-9e3b-149f4bf9e9c1"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("0b3b1e7c-90e8-4c8f-bcd7-d24d4b5b0c0b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("104bf1a3-c708-4c0a-9d97-102956d4e9a9"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("1e09a542-14d7-482b-baee-578b39ae2feb"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("2320310e-49cb-4774-9e7d-0092cb186ff7"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("35e01063-1ce1-4b0b-aa6b-1e096128cf3f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("51b0e977-3982-4e2e-b86e-8bda2d2f3b27"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("5bd157d1-3a3e-43d6-a4b4-e65729852f90"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("79868ef1-4886-41ac-96f0-814789e574db"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("a0786985-34dd-4cf3-ad93-4532fdb9a43b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("c7b3674b-1132-44bc-ab24-51bc7e2473c8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08c80b26-4b3d-4b8c-828b-01bc7b62838d"));
        }
    }
}
