using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EShop.Infra.Db.Sql.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] {  "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] {  "ebbe524b-b089-4342-ba6c-a1dbc9386d89", "AQAAAAIAAYagAAAAEP2c/joNrBvkfxNU2/sqj5Kxoh1h/Dtl7EpZIL5pYjHFw8rS2E/IsvvLYHottNemYg==", "8f6db601-5de7-417a-931f-fa67498f721f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15de2064-f5f7-4acd-88cf-99d8d633106e", "AQAAAAIAAYagAAAAEAMBjlWwf/V1h4xsZsXd1Zvw3FZYfSUc/R6JbabDP1K0Bfwhf6M/TbGGHl1SXwJGqg==", "741063eb-e8b0-4dae-a2a4-b5fae0bfeff3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2afe5331-563d-4af5-824a-e93e9373deb8", "AQAAAAIAAYagAAAAEH0zr7IyrlpZfYVV0PMni099kJfme2mQ4LxxlCZ+2xcEdqqBa4d/sw3PF0x6q6lcow==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e1bde18-4b38-4cce-a2bb-4cefe01514f1", "AQAAAAIAAYagAAAAEDo1jVeLGsanGD4aV5l+NbdoY9ihyGSEYjxXML99R3g9hUlh4aULbLOgHYcM5h2NRQ==", null });
        }
    }
}
