using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Wfrp.Domain.Entities;

namespace Wfrp.Infrastructure.Data
{
    public class WfrpDbContext : DbContext
    {
        public WfrpDbContext(DbContextOptions<WfrpDbContext> options) : base(options) { }

        public DbSet<Character> Characters => Set<Character>();
        public DbSet<Race> Races => Set<Race>();
        public DbSet<Career> Careers => Set<Career>();
        public DbSet<CareerLevel> CareerLevels => Set<CareerLevel>();
        public DbSet<Skill> Skills => Set<Skill>();
        public DbSet<Talent> Talents => Set<Talent>();
        public DbSet<Item> Items => Set<Item>();
        public DbSet<Weapon> Weapons => Set<Weapon>();
        public DbSet<Armor> Armors => Set<Armor>();
        public DbSet<Gear> Gears => Set<Gear>();

        public DbSet<CharacterCareer> CharacterCareers => Set<CharacterCareer>();
        public DbSet<CharacterSkill> CharacterSkills => Set<CharacterSkill>();
        public DbSet<CharacterTalent> CharacterTalents => Set<CharacterTalent>();
        public DbSet<CharacterItem> CharacterItems => Set<CharacterItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Owned Types
            modelBuilder.Entity<Character>().OwnsOne(c => c.InitialCharacteristics);
            modelBuilder.Entity<Character>().OwnsOne(c => c.AdvancesCharacteristics);
            modelBuilder.Entity<Race>().OwnsOne(r => r.BaseCharacteristics);

            // CharacterCareer
            modelBuilder.Entity<CharacterCareer>()
                .HasKey(cc => new { cc.CharacterId, cc.CareerId });

            modelBuilder.Entity<CharacterCareer>()
                .HasOne(cc => cc.Character)
                .WithMany(c => c.Careers)
                .HasForeignKey(cc => cc.CharacterId);

            modelBuilder.Entity<CharacterCareer>()
                .HasOne(cc => cc.Career)
                .WithMany()
                .HasForeignKey(cc => cc.CareerId);

            // CharacterSkill
            modelBuilder.Entity<CharacterSkill>()
                .HasKey(cs => new { cs.CharacterId, cs.SkillId });

            modelBuilder.Entity<CharacterSkill>()
                .HasOne(cs => cs.Character)
                .WithMany(c => c.Skills)
                .HasForeignKey(cs => cs.CharacterId);

            modelBuilder.Entity<CharacterSkill>()
                .HasOne(cs => cs.Skill)
                .WithMany()
                .HasForeignKey(cs => cs.SkillId);

            // CharacterTalent
            modelBuilder.Entity<CharacterTalent>()
                .HasKey(ct => new { ct.CharacterId, ct.TalentId });

            modelBuilder.Entity<CharacterTalent>()
                .HasOne(ct => ct.Character)
                .WithMany(c => c.Talents)
                .HasForeignKey(ct => ct.CharacterId);

            modelBuilder.Entity<CharacterTalent>()
                .HasOne(ct => ct.Talent)
                .WithMany()
                .HasForeignKey(ct => ct.TalentId);

            // CharacterItem
            modelBuilder.Entity<CharacterItem>()
                .HasKey(ci => new { ci.CharacterId, ci.ItemId });

            modelBuilder.Entity<CharacterItem>()
                .HasOne(ci => ci.Character)
                .WithMany(c => c.Inventory)
                .HasForeignKey(ci => ci.CharacterId);

            modelBuilder.Entity<CharacterItem>()
                .HasOne(ci => ci.Item)
                .WithMany()
                .HasForeignKey(ci => ci.ItemId);

            // CareerLevel - CanAdvanceCharacteristics as Enum Collection
            modelBuilder.Entity<CareerLevel>()
                .Property(cl => cl.CanAdvanceCharacteristics)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                          .Select(Enum.Parse<CharacteristicType>)
                          .ToList()
                )
                .Metadata.SetValueComparer(
                    new ValueComparer<List<CharacteristicType>>(
                        (c1, c2) => c1.SequenceEqual(c2),
                        c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                        c => c.ToList()
                    )
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
