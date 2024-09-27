using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookHubAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenreId = table.Column<Guid>(type: "uuid", nullable: false),
                    Publisher = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PageCount = table.Column<int>(type: "integer", nullable: false),
                    PublicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quotations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0278a11e-ae28-ea22-9a3b-4cdbf907b16e"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3965), "Sigourney", "England", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3965) },
                    { new Guid("1a7e937c-2ee8-9a94-8349-5c0164b7be77"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3963), "Peter", "Cummings", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3963) },
                    { new Guid("2e2da942-1554-3a91-d659-d797df62dad8"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3960), "Jescie", "Maddox", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3960) },
                    { new Guid("33fd486f-34b7-a460-9984-a6869e834e31"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3968), "Amena", "James", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3969) },
                    { new Guid("39bd0599-d31d-11e7-065c-538cb686835d"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3891), "Chandler", "Vargas", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3892) },
                    { new Guid("465dd9a4-b10c-deb7-6a52-de987a3ad941"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3967), "Ori", "Estrada", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3967) },
                    { new Guid("51956ace-b389-8319-570a-2c73e12f28c4"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3889), "Caryn", "Dunlap", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3890) },
                    { new Guid("5e995dd6-3888-dabe-d2ca-f43fa50564c0"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3958), "Hoyt", "Cantu", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3958) },
                    { new Guid("666e1d5c-aaaa-4eb9-bdb4-19972015dbaa"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3881), "Clare", "Fernandez", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3885) },
                    { new Guid("b569d1dc-df67-8268-fb3c-e2ab1751b62c"), new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3970), "Rigel", "Peck", new DateTime(2024, 9, 26, 12, 39, 13, 758, DateTimeKind.Utc).AddTicks(3971) }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("46a9821b-3dee-f394-b52d-e3936c3915e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Romance", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c61d5ea-daed-5cc4-d386-6a2b42e01c91"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fiction", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6eac7367-e35a-ef48-ce44-1cf9e831fe28"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biography", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85114f80-eedf-9dce-9929-9acd0a87f243"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Science ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85cd9ed6-0076-f2ab-73ad-545777b1c9bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantasy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94191b24-733d-6afa-5a61-a3a8577acb61"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Self-Help ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d43c4a6a-2c38-8336-3b17-8e257ecfe3ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psychology ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dff2dbda-51aa-8664-4e8e-255a987724e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poetry ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f29a9785-64ca-3773-c2d8-b884eb99cb45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "History", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2c351c9-dc7e-a19e-948a-ccb88a18a224"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fairytale ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "GenreId", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("12ee6bf5-2ed9-7811-5e51-e3951472d9d6"), new Guid("2e2da942-1554-3a91-d659-d797df62dad8"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4799), new Guid("85114f80-eedf-9dce-9929-9acd0a87f243"), 241, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4801), "Oberbrunner - Hermiston", "Perferendis aliquid nisi officiis.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4800) },
                    { new Guid("2b451a34-fcb6-deb4-23fd-1fc4bf0dc838"), new Guid("666e1d5c-aaaa-4eb9-bdb4-19972015dbaa"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4059), new Guid("dff2dbda-51aa-8664-4e8e-255a987724e8"), 863, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4061), "West - Haag", "Magnam.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4060) },
                    { new Guid("51925a4d-7c5b-563d-5dfa-01edc481b6e8"), new Guid("1a7e937c-2ee8-9a94-8349-5c0164b7be77"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4979), new Guid("f29a9785-64ca-3773-c2d8-b884eb99cb45"), 166, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4981), "Stiedemann Inc", "Dolore perspiciatis ut sint qui.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4980) },
                    { new Guid("53d46754-8af1-ce26-da9a-8310e2f14b9d"), new Guid("51956ace-b389-8319-570a-2c73e12f28c4"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4203), new Guid("f2c351c9-dc7e-a19e-948a-ccb88a18a224"), 493, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4204), "Cassin - Schinner", "İllum.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4203) },
                    { new Guid("77696521-d742-21a3-ad7c-003cc4a0e4a4"), new Guid("1a7e937c-2ee8-9a94-8349-5c0164b7be77"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(5454), new Guid("85cd9ed6-0076-f2ab-73ad-545777b1c9bb"), 898, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(5455), "Sipes - Emard", "Sunt voluptas quaerat.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(5454) },
                    { new Guid("90259ce9-87d2-ba78-fb6a-1cb6b6199220"), new Guid("5e995dd6-3888-dabe-d2ca-f43fa50564c0"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4652), new Guid("85114f80-eedf-9dce-9929-9acd0a87f243"), 100, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4653), "Powlowski - Hegmann", "Alias pariatur iure aliquam explicabo.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4653) },
                    { new Guid("a1e561da-aadb-6e41-c890-89c9d67ab76c"), new Guid("465dd9a4-b10c-deb7-6a52-de987a3ad941"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(5649), new Guid("dff2dbda-51aa-8664-4e8e-255a987724e8"), 822, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(5650), "Schuster - Lindgren", "Debitis.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(5649) },
                    { new Guid("a7d8a869-2348-e9cc-9569-72288b051297"), new Guid("666e1d5c-aaaa-4eb9-bdb4-19972015dbaa"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(2828), new Guid("4c61d5ea-daed-5cc4-d386-6a2b42e01c91"), 122, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(2833), "Crooks, Brown and Farrell", "Velit voluptas nulla.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(2832) },
                    { new Guid("c318ca68-dd2e-7228-e632-fba8f5507d43"), new Guid("39bd0599-d31d-11e7-065c-538cb686835d"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4371), new Guid("94191b24-733d-6afa-5a61-a3a8577acb61"), 347, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4371), "Denesik, Beatty and Mertz", "İpsam.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(4371) },
                    { new Guid("db229a78-0914-424b-6fed-15753a8a3ae6"), new Guid("0278a11e-ae28-ea22-9a3b-4cdbf907b16e"), new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(5230), new Guid("6eac7367-e35a-ef48-ce44-1cf9e831fe28"), 836, new DateTime(1924, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(5231), "Gleichner, Larson and Hoeger", "Quaerat saepe iusto distinctio dicta.", new DateTime(2024, 9, 26, 12, 39, 13, 763, DateTimeKind.Utc).AddTicks(5231) }
                });

            migrationBuilder.InsertData(
                table: "Quotations",
                columns: new[] { "Id", "BookId", "CreatedDate", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0fe05217-4bcc-b27a-d74a-7ffc3fa8bda4"), new Guid("a7d8a869-2348-e9cc-9569-72288b051297"), new DateTime(2024, 9, 26, 12, 39, 13, 769, DateTimeKind.Utc).AddTicks(9692), "Necessitatibus ex.", new DateTime(2024, 9, 26, 12, 39, 13, 769, DateTimeKind.Utc).AddTicks(9696) },
                    { new Guid("1a2853ad-cd61-6504-94d9-b7833c6ecf7c"), new Guid("a7d8a869-2348-e9cc-9569-72288b051297"), new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(244), "Rerum et numquam.", new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(245) },
                    { new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712040"), new Guid("c318ca68-dd2e-7228-e632-fba8f5507d43"), new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(85), "Architecto dolorum molestiae laudantium est voluptas.", new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(86) },
                    { new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712044"), new Guid("12ee6bf5-2ed9-7811-5e51-e3951472d9d6"), new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(161), "Quia.", new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(162) },
                    { new Guid("3cb7987a-567a-311c-e03b-d9c7b35552d1"), new Guid("51925a4d-7c5b-563d-5dfa-01edc481b6e8"), new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(176), "Ut dolor fugit et consequatur dolorum.", new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(177) },
                    { new Guid("a8d817a4-88ed-85dc-d5f6-e48532c9c5e1"), new Guid("2b451a34-fcb6-deb4-23fd-1fc4bf0dc838"), new DateTime(2024, 9, 26, 12, 39, 13, 769, DateTimeKind.Utc).AddTicks(9944), "Fuga quaerat id placeat veritatis vero.", new DateTime(2024, 9, 26, 12, 39, 13, 769, DateTimeKind.Utc).AddTicks(9945) },
                    { new Guid("cd9eedb3-b38e-a511-0578-9f68937e663c"), new Guid("c318ca68-dd2e-7228-e632-fba8f5507d43"), new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(218), "Aut dolores enim.", new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(219) },
                    { new Guid("f30b692f-34fb-2007-7977-1d7be62bd962"), new Guid("53d46754-8af1-ce26-da9a-8310e2f14b9d"), new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(46), "Fuga vitae vitae veniam eum.", new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(47) },
                    { new Guid("f30b692f-34fb-2007-7977-1d7be62bd965"), new Guid("90259ce9-87d2-ba78-fb6a-1cb6b6199220"), new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(130), "Quia sed accusantium veritatis.", new DateTime(2024, 9, 26, 12, 39, 13, 770, DateTimeKind.Utc).AddTicks(130) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "CreatedDate", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0665cd7b-17f4-9387-e3ec-0a9f7ec0c15b"), new Guid("90259ce9-87d2-ba78-fb6a-1cb6b6199220"), new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7681), "Perferendis vero nobis nobis saepe harum.", new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7681) },
                    { new Guid("1afc5be6-b111-fab7-0cc9-757d3154adb3"), new Guid("2b451a34-fcb6-deb4-23fd-1fc4bf0dc838"), new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7599), "Minus dolorum accusantium voluptatem.", new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7600) },
                    { new Guid("274772b7-a644-4c41-7d38-0569ac273e65"), new Guid("12ee6bf5-2ed9-7811-5e51-e3951472d9d6"), new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7720), "Officiis voluptates.", new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7720) },
                    { new Guid("60f6c9e4-14cf-42b9-7708-1b7d0974ba26"), new Guid("a7d8a869-2348-e9cc-9569-72288b051297"), new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7410), "Vel eius est voluptas sit.", new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7414) },
                    { new Guid("be36e34d-fbb8-9b46-e9ad-b4a820e55016"), new Guid("2b451a34-fcb6-deb4-23fd-1fc4bf0dc838"), new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7571), "Laboriosam quia ad et et dolorem.", new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7571) },
                    { new Guid("d4e14be6-da76-444a-9c51-4cad6ca4a466"), new Guid("90259ce9-87d2-ba78-fb6a-1cb6b6199220"), new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7660), "Culpa ut necessitatibus sed sit.", new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7660) },
                    { new Guid("e8d2a2da-cd9e-f299-202c-b6ed9e1f94d7"), new Guid("53d46754-8af1-ce26-da9a-8310e2f14b9d"), new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7618), "Dolorum ea omnis.", new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7618) },
                    { new Guid("edc531de-3491-3ee9-7992-4be730ead84e"), new Guid("c318ca68-dd2e-7228-e632-fba8f5507d43"), new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7633), "Architecto deleniti sint sequi non sunt nihil.", new DateTime(2024, 9, 26, 12, 39, 13, 774, DateTimeKind.Utc).AddTicks(7633) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_BookId",
                table: "Quotations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotations");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
