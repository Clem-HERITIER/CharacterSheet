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
                name: "CareerClasses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    Value = table.Column<int>(type: "integer", nullable: false),
                    ItemType = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true),
                    ArmorPoints = table.Column<int>(type: "integer", nullable: true),
                    Qualities = table.Column<string>(type: "text", nullable: true),
                    Flaws = table.Column<string>(type: "text", nullable: true),
                    IsConsumable = table.Column<bool>(type: "boolean", nullable: true),
                    Effect = table.Column<string>(type: "text", nullable: true),
                    WeaponType = table.Column<string>(type: "text", nullable: true),
                    Damage = table.Column<string>(type: "text", nullable: true),
                    Reach = table.Column<string>(type: "text", nullable: true),
                    Weapon_Qualities = table.Column<string>(type: "text", nullable: true),
                    Weapon_Flaws = table.Column<string>(type: "text", nullable: true)
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
                    Name = table.Column<string>(type: "text", nullable: false),
                    Characteristic = table.Column<int>(type: "integer", nullable: false),
                    Specialization = table.Column<string>(type: "text", nullable: true),
                    IsAdvanced = table.Column<bool>(type: "boolean", nullable: false)
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
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CanBeRanked = table.Column<bool>(type: "boolean", nullable: false)
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
                        name: "FK_Careers_CareerClasses_CareerClassId",
                        column: x => x.CareerClassId,
                        principalTable: "CareerClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceSkill",
                columns: table => new
                {
                    RaceId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    InitialLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceSkill", x => new { x.RaceId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_RaceSkill_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceSkill_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceTalent",
                columns: table => new
                {
                    RaceId = table.Column<Guid>(type: "uuid", nullable: false),
                    TalentId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsOptional = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceTalent", x => new { x.RaceId, x.TalentId });
                    table.ForeignKey(
                        name: "FK_RaceTalent_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceTalent_Talents_TalentId",
                        column: x => x.TalentId,
                        principalTable: "Talents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CareerLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    CareerId = table.Column<Guid>(type: "uuid", nullable: false),
                    StatusTier = table.Column<int>(type: "integer", nullable: false),
                    StatusLevel = table.Column<int>(type: "integer", nullable: false),
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
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Height = table.Column<int>(type: "integer", nullable: false),
                    EyeColor = table.Column<string>(type: "text", nullable: false),
                    HairColor = table.Column<string>(type: "text", nullable: false),
                    FatePoints = table.Column<int>(type: "integer", nullable: false),
                    ResiliencePoints = table.Column<int>(type: "integer", nullable: false),
                    Wounds = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ShortTermAmbition = table.Column<string>(type: "text", nullable: false),
                    LongTermAmbition = table.Column<string>(type: "text", nullable: false),
                    Psychology = table.Column<string>(type: "text", nullable: false),
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
                    CurrentCareerId = table.Column<Guid>(type: "uuid", nullable: true),
                    CareerLevel = table.Column<int>(type: "integer", nullable: false),
                    ExperienceTotal = table.Column<int>(type: "integer", nullable: false),
                    ExperienceSpent = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Careers_CurrentCareerId",
                        column: x => x.CurrentCareerId,
                        principalTable: "Careers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CareerLevelSkill",
                columns: table => new
                {
                    CareerLevelId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerLevelSkill", x => new { x.CareerLevelId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CareerLevelSkill_CareerLevels_CareerLevelId",
                        column: x => x.CareerLevelId,
                        principalTable: "CareerLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareerLevelSkill_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CareerLevelTalent",
                columns: table => new
                {
                    CareerLevelId = table.Column<Guid>(type: "uuid", nullable: false),
                    TalentId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsOptional = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerLevelTalent", x => new { x.CareerLevelId, x.TalentId });
                    table.ForeignKey(
                        name: "FK_CareerLevelTalent_CareerLevels_CareerLevelId",
                        column: x => x.CareerLevelId,
                        principalTable: "CareerLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareerLevelTalent_Talents_TalentId",
                        column: x => x.TalentId,
                        principalTable: "Talents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterCareer",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false),
                    CareerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterCareer", x => new { x.CharacterId, x.CareerId });
                    table.ForeignKey(
                        name: "FK_CharacterCareer_Careers_CareerId",
                        column: x => x.CareerId,
                        principalTable: "Careers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterCareer_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterItem",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterItem", x => new { x.CharacterId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_CharacterItem_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkill",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false),
                    SkillId = table.Column<Guid>(type: "uuid", nullable: false),
                    AcquiredAtLevel = table.Column<int>(type: "integer", nullable: false),
                    XPSpent = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkill", x => new { x.CharacterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CharacterSkill_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkill_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTalent",
                columns: table => new
                {
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false),
                    TalentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Rank = table.Column<int>(type: "integer", nullable: false),
                    AcquiredAtLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTalent", x => new { x.CharacterId, x.TalentId });
                    table.ForeignKey(
                        name: "FK_CharacterTalent_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTalent_Talents_TalentId",
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
                name: "IX_CareerLevelSkill_SkillId",
                table: "CareerLevelSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CareerLevelTalent_TalentId",
                table: "CareerLevelTalent",
                column: "TalentId");

            migrationBuilder.CreateIndex(
                name: "IX_Careers_CareerClassId",
                table: "Careers",
                column: "CareerClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterCareer_CareerId",
                table: "CharacterCareer",
                column: "CareerId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItem_ItemId",
                table: "CharacterItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CurrentCareerId",
                table: "Characters",
                column: "CurrentCareerId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_SkillId",
                table: "CharacterSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTalent_TalentId",
                table: "CharacterTalent",
                column: "TalentId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceSkill_SkillId",
                table: "RaceSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceTalent_TalentId",
                table: "RaceTalent",
                column: "TalentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CareerLevelSkill");

            migrationBuilder.DropTable(
                name: "CareerLevelTalent");

            migrationBuilder.DropTable(
                name: "CharacterCareer");

            migrationBuilder.DropTable(
                name: "CharacterItem");

            migrationBuilder.DropTable(
                name: "CharacterSkill");

            migrationBuilder.DropTable(
                name: "CharacterTalent");

            migrationBuilder.DropTable(
                name: "RaceSkill");

            migrationBuilder.DropTable(
                name: "RaceTalent");

            migrationBuilder.DropTable(
                name: "CareerLevels");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Talents");

            migrationBuilder.DropTable(
                name: "Careers");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "CareerClasses");
        }
    }
}
