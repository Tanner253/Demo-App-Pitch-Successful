using Microsoft.EntityFrameworkCore.Migrations;

namespace MD_Sponsors.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ad",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endorsment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferralCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkToProduct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ad", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Ad",
                columns: new[] { "ID", "Endorsment", "Image", "LinkToProduct", "Name", "ReferralCode" },
                values: new object[] { 1, "I love, love, love the rainbow leaves! I only wear VS leggings to run or just relax in. They are super comfy and never roll during workouts. This is the second pair of these leggings I have purchased.  They fit and feel great!", "https://www.victoriassecret.com/p/760x1013/tif/0b/3d/0b3d5a483b5c4b9bab0815e5f1336309/111712650UNC_OM_F.jpg", "https://www.victoriassecret.com/us/vs/apparel-catalog/victoria-s-secret-total-knockout-by-victoria-s-secret-high-rise-tight-5000007478?genericId=11171265&choice=0UNC&size1=16&size1=16&cm_mmc=PLA-_-GOOGLE-_-VSD_GS+-+VS-+Top+Products+-+Apparel+Bottoms+-+P1-_-Type_Legging&gclid=CjwKCAjwvuGJBhB1EiwACU1AiVWV81AYw3dhwSknrq3s3oxU5OWSYmMBX0nkSI6OncF8nRwOPOSiqBoCQ50QAvD_BwE&gclsrc=aw.ds", "Victorias Secret Leggings TYPE=AC32", "DIAZDEALS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ad");
        }
    }
}
