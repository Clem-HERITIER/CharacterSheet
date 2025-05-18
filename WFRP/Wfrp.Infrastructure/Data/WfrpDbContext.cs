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
        public DbSet<Talent> Talents => Set<Talent>();
        public DbSet<Career> Careers => Set<Career>();
        public DbSet<CareerClass> CareerClasses => Set<CareerClass>();
        public DbSet<CareerLevel> CareerLevels => Set<CareerLevel>();
        public DbSet<Item> Items => Set<Item>();
        public DbSet<Weapon> Weapons => Set<Weapon>();
        public DbSet<Quality> Qualities => Set<Quality>();
        public DbSet<Flaw> Flaws => Set<Flaw>();
        public DbSet<WeaponQuality> WeaponQualities => Set<WeaponQuality>();
        public DbSet<WeaponFlaw> WeaponFlaws => Set<WeaponFlaw>();
        public DbSet<Armor> Armors => Set<Armor>();
        public DbSet<Gear> Gears => Set<Gear>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Character embedded objects
            modelBuilder.Entity<Character>().OwnsOne(c => c.InitialCharacteristics);
            modelBuilder.Entity<Character>().OwnsOne(c => c.AdvancesCharacteristics);

            // Composite keys for join tables
            modelBuilder.Entity<CharacterSkill>().HasKey(cs => new { cs.CharacterId, cs.SkillId });
            modelBuilder.Entity<CharacterTalent>().HasKey(ct => new { ct.CharacterId, ct.TalentId });
            modelBuilder.Entity<CharacterItem>().HasKey(ci => new { ci.CharacterId, ci.ItemId });
            modelBuilder.Entity<CharacterCareer>().HasKey(cc => new { cc.CharacterId, cc.CareerId });
            modelBuilder.Entity<RaceSkill>().HasKey(rs => new { rs.RaceId, rs.SkillId });
            modelBuilder.Entity<RaceTalent>().HasKey(rt => new { rt.RaceId, rt.TalentId });
            modelBuilder.Entity<CareerLevelSkill>().HasKey(cls => new { cls.CareerLevelId, cls.SkillId });
            modelBuilder.Entity<CareerLevelTalent>().HasKey(clt => new { clt.CareerLevelId, clt.TalentId });

            // Item inheritance
            modelBuilder.Entity<Item>()
                .HasDiscriminator<string>("ItemType")
                .HasValue<Weapon>("Weapon")
                .HasValue<Armor>("Armor")
                .HasValue<Gear>("Gear");

            // Value conversion for CanAdvanceCharacteristics (List<CharacteristicType>)
            modelBuilder.Entity<CareerLevel>()
                .Property(cl => cl.CanAdvanceCharacteristics)
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

            // WeaponQuality configuration
            modelBuilder.Entity<WeaponQuality>()
                .HasKey(wq => new { wq.WeaponId, wq.QualityId });

            modelBuilder.Entity<WeaponQuality>()
                .HasOne(wq => wq.Weapon)
                .WithMany(w => w.Qualities)
                .HasForeignKey(wq => wq.WeaponId);

            modelBuilder.Entity<WeaponQuality>()
                .HasOne(wq => wq.Quality)
                .WithMany()
                .HasForeignKey(wq => wq.QualityId);

            // WeaponFlaw configuration
            modelBuilder.Entity<WeaponFlaw>()
                .HasKey(wf => new { wf.WeaponId, wf.FlawId });

            modelBuilder.Entity<WeaponFlaw>()
                .HasOne(wf => wf.Weapon)
                .WithMany(w => w.Flaws)
                .HasForeignKey(wf => wf.WeaponId);

            modelBuilder.Entity<WeaponFlaw>()
                .HasOne(wf => wf.Flaw)
                .WithMany()
                .HasForeignKey(wf => wf.FlawId);
        }
    }
}
