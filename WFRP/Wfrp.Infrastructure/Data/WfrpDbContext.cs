using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Wfrp.Domain.Entities;

namespace Wfrp.Infrastructure.Data
{
    public class WfrpDbContext : DbContext
    {
        public WfrpDbContext(DbContextOptions<WfrpDbContext> options) : base(options) { }

        // DbSets
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<Race> Races => Set<Race>();
        public DbSet<Skill> Skills => Set<Skill>();
        public DbSet<SkillSpecialization> SkillSpecializations { get; set; }
        public DbSet<Talent> Talents => Set<Talent>();
        public DbSet<Career> Careers => Set<Career>();
        public DbSet<CareerClass> CareerClasses => Set<CareerClass>();
        public DbSet<CareerLevel> CareerLevels => Set<CareerLevel>();
        public DbSet<Item> Items => Set<Item>();
        public DbSet<Weapon> Weapons => Set<Weapon>();
        public DbSet<Quality> Qualities => Set<Quality>();
        public DbSet<Flaw> Flaws => Set<Flaw>();
        public DbSet<ItemQuality> ItemQualities => Set<ItemQuality>();
        public DbSet<ItemFlaw> ItemFlaws => Set<ItemFlaw>();
        public DbSet<Armor> Armors => Set<Armor>();
        public DbSet<Gear> Gears => Set<Gear>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Character embedded objects
            modelBuilder.Entity<Character>().OwnsOne(c => c.InitialCharacteristics);
            modelBuilder.Entity<Character>().OwnsOne(c => c.AdvancesCharacteristics);

            // Composite keys for join tables
            modelBuilder.Entity<CharacterSkill>().HasKey(characterSkill => new { characterSkill.CharacterId, characterSkill.SkillId });
            modelBuilder.Entity<CharacterTalent>().HasKey(characterTalent => new { characterTalent.CharacterId, characterTalent.TalentId });
            modelBuilder.Entity<CharacterItem>().HasKey(characterItem => new { characterItem.CharacterId, characterItem.ItemId });
            modelBuilder.Entity<CharacterCareer>().HasKey(characterCareer => new { characterCareer.CharacterId, characterCareer.CareerId });
            modelBuilder.Entity<RaceSkill>().HasKey(raceSkill => new { raceSkill.RaceId, raceSkill.SkillId });
            modelBuilder.Entity<RaceTalent>().HasKey(raceTalent => new { raceTalent.RaceId, raceTalent.TalentId });
            modelBuilder.Entity<CareerLevelSkill>().HasKey(careerLevelSkill => new { careerLevelSkill.CareerLevelId, careerLevelSkill.SkillId });
            modelBuilder.Entity<CareerLevelTalent>().HasKey(careerLevelTalent => new { careerLevelTalent.CareerLevelId, careerLevelTalent.TalentId });

            // Item inheritance
            modelBuilder.Entity<Item>()
                .HasDiscriminator<string>("ItemType")
                .HasValue<Weapon>("Weapon")
                .HasValue<Armor>("Armor")
                .HasValue<Gear>("Gear");

            // Value conversion for CanAdvanceCharacteristics (List<CharacteristicType>)
            modelBuilder.Entity<CareerLevel>()
                .Property(careerLevel => careerLevel.CanAdvanceCharacteristics)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(e => Enum.Parse<CharacteristicType>(e)).ToList()
                )
                .Metadata.SetValueComparer(
                    new ValueComparer<List<CharacteristicType>>(
                        (c1, c2) => c1.SequenceEqual(c2),
                        c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                        c => c.ToList()
                    ));

            // ItemQuality configuration
            modelBuilder.Entity<ItemQuality>()
                .HasKey(itemQuality => new { itemQuality.ItemId, itemQuality.QualityId });

            modelBuilder.Entity<ItemQuality>()
                .HasOne(itemQuality => itemQuality.Item)
                .WithMany(item => item.Qualities)
                .HasForeignKey(itemQuality => itemQuality.ItemId);

            modelBuilder.Entity<ItemQuality>()
                .HasOne(itemQuality => itemQuality.Quality)
                .WithMany()
                .HasForeignKey(itemQuality => itemQuality.QualityId);

            // ItemFlaw configuration
            modelBuilder.Entity<ItemFlaw>()
                .HasKey(itemFlow => new { itemFlow.ItemId, itemFlow.FlawId });

            modelBuilder.Entity<ItemFlaw>()
                .HasOne(itemFlow => itemFlow.Item)
                .WithMany(item => item.Flaws)
                .HasForeignKey(itemFlow => itemFlow.ItemId);

            modelBuilder.Entity<ItemFlaw>()
                .HasOne(itemFlow => itemFlow.Flaw)
                .WithMany()
                .HasForeignKey(itemFlow => itemFlow.FlawId);

            // SkillSpecialization configuration
            modelBuilder.Entity<Skill>()
                .HasMany(s => s.Specializations)
                .WithOne(sp => sp.Skill)
                .HasForeignKey(sp => sp.SkillId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
