using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookHubAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Files",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Files",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PublishmentCount",
                table: "Files",
                type: "integer",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "PublishmentCount",
                table: "Files");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0278a11e-ae28-ea22-9a3b-4cdbf907b16e"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7070), "Donald", "Cartwright", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1a7e937c-2ee8-9a94-8349-5c0164b7be77"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7056), "Trace", "Hermann", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2e2da942-1554-3a91-d659-d797df62dad8"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7046), "Israel", "Feeney", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("33fd486f-34b7-a460-9984-a6869e834e31"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7091), "Camden", "Champlin", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("39bd0599-d31d-11e7-065c-538cb686835d"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(6986), "Camden", "Murazik", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("465dd9a4-b10c-deb7-6a52-de987a3ad941"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7080), "Mireya", "Oberbrunner", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("51956ace-b389-8319-570a-2c73e12f28c4"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(6971), "Helmer", "Walker", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("5e995dd6-3888-dabe-d2ca-f43fa50564c0"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(6998), "Clara", "Hoppe", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("666e1d5c-aaaa-4eb9-bdb4-19972015dbaa"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(6904), "Raleigh", "Johnston", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b569d1dc-df67-8268-fb3c-e2ab1751b62c"),
                columns: new[] { "CreatedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7099), "Lula", "Welch", new DateTime(2024, 9, 30, 14, 0, 12, 304, DateTimeKind.Utc).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("12ee6bf5-2ed9-7811-5e51-e3951472d9d6"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6051), 444, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6052), "Jaskolski, Tremblay and Blanda", "Exercitationem molestias voluptatem ullam.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2b451a34-fcb6-deb4-23fd-1fc4bf0dc838"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5384), 342, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5385), "Nader and Sons", "Harum exercitationem et.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51925a4d-7c5b-563d-5dfa-01edc481b6e8"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6265), 779, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6266), "Steuber LLC", "Eos quia repudiandae.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53d46754-8af1-ce26-da9a-8310e2f14b9d"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5627), 978, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5628), "Feest Group", "Blanditiis labore vero.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77696521-d742-21a3-ad7c-003cc4a0e4a4"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6578), 968, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6579), "Mueller - Cronin", "İn aut.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90259ce9-87d2-ba78-fb6a-1cb6b6199220"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5935), 429, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5936), "Runolfsson and Sons", "Aliquid deserunt in ab.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1e561da-aadb-6e41-c890-89c9d67ab76c"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6679), 206, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6680), "Lang - Harris", "Sed maiores quam est omnis.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a7d8a869-2348-e9cc-9569-72288b051297"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(4609), 663, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(4611), "Senger - Kuphal", "Quibusdam dolorem est.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c318ca68-dd2e-7228-e632-fba8f5507d43"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5781), 432, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5782), "Roberts Group", "İnventore a exercitationem nostrum asperiores.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("db229a78-0914-424b-6fed-15753a8a3ae6"),
                columns: new[] { "CreatedDate", "PageCount", "PublicationDate", "Publisher", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6403), 500, new DateTime(1924, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6404), "Reinger, Koss and Aufderhar", "Quam et corrupti.", new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("46a9821b-3dee-f394-b52d-e3936c3915e1"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9480), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("4c61d5ea-daed-5cc4-d386-6a2b42e01c91"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9473), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6eac7367-e35a-ef48-ce44-1cf9e831fe28"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9476), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("85114f80-eedf-9dce-9929-9acd0a87f243"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9493), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("85cd9ed6-0076-f2ab-73ad-545777b1c9bb"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9470), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("94191b24-733d-6afa-5a61-a3a8577acb61"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9486), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d43c4a6a-2c38-8336-3b17-8e257ecfe3ed"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9482), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("dff2dbda-51aa-8664-4e8e-255a987724e8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9305), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f29a9785-64ca-3773-c2d8-b884eb99cb45"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9477), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9478) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f2c351c9-dc7e-a19e-948a-ccb88a18a224"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9483), new DateTime(2024, 9, 30, 14, 0, 12, 306, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("0fe05217-4bcc-b27a-d74a-7ffc3fa8bda4"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6418), "Aspernatur quod officia similique nihil quibusdam ea consectetur pariatur.", new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("1a2853ad-cd61-6504-94d9-b7833c6ecf7c"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6883), "Voluptas eum eaque voluptatem veritatis et et doloribus laborum amet laborum nulla ad explicabo dolor dolore debitis quo distinctio aut voluptatum porro.", new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712040"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6653), "Alias est temporibus earum voluptatum ducimus praesentium unde dolores harum.", new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("2f5d4de3-c391-b1a4-1260-b6bfdc712044"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6725), "Quod est officia unde consequatur esse maxime qui ipsum odio accusantium adipisci nam.", new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("3cb7987a-567a-311c-e03b-d9c7b35552d1"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6763), "Recusandae dolorum minima odio nostrum vel odio atque et non eos veniam et quae nostrum fuga enim a tenetur soluta doloremque amet omnis.", new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("a8d817a4-88ed-85dc-d5f6-e48532c9c5e1"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6558), "Tempore debitis voluptatum atque recusandae aliquam possimus repellat perspiciatis ipsam eius voluptas magni est.", new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("cd9eedb3-b38e-a511-0578-9f68937e663c"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6821), "Laudantium perspiciatis qui esse atque recusandae quidem expedita necessitatibus aut eos maiores eos totam consequatur explicabo ea pariatur id et dolor.", new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("f30b692f-34fb-2007-7977-1d7be62bd962"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6609), "Aperiam quae qui hic maxime est enim optio aut nesciunt tempore.", new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: new Guid("f30b692f-34fb-2007-7977-1d7be62bd965"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6684), "Mollitia error laudantium nam sed quasi ipsum consequuntur asperiores doloribus facilis itaque incidunt.", new DateTime(2024, 9, 30, 14, 0, 12, 308, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("0665cd7b-17f4-9387-e3ec-0a9f7ec0c15b"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3165), "Corrupti eos odio earum non dolorem expedita et similique voluptatem perspiciatis fugiat et neque id tempora delectus id sequi ut explicabo dolorem dignissimos eveniet voluptatum iure provident corrupti et sunt deserunt aut quia error nemo.", new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1afc5be6-b111-fab7-0cc9-757d3154adb3"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(2927), "İd occaecati cum sed et a et itaque voluptatem nobis voluptate voluptatem et sint quidem qui omnis animi natus deleniti corrupti tempore necessitatibus facere fuga recusandae ex hic iusto porro veniam occaecati qui ab.", new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("274772b7-a644-4c41-7d38-0569ac273e65"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3254), "Accusamus et et officia eos qui quis harum debitis voluptatem qui eligendi qui dolor facere perspiciatis et placeat eius fuga mollitia quos molestiae aut culpa in quis et.", new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("60f6c9e4-14cf-42b9-7708-1b7d0974ba26"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(2763), "Officia non voluptas molestias ut atque et similique totam soluta blanditiis et non unde error sint occaecati aut in voluptas.", new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("be36e34d-fbb8-9b46-e9ad-b4a820e55016"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(2899), "Corporis et voluptate nisi aspernatur quia nulla.", new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("d4e14be6-da76-444a-9c51-4cad6ca4a466"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3101), "Corporis quam eos pariatur id beatae enim deleniti labore quibusdam ipsa dolores modi ullam aut corporis rerum omnis ducimus perferendis reprehenderit sunt tempora sapiente.", new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("e8d2a2da-cd9e-f299-202c-b6ed9e1f94d7"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3018), "Enim occaecati hic nihil facere doloribus nesciunt et vel fuga ut rem esse.", new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("edc531de-3491-3ee9-7992-4be730ead84e"),
                columns: new[] { "CreatedDate", "Description", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3062), "Vel sunt laudantium aut mollitia magni non illum magni aut quia porro dolor.", new DateTime(2024, 9, 30, 14, 0, 12, 310, DateTimeKind.Utc).AddTicks(3063) });
        }
    }
}
