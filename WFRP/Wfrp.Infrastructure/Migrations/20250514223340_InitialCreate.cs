using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wfrp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CareerClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true),
                    ArmorPoints = table.Column<int>(type: "integer", nullable: true),
                    IsConsumable = table.Column<bool>(type: "boolean", nullable: true),
                    Damage = table.Column<int>(type: "integer", nullable: true),
                    Reach = table.Column<string>(type: "text", nullable: true),
                    Qualities = table.Column<string>(type: "text", nullable: true),
                    Flaws = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BaseCharacteristics_WeaponSkill = table.Column<int>(type: "integer", nullable: false),
                    BaseCharacteristics_BallisticSkill = table.Column<int>(type: "integer", nullable: false),
                    BaseCharacteristics_Strength = table.Column<int>(type: "integer", nullable: false),
                    BaseCharacteristics_Toughness = table.Column<int>(type: "integer", nullable: false),
                    BaseCharacteristics_Initiative = table.Column<int>(type: "integer", nullable: false),
                    BaseCharacteristics_Agility = table.Column<int>(type: "integer", nullable: false),
                    BaseCharacteristics_Dexterity = table.Column<int>(type: "integer", nullable: false),
                    BaseCharacteristics_Intelligence = table.Column<int>(type: "integer", nullable: false),
                    BaseCharacteristics_Willpower = table.Column<int>(type: "integer", nullable: false),
                    BaseCharacteristics_Fellowship = table.Column<int>(type: "integer", nullable: false),
                    Movement = table.Column<int>(type: "integer", nullable: false),
                    FatePoints = table.Column<int>(type: "integer", nullable: false),
                    ResiliencePoints = table.Column<int>(type: "integer", nullable: false),
                    ExtraPoints = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Talents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Careers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CareerClassId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Careers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Careers_CareerClass_CareerClassId",
                        column: x => x.CareerClassId,
                        principalTable: "CareerClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RaceId = table.Column<Guid>(type: "uuid", nullable: false),
                    InitialCharacteristics_WeaponSkill = table.Column<int>(type: "integer", nullable: false),
                    InitialCharacteristics_BallisticSkill = table.Column<int>(type: "integer", nullable: false),
                    InitialCharacteristics_Strength = table.Column<int>(type: "integer", nullable: false),
                    InitialCharacteristics_Toughness = table.Column<int>(type: "integer", nullable: false),
                    InitialCharacteristics_Initiative = table.Column<int>(type: "integer", nullable: false),
                    InitialCharacteristics_Agility = table.Column<int>(type: "integer", nullable: false),
                    InitialCharacteristics_Dexterity = table.Column<int>(type: "integer", nullable: false),
                    InitialCharacteristics_Intelligence = table.Column<int>(type: "integer", nullable: false),
                    InitialCharacteristics_Willpower = table.Column<int>(type: "integer", nullable: false),
                    InitialCharacteristics_Fellowship = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_WeaponSkill = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_BallisticSkill = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_Strength = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_Toughness = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_Initiative = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_Agility = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_Dexterity = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_Intelligence = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_Willpower = table.Column<int>(type: "integer", nullable: false),
                    AdvancesCharacteristics_Fellowship = table.Column<int>(type: "integer", nullable: false),
                    FatePoints = table.Column<int>(type: "integer", nullable: false),
                    ResiliencePoints = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CareerLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    CareerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CanAdvanceCharacteristics = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CareerLevels_Careers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterCareers",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false),
                    CareerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterCareers", x => new { x.CharacterId, x.CareerId });
                    table.ForeignKey(
                        name: "FK_CharacterCareers_Careers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterCareers_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterItems",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterItems", x => new { x.CharacterId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_CharacterItems_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    AcquiredAtLevel = table.Column<int>(type: "integer", nullable: false),
                    XPSpent = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkills", x => new { x.CharacterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTalents",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false),
                    TalentId = table.Column<Guid>(type: "uuid", nullable: false),
                    AcquiredAtLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTalents", x => new { x.CharacterId, x.TalentId });
                    table.ForeignKey(
                        name: "FK_CharacterTalents_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTalents_Talents_TalentId",
                        column: x => x.TalentId,
                        principalTable: "Talents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareerLevels_CareerId",
                table: "CareerLevels",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_Careers_CareerClassId",
                table: "Careers",
                column: "CareerClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterCareers_CareerId",
                table: "CharacterCareers",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItems_ItemId",
                table: "CharacterItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_SkillId",
                table: "CharacterSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTalents_TalentId",
                table: "CharacterTalents",
                column: "TalentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareerLevels");

            migrationBuilder.DropTable(
                name: "CharacterCareers");

            migrationBuilder.DropTable(
                name: "CharacterItems");

            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropTable(
                name: "CharacterTalents");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Talents");

            migrationBuilder.DropTable(
                name: "CareerClass");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
