using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Api.Pe.Infrastructure.Migrations
{
    public partial class renamedDbSetCorrectly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    EmployerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_AspNetUsers_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RevieweeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_RevieweeId",
                        column: x => x.RevieweeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserSkill",
                columns: table => new
                {
                    SkillsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserSkill", x => new { x.SkillsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserSkill_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserSkill_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_ApplicationStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "ApplicationStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_AspNetUsers_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JobSkill",
                columns: table => new
                {
                    JobsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSkill", x => new { x.JobsId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_JobSkill_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobSkill_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CandidateId",
                table: "Applications",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_JobId",
                table: "Applications",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_StatusId",
                table: "Applications",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserSkill_UsersId",
                table: "ApplicationUserSkill",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_EmployerId",
                table: "Jobs",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkill_SkillsId",
                table: "JobSkill",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RevieweeId",
                table: "Reviews",
                column: "RevieweeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "ApplicationUserSkill");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "JobSkill");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ApplicationStatus");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
