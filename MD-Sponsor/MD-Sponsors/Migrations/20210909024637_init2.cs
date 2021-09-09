using Microsoft.EntityFrameworkCore.Migrations;

namespace MD_Sponsors.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ad",
                columns: new[] { "ID", "Endorsment", "Image", "LinkToProduct", "Name", "ReferralCode" },
                values: new object[] { 2, "This is my endorsment for this product its absolutley amazing in almost every way", "IMAGE_URI_", "This is the link to the product.... ", "example product # 2", "SOMENUMBERSANDLETTERS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ad",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
