using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookHubAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Fullname = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0278a11e-ae28-ea22-9a3b-4cdbf907b16e"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9999), "Gisselle", "Welch", new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1a7e937c-2ee8-9a94-8349-5c0164b7be77"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9988), "Cory", "Leannon", new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2e2da942-1554-3a91-d659-d797df62dad8"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9977), "Sherman", "Strosin", new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("33fd486f-34b7-a460-9984-a6869e834e31"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 674, DateTimeKind.Utc).AddTicks(23), "General", "Erdman", new DateTime(2024, 10, 7, 9, 51, 22, 674, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("39bd0599-d31d-11e7-065c-538cb686835d"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9954), "Junius", "Morissette", new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("465dd9a4-b10c-deb7-6a52-de987a3ad941"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 674, DateTimeKind.Utc).AddTicks(10), "Alia", "Kautzer", new DateTime(2024, 10, 7, 9, 51, 22, 674, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("51956ace-b389-8319-570a-2c73e12f28c4"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9942), "Freeda", "Schultz", new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5e995dd6-3888-dabe-d2ca-f43fa50564c0"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9965), "Cheyanne", "Mayer", new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("666e1d5c-aaaa-4eb9-bdb4-19972015dbaa"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9848), "Garett", "Blick", new DateTime(2024, 10, 7, 9, 51, 22, 673, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b569d1dc-df67-8268-fb3c-e2ab1751b62c"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 674, DateTimeKind.Utc).AddTicks(36), "Buck", "Dickinson", new DateTime(2024, 10, 7, 9, 51, 22, 674, DateTimeKind.Utc).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("12ee6bf5-2ed9-7811-5e51-e3951472d9d6"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9935), 793, new DateTime(1924, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9936), "Jerde Inc", "Corrupti aliquid.", new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2b451a34-fcb6-deb4-23fd-1fc4bf0dc838"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9030), 325, new DateTime(1924, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9031), "Corkery, Schaefer and Howell", "Repellendus placeat et et.", new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51925a4d-7c5b-563d-5dfa-01edc481b6e8"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(70), 428, new DateTime(1924, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(71), "Gerhold - Kirlin", "Dolor voluptatem.", new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53d46754-8af1-ce26-da9a-8310e2f14b9d"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9244), 408, new DateTime(1924, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9245), "Ortiz, King and Daugherty", "Neque error eveniet nam.", new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77696521-d742-21a3-ad7c-003cc4a0e4a4"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(358), 478, new DateTime(1924, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(359), "Hickle, Bauch and Tillman", "Corporis saepe.", new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90259ce9-87d2-ba78-fb6a-1cb6b6199220"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9780), 591, new DateTime(1924, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9781), "Stokes - Steuber", "İnventore dolor reprehenderit quia maiores.", new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1e561da-aadb-6e41-c890-89c9d67ab76c"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(568), 711, new DateTime(1924, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(569), "Boehm Inc", "Quod fuga architecto sit quia.", new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7d8a869-2348-e9cc-9569-72288b051297"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(7951), 187, new DateTime(1924, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(7956), "Schumm - Heaney", "Debitis dolore exercitationem.", new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c318ca68-dd2e-7228-e632-fba8f5507d43"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9602), 773, new DateTime(1924, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9603), "Grimes LLC", "Dicta consequatur quam assumenda.", new DateTime(2024, 10, 7, 9, 51, 22, 677, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("db229a78-0914-424b-6fed-15753a8a3ae6"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(180), 140, new DateTime(1924, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(181), "Bauch, Prosacco and Rodriguez", "Enim est at omnis.", new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("46a9821b-3dee-f394-b52d-e3936c3915e1"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4398), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4c61d5ea-daed-5cc4-d386-6a2b42e01c91"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4392), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6eac7367-e35a-ef48-ce44-1cf9e831fe28"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4395), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("85114f80-eedf-9dce-9929-9acd0a87f243"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4406), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("85cd9ed6-0076-f2ab-73ad-545777b1c9bb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4389), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("94191b24-733d-6afa-5a61-a3a8577acb61"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4404), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d43c4a6a-2c38-8336-3b17-8e257ecfe3ed"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4400), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dff2dbda-51aa-8664-4e8e-255a987724e8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4381), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f29a9785-64ca-3773-c2d8-b884eb99cb45"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4396), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f2c351c9-dc7e-a19e-948a-ccb88a18a224"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4402), new DateTime(2024, 10, 7, 9, 51, 22, 678, DateTimeKind.Utc).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("0fe05217-4bcc-b27a-d74a-7ffc3fa8bda4"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(7598), "Qui molestias iusto reprehenderit fuga numquam delectus numquam ut voluptas.", new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("1a2853ad-cd61-6504-94d9-b7833c6ecf7c"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8226), "Repellat itaque sed esse et officiis nobis.", new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8226) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712040"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(7944), "Quod aliquam expedita laboriosam laudantium est ut quis beatae quia aspernatur cum consequatur.", new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712044"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8071), "Adipisci nulla voluptatem voluptatem iure cum deserunt quidem ut maiores esse cumque illo placeat et nobis iusto molestiae quis.", new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("3cb7987a-567a-311c-e03b-d9c7b35552d1"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8135), "Dicta in ipsa ea nemo laborum ut in neque sit laborum autem.", new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("a8d817a4-88ed-85dc-d5f6-e48532c9c5e1"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(7823), "Numquam iusto non culpa eius accusamus rerum quia molestias numquam in.", new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("cd9eedb3-b38e-a511-0578-9f68937e663c"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8181), "Facere accusantium praesentium architecto ex ut veniam ullam autem impedit aut delectus recusandae modi.", new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("f30b692f-34fb-2007-7977-1d7be62bd962"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(7870), "Odit sunt placeat maiores laboriosam temporibus nisi dolorem et velit praesentium quos consequatur velit et voluptatem atque nihil.", new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("f30b692f-34fb-2007-7977-1d7be62bd965"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8013), "Repudiandae nam voluptatem a quaerat fugit harum sequi porro porro minima officia et assumenda dolores eos.", new DateTime(2024, 10, 7, 9, 51, 22, 681, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("0665cd7b-17f4-9387-e3ec-0a9f7ec0c15b"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(7193), "Voluptatibus voluptatibus reprehenderit sit aperiam consequatur tempora fuga vel fuga et aut ratione.", new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1afc5be6-b111-fab7-0cc9-757d3154adb3"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(6850), "Dolorum officiis voluptatem illo incidunt labore laborum aut et et et tempore error sint ut debitis nemo dolore ratione excepturi aut est quidem quisquam.", new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("274772b7-a644-4c41-7d38-0569ac273e65"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(7236), "Nam minus enim consequuntur iure assumenda aut quia et illum ipsum est exercitationem nesciunt enim molestias minima maxime est tempora qui a beatae dolores officia eligendi iusto reprehenderit omnis nostrum inventore quam in.", new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("60f6c9e4-14cf-42b9-7708-1b7d0974ba26"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(6488), "Aut voluptas minus dignissimos quia neque rerum consequatur ipsam quaerat amet rem ratione dolorum aut velit quia magni culpa dolorem error nobis accusamus et.", new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("be36e34d-fbb8-9b46-e9ad-b4a820e55016"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(6765), "Vitae harum nemo hic quibusdam recusandae expedita et eius voluptatem assumenda aperiam fugit qui sed explicabo quas est ducimus voluptate sed rerum.", new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d4e14be6-da76-444a-9c51-4cad6ca4a466"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(7074), "Ex facilis et consequatur vitae officiis quaerat quae id nesciunt numquam id suscipit ipsam placeat exercitationem officiis est et nihil autem necessitatibus beatae aut libero aspernatur repudiandae non aut beatae.", new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e8d2a2da-cd9e-f299-202c-b6ed9e1f94d7"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(6957), "Aut quasi quibusdam officia adipisci sunt assumenda corporis quo et quasi fuga veritatis totam optio odit inventore nostrum inventore provident veritatis sint.", new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("edc531de-3491-3ee9-7992-4be730ead84e"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(7035), "İllo rem id veritatis non sint rerum quam beatae ad voluptate.", new DateTime(2024, 10, 7, 9, 51, 22, 685, DateTimeKind.Utc).AddTicks(7036) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0278a11e-ae28-ea22-9a3b-4cdbf907b16e"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3910), "Jacklyn", "Johnson", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1a7e937c-2ee8-9a94-8349-5c0164b7be77"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3897), "Shanna", "Schiller", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2e2da942-1554-3a91-d659-d797df62dad8"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3883), "Roxane", "Lehner", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3884) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("33fd486f-34b7-a460-9984-a6869e834e31"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3931), "Hermann", "Brown", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("39bd0599-d31d-11e7-065c-538cb686835d"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3857), "Alexandria", "Emard", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("465dd9a4-b10c-deb7-6a52-de987a3ad941"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3920), "Dudley", "Murray", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("51956ace-b389-8319-570a-2c73e12f28c4"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3839), "Glenna", "O'Hara", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5e995dd6-3888-dabe-d2ca-f43fa50564c0"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3872), "Taurean", "Gerhold", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("666e1d5c-aaaa-4eb9-bdb4-19972015dbaa"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3716), "Donato", "Fisher", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b569d1dc-df67-8268-fb3c-e2ab1751b62c"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3944), "Nathen", "O'Conner", new DateTime(2024, 10, 2, 11, 9, 19, 792, DateTimeKind.Utc).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("12ee6bf5-2ed9-7811-5e51-e3951472d9d6"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5825), 467, new DateTime(1924, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5826), "Sawayn, Quitzon and Schimmel", "Velit ad.", new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2b451a34-fcb6-deb4-23fd-1fc4bf0dc838"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5281), 322, new DateTime(1924, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5282), "Turner - Effertz", "Eveniet aut consequatur.", new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51925a4d-7c5b-563d-5dfa-01edc481b6e8"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5953), 343, new DateTime(1924, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5953), "Rogahn, Medhurst and Mante", "Repudiandae.", new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53d46754-8af1-ce26-da9a-8310e2f14b9d"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5450), 306, new DateTime(1924, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5451), "Sporer, Dickens and Armstrong", "Autem.", new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77696521-d742-21a3-ad7c-003cc4a0e4a4"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(611), 171, new DateTime(1924, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(613), "VonRueden Group", "Facilis unde.", new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90259ce9-87d2-ba78-fb6a-1cb6b6199220"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5707), 388, new DateTime(1924, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5708), "Beahan - Harvey", "Debitis sit consequatur.", new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1e561da-aadb-6e41-c890-89c9d67ab76c"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(1975), 275, new DateTime(1924, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(1977), "Osinski, Wiegand and Grant", "Odio ut architecto cumque.", new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7d8a869-2348-e9cc-9569-72288b051297"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(4599), 633, new DateTime(1924, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(4602), "Daugherty - Altenwerth", "Labore commodi.", new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c318ca68-dd2e-7228-e632-fba8f5507d43"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5585), 496, new DateTime(1924, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5586), "Marvin - Price", "Molestiae.", new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(5586) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("db229a78-0914-424b-6fed-15753a8a3ae6"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(6101), 220, new DateTime(1924, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(6102), "Block Group", "Magni.", new DateTime(2024, 10, 2, 11, 9, 19, 795, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("46a9821b-3dee-f394-b52d-e3936c3915e1"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4952), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4c61d5ea-daed-5cc4-d386-6a2b42e01c91"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4946), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6eac7367-e35a-ef48-ce44-1cf9e831fe28"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4948), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("85114f80-eedf-9dce-9929-9acd0a87f243"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4958), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("85cd9ed6-0076-f2ab-73ad-545777b1c9bb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4943), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("94191b24-733d-6afa-5a61-a3a8577acb61"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4957), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d43c4a6a-2c38-8336-3b17-8e257ecfe3ed"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4953), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dff2dbda-51aa-8664-4e8e-255a987724e8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4939), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f29a9785-64ca-3773-c2d8-b884eb99cb45"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4949), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f2c351c9-dc7e-a19e-948a-ccb88a18a224"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4955), new DateTime(2024, 10, 2, 11, 9, 19, 796, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("0fe05217-4bcc-b27a-d74a-7ffc3fa8bda4"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(985), "Nostrum alias voluptas dolor qui quia dicta libero numquam sunt ut assumenda nesciunt quasi omnis magni quasi voluptas facere et et eos in.", new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("1a2853ad-cd61-6504-94d9-b7833c6ecf7c"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1728), "İpsum illum velit eaque qui est necessitatibus blanditiis cum earum non illum ducimus earum quo voluptatem deserunt omnis recusandae nihil doloremque necessitatibus vero.", new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712040"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1398), "Provident enim quo provident id nesciunt libero vero officia beatae qui vero suscipit dolorum et molestiae sint consequatur est ut rerum iste ratione sit eaque.", new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712044"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1558), "Cumque ea aut molestiae sed vitae.", new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("3cb7987a-567a-311c-e03b-d9c7b35552d1"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1588), "Aliquid vero laudantium corporis veritatis similique voluptas autem id fugit magni natus quibusdam impedit quisquam vel ut excepturi accusantium enim aut maiores.", new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("a8d817a4-88ed-85dc-d5f6-e48532c9c5e1"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1228), "Eligendi quia tenetur molestias odit debitis et harum tenetur dolorem quisquam tempore qui voluptatum.", new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("cd9eedb3-b38e-a511-0578-9f68937e663c"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1688), "Aut quis doloremque doloribus ullam aut consectetur eum nesciunt.", new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("f30b692f-34fb-2007-7977-1d7be62bd962"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1291), "Et earum eos facilis omnis et similique dolor voluptatem sit et ut et illo cupiditate veritatis nam nemo voluptatem voluptatem nisi possimus voluptatum.", new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("f30b692f-34fb-2007-7977-1d7be62bd965"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1492), "A nemo veritatis unde quaerat et sed sed modi ipsam illum cupiditate necessitatibus asperiores in totam ratione ea culpa ex.", new DateTime(2024, 10, 2, 11, 9, 19, 799, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("0665cd7b-17f4-9387-e3ec-0a9f7ec0c15b"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(952), "Distinctio assumenda rerum dolorem cum ducimus blanditiis molestiae qui maxime eum pariatur doloribus vero optio et aspernatur consequatur et iste voluptate veritatis corrupti amet.", new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1afc5be6-b111-fab7-0cc9-757d3154adb3"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(698), "Omnis sed architecto asperiores voluptas voluptas suscipit error.", new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("274772b7-a644-4c41-7d38-0569ac273e65"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(1023), "Fugit ad omnis voluptatum mollitia consequuntur velit et dolor omnis quis nisi quod.", new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("60f6c9e4-14cf-42b9-7708-1b7d0974ba26"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(379), "Ducimus dolor recusandae consequatur itaque similique autem delectus quia sint velit debitis tempora dolores quia eligendi dolorem est dolorem delectus magnam nihil.", new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("be36e34d-fbb8-9b46-e9ad-b4a820e55016"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(631), "Qui eum aut velit sint quidem illo maiores tempora dolore esse porro quia velit iste quo quis.", new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d4e14be6-da76-444a-9c51-4cad6ca4a466"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(889), "Totam harum nam occaecati suscipit doloribus et voluptatum error consectetur facilis cumque voluptas distinctio quia ipsam et voluptate voluptatum et magnam.", new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e8d2a2da-cd9e-f299-202c-b6ed9e1f94d7"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(730), "Voluptates beatae sed voluptatem dolorum omnis magni in consectetur est delectus qui ipsum in suscipit corporis in delectus debitis dolor et repellendus cupiditate voluptate earum qui autem excepturi quo iste laboriosam.", new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("edc531de-3491-3ee9-7992-4be730ead84e"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(846), "Nostrum illo nemo rem non ut et sed qui perspiciatis sit sint.", new DateTime(2024, 10, 2, 11, 9, 19, 802, DateTimeKind.Utc).AddTicks(847) });
        }
    }
}
