namespace Mersy.Infraestructure
{
    using Domain.Entities.Cor;
    using EntityConfigurations;
    using EntityConfigurations.Cor;
    using Infraestructure.Extensions;
    using Mersy.Common.Entities;
    using Mersy.Common.Helpers;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    // public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole, string>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly ICurrentUserFactory _currentUser;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ICurrentUserFactory currentUser = null) : base(options)
        {
            _currentUser = currentUser;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserShop>(entity =>
            //{
            //    entity.HasOne(n => n.Shop)
            //        .WithMany(u => u.UserShops)
            //        .HasForeignKey(x => x.ShopId)
            //        .IsRequired();

            //    entity.HasOne(n => n.AppUser)
            //        .WithMany(u => u.UserShops)
            //        .HasForeignKey(x => x.AppUserId)
            //        .IsRequired();

            //    entity.HasOne(n => n.CreatedUser);


            //    entity.HasOne(n => n.DeletedUser);


            //    entity.HasOne(n => n.UpdatedUser);

            //});

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
            AddMyFilters(ref modelBuilder);
            modelBuilder.ApplyConfiguration(new ApplicationUserConfig());
            //registering the configurations for all the classes
            //new ApplicationUserConfig(modelBuilder.Entity<ApplicationUser>());
            new OwnerConfig(modelBuilder.Entity<Owner>());
            //new ShopConfig(modelBuilder.Entity<Shop>());

        }

        public DbSet<LotteryFrom> LotteryFroms { get; set; }
        //  public DbSet<UserShop> UserShops { get; set; }
        // public DbSet<LotteryPayment> LotteryPayments { get; set; }

        //public DbSet<LotteryDayLimit> LotteryDayLimits { get; set; }

        // public DbSet<LotteryPlayedNumber> LotteryPlayedNumbers { get; set; }
        //public DbSet<LotteryGlobalLimit> LotteryGlobalLimits { get; set; }
        //public DbSet<LotteryNumberLimit> LotteryNumberLimits { get; set; }
        //public DbSet<LotteryIndividualLimit> LotteryIndividualLimits { get; set; }
        //public DbSet<LotteryUserLimit> LotteryUserLimits { get; set; }

          public DbSet<PrizePayment> PrizePayments { get; set; }
       
        public DbSet<LotterySale> LotterySales { get; set; }
        public DbSet<LotterySaleItem> LotterySaleItems { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionModule> OptionModules { get; set; }
        public DbSet<LotterySchedule> LotterySchedules { get; set; }
        //public DbSet<LotteryAvailable> LotteryAvailables { get; set; }
        public DbSet<LotteryResult> LotteryResults { get; set; }
        public DbSet<Lottery> Lotteries { get; set; }
        public DbSet<LotteryMode> LotteryModes { get; set; }
        //public DbSet<LotteryPrize> LotteryPrizes { get; set; }
     
        public DbSet<OwnerType> OwnerTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
       
        public DbSet<OwnerPlan> OwnerPlans { get; set; }
        public DbSet<Periodicity> Periodicities { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanTransaction> PlanTransactions { get; set; }
         
        public DbSet<Owner> Owners { get; set; }
         
        public DbSet<PaymentType> PaymentTypes { get; set; }
       
        public DbSet<Payment> Payments { get; set; }


        public DbSet<Status> Status { get; set; }


        public override int SaveChanges()
        {
            MakeAudit();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            MakeAudit();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            MakeAudit();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void MakeAudit()
        {
            var modifiedEntries = ChangeTracker.Entries().Where(
                x => x.Entity is AuditEntity
                    && (
                    x.State == EntityState.Added
                    || x.State == EntityState.Modified
                )
            );

            var user = new CurrentUser();

            if (_currentUser != null)
            {
                user = _currentUser.Get;
            }

            foreach (var entry in modifiedEntries)
            {
                if (entry.Entity is AuditEntity entity)
                {
                    //var date = DateTime.Now;
                    var date = DateTime.UtcNow;
                    string userId = user.UserId;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedAt = date;
                        entity.CreatedBy = userId;
                    }
                    else if (entity is ISoftDeleted && ((ISoftDeleted)entity).Deleted)
                    {
                        entity.DeletedAt = date;
                        entity.DeletedBy = userId;
                    }

                    Entry(entity).Property(x => x.CreatedAt).IsModified = false;
                    Entry(entity).Property(x => x.CreatedBy).IsModified = false;

                    entity.UpdatedAt = date;
                    entity.UpdatedBy = userId;
                }
            }
        }

        private void AddMyFilters(ref ModelBuilder modelBuilder)
        {
            var user = new CurrentUser();

            if (_currentUser != null)
            {
                user = _currentUser.Get;

            }

            #region SoftDeleted

            modelBuilder.Entity<ApplicationUser>().HasQueryFilter(x => !x.IsDisabled);

            modelBuilder.Entity<PrizePayment>().HasQueryFilter(x => !x.Deleted);   
            modelBuilder.Entity<LotterySale>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<LotterySaleItem>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<LotterySchedule>().HasQueryFilter(x => !x.Deleted);
            modelBuilder.Entity<LotteryResult>().HasQueryFilter(x => !x.Deleted); 
            modelBuilder.Entity<Payment>().HasQueryFilter(x => !x.Deleted); 

            #endregion
        }

    }
}
