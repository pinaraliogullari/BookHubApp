using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookHubAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "Files",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AuthorAuthorImageFile",
                columns: table => new
                {
                    AuthorImageFilesId = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorAuthorImageFile", x => new { x.AuthorImageFilesId, x.AuthorsId });
                    table.ForeignKey(
                        name: "FK_AuthorAuthorImageFile_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorAuthorImageFile_Files_AuthorImageFilesId",
                        column: x => x.AuthorImageFilesId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AuthorAuthorImageFile_AuthorsId",
                table: "AuthorAuthorImageFile",
                column: "AuthorsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorAuthorImageFile");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Files");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0278a11e-ae28-ea22-9a3b-4cdbf907b16e"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5932), "Frida", "Rowe", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1a7e937c-2ee8-9a94-8349-5c0164b7be77"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5888), "Cassie", "Stark", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2e2da942-1554-3a91-d659-d797df62dad8"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5865), "Emie", "Lueilwitz", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("33fd486f-34b7-a460-9984-a6869e834e31"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5984), "Jamaal", "Wunsch", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("39bd0599-d31d-11e7-065c-538cb686835d"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5815), "Bert", "Bogan", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("465dd9a4-b10c-deb7-6a52-de987a3ad941"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5964), "Alexis", "Gottlieb", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("51956ace-b389-8319-570a-2c73e12f28c4"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5789), "Isac", "Rohan", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5e995dd6-3888-dabe-d2ca-f43fa50564c0"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5838), "Lyla", "Bahringer", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("666e1d5c-aaaa-4eb9-bdb4-19972015dbaa"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5582), "Madisen", "Buckridge", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b569d1dc-df67-8268-fb3c-e2ab1751b62c"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(6005), "Consuelo", "Kessler", new DateTime(2024, 9, 30, 14, 18, 40, 177, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("12ee6bf5-2ed9-7811-5e51-e3951472d9d6"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8349), 438, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8351), "Bechtelar Group", "Doloribus accusantium harum unde aperiam.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2b451a34-fcb6-deb4-23fd-1fc4bf0dc838"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(6992), 503, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(6996), "Gleason Group", "Quia qui provident.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51925a4d-7c5b-563d-5dfa-01edc481b6e8"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8591), 418, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8593), "Goyette, Turcotte and Morar", "Similique.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53d46754-8af1-ce26-da9a-8310e2f14b9d"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(7465), 535, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(7473), "Block, Greenholt and Sawayn", "Quam laboriosam.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77696521-d742-21a3-ad7c-003cc4a0e4a4"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(9164), 250, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(9165), "DuBuque - Reilly", "Numquam soluta nesciunt nesciunt beatae.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90259ce9-87d2-ba78-fb6a-1cb6b6199220"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8069), 576, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8071), "Heaney - Gutmann", "Sunt deleniti.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1e561da-aadb-6e41-c890-89c9d67ab76c"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(9440), 352, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(9441), "Moen - Adams", "Rerum fugiat tenetur a qui.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7d8a869-2348-e9cc-9569-72288b051297"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(3776), 996, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(3790), "Streich, Batz and Bogan", "Provident rem impedit autem.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c318ca68-dd2e-7228-e632-fba8f5507d43"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(7811), 353, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(7813), "Wuckert, Schuster and Rippin", "Sint.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("db229a78-0914-424b-6fed-15753a8a3ae6"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8966), 543, new DateTime(1924, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8968), "Powlowski - Cummerata", "İnventore incidunt eveniet doloremque architecto.", new DateTime(2024, 9, 30, 14, 18, 40, 185, DateTimeKind.Utc).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("46a9821b-3dee-f394-b52d-e3936c3915e1"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4771), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4c61d5ea-daed-5cc4-d386-6a2b42e01c91"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4765), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6eac7367-e35a-ef48-ce44-1cf9e831fe28"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4766), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("85114f80-eedf-9dce-9929-9acd0a87f243"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4778), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("85cd9ed6-0076-f2ab-73ad-545777b1c9bb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4762), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("94191b24-733d-6afa-5a61-a3a8577acb61"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4776), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d43c4a6a-2c38-8336-3b17-8e257ecfe3ed"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4772), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dff2dbda-51aa-8664-4e8e-255a987724e8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4754), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f29a9785-64ca-3773-c2d8-b884eb99cb45"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4768), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f2c351c9-dc7e-a19e-948a-ccb88a18a224"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4774), new DateTime(2024, 9, 30, 14, 18, 40, 186, DateTimeKind.Utc).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("0fe05217-4bcc-b27a-d74a-7ffc3fa8bda4"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 192, DateTimeKind.Utc).AddTicks(7579), "İd sed officiis natus aut hic rem rerum pariatur blanditiis distinctio dolor aut sit ut quidem.", new DateTime(2024, 9, 30, 14, 18, 40, 192, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("1a2853ad-cd61-6504-94d9-b7833c6ecf7c"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(5104), "Consectetur maiores ut vero eveniet et sapiente nisi dolorem non quidem mollitia officia voluptatem porro aliquam est modi dolorum omnis asperiores sunt.", new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712040"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(934), "Error autem eligendi tempore nisi nihil sed et voluptatem harum sit et sunt optio laudantium error officiis quia natus qui consectetur ut facilis.", new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712044"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(1671), "Voluptatem ut tempora dolores libero fuga quia eius tempore ut minus ipsam ut molestiae dignissimos quae cum laborum doloremque quidem vitae ducimus et.", new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("3cb7987a-567a-311c-e03b-d9c7b35552d1"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(4712), "Necessitatibus ab totam reprehenderit ipsa magnam qui error sint sunt sunt consequatur repellendus eum deserunt numquam recusandae fugit et quasi pariatur quisquam aperiam consequuntur.", new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("a8d817a4-88ed-85dc-d5f6-e48532c9c5e1"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 192, DateTimeKind.Utc).AddTicks(8735), "Quisquam quibusdam et voluptas id quis ipsa doloremque corporis repudiandae tempora cum accusantium et ipsam voluptatem consequatur.", new DateTime(2024, 9, 30, 14, 18, 40, 192, DateTimeKind.Utc).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("cd9eedb3-b38e-a511-0578-9f68937e663c"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(4935), "Et ipsam quo aut ratione atque facere sunt enim quaerat sequi sunt corporis quo et eos molestiae et sit autem illum sunt alias et voluptatum.", new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("f30b692f-34fb-2007-7977-1d7be62bd962"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(772), "Voluptas magni ut aut deserunt velit.", new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("f30b692f-34fb-2007-7977-1d7be62bd965"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(1440), "Eligendi et cumque quo inventore aut in consequuntur iure repellat commodi minus quas sit delectus.", new DateTime(2024, 9, 30, 14, 18, 40, 193, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("0665cd7b-17f4-9387-e3ec-0a9f7ec0c15b"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 204, DateTimeKind.Utc).AddTicks(2647), "Quia id pariatur magnam amet et doloremque est quae.", new DateTime(2024, 9, 30, 14, 18, 40, 204, DateTimeKind.Utc).AddTicks(2653) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1afc5be6-b111-fab7-0cc9-757d3154adb3"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(8608), "Non consequuntur voluptas voluptas deleniti doloribus vero illo unde itaque atque aperiam cum esse.", new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("274772b7-a644-4c41-7d38-0569ac273e65"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 204, DateTimeKind.Utc).AddTicks(2936), "Eius amet omnis et et nobis earum facilis quia laboriosam maxime possimus eos earum eum ut voluptatibus commodi porro dolores non alias nam qui dolor in nihil aut et tenetur.", new DateTime(2024, 9, 30, 14, 18, 40, 204, DateTimeKind.Utc).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("60f6c9e4-14cf-42b9-7708-1b7d0974ba26"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(7726), "Veritatis itaque suscipit pariatur aut expedita in autem animi necessitatibus voluptas et maxime sed ducimus non est aut.", new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("be36e34d-fbb8-9b46-e9ad-b4a820e55016"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(8430), "Temporibus molestias qui aliquam adipisci cumque eveniet dolores aut ullam debitis voluptas et earum aliquid neque consequatur cum omnis culpa sit aliquam reiciendis nam pariatur.", new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d4e14be6-da76-444a-9c51-4cad6ca4a466"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(9335), "Voluptatibus aut aspernatur accusamus et qui dicta maxime ullam quia non suscipit occaecati autem sit excepturi rerum illum magnam repellendus voluptate voluptates qui iusto non rerum unde vel nostrum porro.", new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e8d2a2da-cd9e-f299-202c-b6ed9e1f94d7"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(8715), "Vel maiores aspernatur aut exercitationem fugit voluptatum beatae omnis iure soluta repudiandae architecto sed voluptatem eius ut et voluptas dolore in et enim explicabo ut est et vel deleniti qui possimus facilis quod harum perspiciatis.", new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("edc531de-3491-3ee9-7992-4be730ead84e"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(9223), "Esse et deleniti aut praesentium deleniti aut quas excepturi officiis et delectus qui nihil autem.", new DateTime(2024, 9, 30, 14, 18, 40, 202, DateTimeKind.Utc).AddTicks(9224) });
        }
    }
}
