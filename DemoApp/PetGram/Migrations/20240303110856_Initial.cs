using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PetGram.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HealthIssue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Suggestion = table.Column<string>(type: "text", nullable: false),
                    IsCritical = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthIssue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Breed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    OriginCountry = table.Column<string>(type: "text", nullable: false),
                    Size = table.Column<int>(type: "integer", nullable: false),
                    LifeSpan = table.Column<int>(type: "integer", nullable: false),
                    TemperamentDescription = table.Column<string>(type: "text", nullable: false),
                    SpeciesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Breed_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BreedHealthIssue",
                columns: table => new
                {
                    BreedsId = table.Column<int>(type: "integer", nullable: false),
                    HealthIssuesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedHealthIssue", x => new { x.BreedsId, x.HealthIssuesId });
                    table.ForeignKey(
                        name: "FK_BreedHealthIssue_Breed_BreedsId",
                        column: x => x.BreedsId,
                        principalTable: "Breed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BreedHealthIssue_HealthIssue_HealthIssuesId",
                        column: x => x.HealthIssuesId,
                        principalTable: "HealthIssue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NickName = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    BreedId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pet_Breed_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Breed_SpeciesId",
                table: "Breed",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_BreedHealthIssue_HealthIssuesId",
                table: "BreedHealthIssue",
                column: "HealthIssuesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_BreedId",
                table: "Pet",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_NickName",
                table: "Pet",
                column: "NickName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreedHealthIssue");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "HealthIssue");

            migrationBuilder.DropTable(
                name: "Breed");

            migrationBuilder.DropTable(
                name: "Species");
        }
    }
}
