using Microsoft.EntityFrameworkCore.Migrations;

namespace ToolAuto.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserChoTotModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },  
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserChoTotModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserFbModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFbModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserGoogleModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGoogleModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserInstagramModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInstagramModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserLazadaModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLazadaModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserMarketingPlaceFbModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMarketingPlaceFbModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserOtherModel",
                columns: table => new
                {
                    MyProperty = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOtherModel", x => x.MyProperty);
                });

            migrationBuilder.CreateTable(
                name: "UserSendoModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSendoModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserShopeeModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserShopeeModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserTikTokModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTikTokModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserYoutubeModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserYoutubeModel", x => x.user);
                });

            migrationBuilder.CreateTable(
                name: "UserZaloModel",
                columns: table => new
                {
                    user = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserZaloModel", x => x.user);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserChoTotModel");

            migrationBuilder.DropTable(
                name: "UserFbModel");

            migrationBuilder.DropTable(
                name: "UserGoogleModel");

            migrationBuilder.DropTable(
                name: "UserInstagramModel");

            migrationBuilder.DropTable(
                name: "UserLazadaModel");

            migrationBuilder.DropTable(
                name: "UserMarketingPlaceFbModel");

            migrationBuilder.DropTable(
                name: "UserOtherModel");

            migrationBuilder.DropTable(
                name: "UserSendoModel");

            migrationBuilder.DropTable(
                name: "UserShopeeModel");

            migrationBuilder.DropTable(
                name: "UserTikTokModel");

            migrationBuilder.DropTable(
                name: "UserYoutubeModel");

            migrationBuilder.DropTable(
                name: "UserZaloModel");
        }
    }
}
