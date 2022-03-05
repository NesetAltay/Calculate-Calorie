using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CalorieCalculate.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YemekGruplari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekGruplari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KullaniciBilgileri_Kullanici_Id",
                        column: x => x.Id,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgunBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgunBilgileri_Kullanici_UserId",
                        column: x => x.UserId,
                        principalTable: "Kullanici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MealDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Calorie = table.Column<double>(type: "float", nullable: false),
                    TypeMealId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YemekBilgileri_YemekGruplari_TypeMealId",
                        column: x => x.TypeMealId,
                        principalTable: "YemekGruplari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgunYemek",
                columns: table => new
                {
                    RepastId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    EatenPortion = table.Column<double>(type: "float", nullable: false),
                    MealImage = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunYemek", x => new { x.MealId, x.RepastId });
                    table.ForeignKey(
                        name: "FK_OgunYemek_OgunBilgileri_RepastId",
                        column: x => x.RepastId,
                        principalTable: "OgunBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunYemek_YemekBilgileri_MealId",
                        column: x => x.MealId,
                        principalTable: "YemekBilgileri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "YemekGruplari",
                columns: new[] { "Id", "MealType" },
                values: new object[,]
                {
                    { 1, "Süt Grubu" },
                    { 2, "Et Grubu" },
                    { 3, "Kurubaklagil Grubu" },
                    { 4, "Ekmek Grubu" },
                    { 5, "Sebze Grubu" },
                    { 6, "Meyve Grubu" },
                    { 7, "Yağ Grubu" },
                    { 8, "Tatlı Grubu" },
                    { 9, "Kuruyemiş Grubu" }
                });

            migrationBuilder.InsertData(
                table: "YemekBilgileri",
                columns: new[] { "Id", "Calorie", "MealDescription", "MealName", "TypeMealId" },
                values: new object[,]
                {
                    { 1, 114000.0, "1 porsiyon, 1 su bardağı, 200 ml", "Süt", 1 },
                    { 75, 60000.0, "1 porsiyon, 8 iri adet , 90 gram", "Kiraz", 6 },
                    { 74, 60000.0, "1 porsiyon, 1 adet , 100 gram", "İncir", 6 },
                    { 73, 60000.0, "1 porsiyon, 5 adet , 85 gram", "Erik", 6 },
                    { 72, 60000.0, "1 porsiyon, 4 adet , 120 gram", "Kayısı", 6 },
                    { 71, 60000.0, "1 porsiyon, 6 adet , 100 gram", "Yeni Dünya", 6 },
                    { 70, 60000.0, "1 porsiyon, 15 iri adet , 100 gram", "üzüm", 6 },
                    { 69, 120000.0, "1 porsiyon, 1 küçük boy , 200 gram", "Nar", 6 },
                    { 68, 98000.0, "1 porsiyon, 1 orta boy , 250 gram", "Ayva", 6 },
                    { 67, 60000.0, "1 porsiyon, 3 halka , 120 gram", "Ananas", 6 },
                    { 66, 60000.0, "1 porsiyon, 1 orta boy , 120 gram", "Kivi", 6 },
                    { 76, 60000.0, "1 porsiyon, 4 adet , 20 gram", "Kuru Kayısı", 6 },
                    { 65, 150000.0, "1 porsiyon, 1 orta boy , 60 gram", "Muz", 6 },
                    { 63, 60000.0, "1 porsiyon, 1 büyük boy , 150 gram", "Mandalina", 6 },
                    { 62, 103000.0, "1 porsiyon, 1 orta boy , 220 gram", "Portakal", 6 },
                    { 61, 60000.0, "1 porsiyon, 1 küçük boy , 120 gram", "Armut", 6 },
                    { 60, 60000.0, "1 porsiyon, 1 küçük boy , 120 gram", "Elma", 6 },
                    { 59, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Kereviz", 5 },
                    { 58, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Havuç", 5 },
                    { 57, 25000.0, "1 porsiyon, 1 orta boy , 200 gram", "Enginar", 5 },
                    { 56, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Bezelye", 5 },
                    { 55, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Bakla", 5 },
                    { 54, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Taze Fasulye(Pişmiş)", 5 },
                    { 64, 60000.0, "1 porsiyon, 1 küçük boy , 150 gram", "Greyfurt", 6 },
                    { 53, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Semizotu(Pişmiş)", 5 },
                    { 77, 60000.0, "1 porsiyon, 1 küçük boy , 20 gram", "Kuru İncir", 6 },
                    { 79, 60000.0, "1 porsiyon, 1 yemek kaşığı, 20 gram", "Kuru Üzüm", 6 },
                    { 101, 68000.0, "1 porsiyon, 5 adet, 10 gram", "Badem içi", 9 },
                    { 100, 68000.0, "1 porsiyon, 1 avuç, 10 gram", "Kabak Çekirdeği", 9 },
                    { 99, 68000.0, "1 porsiyon, 1 avuç, 10 gram", "Ay Çekirdeği", 9 },
                    { 98, 45000.0, "1 porsiyon, 2 adet, 8 gram", "Ceviz içi", 9 },
                    { 97, 68000.0, "1 porsiyon, 1 çay bardağı, 20 gram", "Leblebi", 9 },
                    { 96, 68000.0, "1 porsiyon, 3 tatlı kaşığı, 30 gram", "Pekmez", 8 },
                    { 95, 68000.0, "1 porsiyon, 3 tatlı kaşığı, 30 gram", "Marmelat", 8 },
                    { 94, 68000.0, "1 porsiyon, 3 tatlı kaşığı, 30 gram", "Reçel", 8 },
                    { 93, 68000.0, "1 porsiyon, 1 yemek kaşığı, 30 gram", "Bal", 8 },
                    { 92, 45000.0, "1 porsiyon, 1 tatlı kaşığı, 5 gram", "Tereyağ", 7 },
                    { 78, 60000.0, "1 porsiyon, 5 Adet, 20 gram", "Kuru Erik", 6 },
                    { 91, 45000.0, "1 porsiyon, 1 tatlı kaşığı, 5 gram", "Bitkisel sıvıyağ", 7 },
                    { 89, 45000.0, "1 porsiyon, 5 adet, 15 gram", "Zeytin", 7 },
                    { 88, 106000.0, "1 porsiyon, 1 bardak, 200 ml", "Nar Suyu", 6 },
                    { 87, 120000.0, "1 porsiyon, 1 bardak, 200 ml", "Portakal Suyu", 6 }
                });

            migrationBuilder.InsertData(
                table: "YemekBilgileri",
                columns: new[] { "Id", "Calorie", "MealDescription", "MealName", "TypeMealId" },
                values: new object[,]
                {
                    { 86, 98000.0, "1 porsiyon, 1 bardak, 200 ml", "Elma Suyu", 6 },
                    { 85, 99000.0, "1 porsiyon, 1 bardak, 200 ml", "Vişne Suyu", 6 },
                    { 84, 60000.0, "1 porsiyon, 1 ince dilim, 200 gram", "Karpuz", 6 },
                    { 83, 60000.0, "1 porsiyon, 1 ince dilim, 200 gram", "Kavun", 6 },
                    { 82, 60000.0, "1 porsiyon, 1 orta boy, 120 gram", "Şeftali", 6 },
                    { 81, 60000.0, "1 porsiyon, 15 adet küçük , 150 gram", "Çilek", 6 },
                    { 80, 60000.0, "1 porsiyon, 3 adet, 20 gram", "Hurma", 6 },
                    { 90, 45000.0, "1 porsiyon, 1 tatlı kaşığı , 5 gram", "Zeytinyağı", 7 },
                    { 102, 68000.0, "1 porsiyon, 7 adet, 10 gram", "Fındık içi", 9 },
                    { 52, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Pazı(Pişmiş)", 5 },
                    { 50, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Mantar", 5 },
                    { 23, 69000.0, "1 porsiyon, 1 köfte kadar, 30 gram", "Balık", 2 },
                    { 22, 69000.0, "1 porsiyon, 1 adet, 50 gram", "Yumurta", 2 },
                    { 21, 69000.0, "1 porsiyon, 1 köfte kadar, 30 gram", "Tavuk-Hindi", 2 },
                    { 20, 69000.0, "1 porsiyon, 1 küçük boy, 30 gram", "Bonfile", 2 },
                    { 19, 69000.0, "1 porsiyon, 4 adet, 30 gram", "Kuşbaşı", 2 },
                    { 18, 69000.0, "1 porsiyon, 1 avuç büyüklükte, 30 gram", "Köfte", 2 },
                    { 17, 69000.0, "1 porsiyon, 1 köfte kadar, 30 gram", "Kıyma", 2 },
                    { 16, 69000.0, "1 porsiyon, 1 kibrit kutusu, 30 gram", "Mozarella", 1 },
                    { 15, 69000.0, "1 porsiyon, 1 kibrit kutusu, 30 gram", "Hellim Peyniri", 1 },
                    { 14, 97000.0, "1 porsiyon, 1 kibrit kutusu, 30 gram", "Otlu Peynir", 1 },
                    { 24, 69000.0, "1 porsiyon, 1 yemek kaşığı, 30 gram", "Ton Balığı", 2 },
                    { 13, 69000.0, "1 porsiyon, 2 adet, 50 gram", "Üçgen Karper Peynir", 1 },
                    { 11, 69000.0, "1 porsiyon, 3 yemek kaşığı, 70 gram", "Yağsız Lor Peyniri", 1 },
                    { 10, 69000.0, "1 porsiyon, 1 kibrit kutusu, 30 gram", "Dil Peyniri", 1 },
                    { 9, 120000.0, "1 porsiyon, 1 kibrit kutusu, 30 gram", "Kaşar Peyniri", 1 },
                    { 8, 69000.0, "1 porsiyon, 1 kibrit kutusu, 30 gram", "Labne Peyniri", 1 },
                    { 7, 69000.0, "1 porsiyon, 1 kibrit kutusu, 30 gram", "Beyaz Peynir", 1 },
                    { 6, 57000.0, "1 porsiyon, 1 kutu, 125 gram", "Probiyotik Yoğurt", 1 },
                    { 5, 114000.0, "1 porsiyon, 1 su bardağı, 200 ml", "Kefir", 1 },
                    { 4, 57000.0, "1 porsiyon, 1 su bardağı, 200 ml", "Ayran", 1 },
                    { 3, 114000.0, "1 porsiyon, 2 yemek kaşığı, 50 gram", "Süzme Yoğurt", 1 },
                    { 2, 114000.0, "1 porsiyon, 1 kase, 200 gram", "Yoğurt", 1 },
                    { 12, 69000.0, "1 porsiyon, 1 yemek kaşığı, 70 gram", "Tulum Peyniri", 1 },
                    { 51, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Patlıcan(Pişmiş)", 5 },
                    { 25, 69000.0, "1 porsiyon, 5 ince halka, 30 gram", "Sucuk", 2 },
                    { 27, 69000.0, "1 porsiyon, 3 dilim, 40 gram", "Hindi/Piliç Jambon", 2 },
                    { 49, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Lahana(Pişmiş)", 5 },
                    { 48, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Karnabahar(Pişmiş)", 5 },
                    { 47, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Ispanak(Pişmiş)", 5 },
                    { 46, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Ebegümeci(Pişmiş)", 5 },
                    { 45, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Brokoli(Pişmiş)", 5 }
                });

            migrationBuilder.InsertData(
                table: "YemekBilgileri",
                columns: new[] { "Id", "Calorie", "MealDescription", "MealName", "TypeMealId" },
                values: new object[,]
                {
                    { 44, 25000.0, "1 porsiyon, 4 yemek kaşığı , 200 gram", "Bamya(Pişmiş)", 5 },
                    { 43, 68000.0, "1 porsiyon, 2-3 orta boy , 45 gram", "Kestane", 4 },
                    { 42, 68000.0, "1 porsiyon, 1/3 Adet , 25 gram", "Simit(susamlı)", 4 },
                    { 41, 68000.0, "1 porsiyon, 7 Adet , 20 gram", "Galeta sade(Küçük)", 4 },
                    { 40, 68000.0, "1 porsiyon, 1.5 Adet , 20 gram", "Galeta sade(Büyük)", 4 },
                    { 26, 69000.0, "1 porsiyon, 2 ince dilim, 30 gram", "Pastırma", 2 },
                    { 39, 68000.0, "1 porsiyon, 1 Su Bardağı , 20 gram", "Patlamış Mısır(yağsız)", 4 },
                    { 37, 68000.0, "1 porsiyon, 2 yemek kaşığı, 40 gram", "Haşlanmış Tane Mısır", 4 },
                    { 36, 68000.0, "1 porsiyon, 1 küçük boy, 90 gram", "Haşlanmış Patates", 4 },
                    { 35, 68000.0, "1 porsiyon, 3 yemek kaşığı, 50 gram", "Makarna/Erişte", 4 },
                    { 34, 68000.0, "1 porsiyon, 3 yemek kaşığı, 50 gram", "Pirinç/Bulgur pilavı", 4 },
                    { 33, 68000.0, "1 porsiyon, 1 küçük kase, 160 gram", "Çorba", 4 },
                    { 32, 68000.0, "1 porsiyon, 1 ince dilim, 25 gram", "Ekmek(kepek,buğday,çavdar,mısır)", 4 },
                    { 31, 80000.0, "1 porsiyon, 4 yemek kaşığı, 25 gram", "Barbunya", 3 },
                    { 30, 80000.0, "1 porsiyon, 4 yemek kaşığı, 25 gram", "Mercimek", 3 },
                    { 29, 80000.0, "1 porsiyon, 4 yemek kaşığı, 25 gram", "Kurufasulye", 3 },
                    { 28, 80000.0, "1 porsiyon, 4 yemek kaşığı, 25 gram", "Nohut", 3 },
                    { 38, 103000.0, "1 porsiyon, 1 Kase , 30 gram", "Kahvaltılık Gevrek", 4 },
                    { 103, 68000.0, "1 porsiyon, 7 adet, 10 gram", "Fıstık içi", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgunBilgileri_UserId",
                table: "OgunBilgileri",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OgunYemek_RepastId",
                table: "OgunYemek",
                column: "RepastId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekBilgileri_TypeMealId",
                table: "YemekBilgileri",
                column: "TypeMealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciBilgileri");

            migrationBuilder.DropTable(
                name: "OgunYemek");

            migrationBuilder.DropTable(
                name: "OgunBilgileri");

            migrationBuilder.DropTable(
                name: "YemekBilgileri");

            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "YemekGruplari");
        }
    }
}
