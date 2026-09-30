using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data;

public class DatabaseTaskDbContext : DbContext
{
    public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
        : base(options)
    {
    }

    public DbSet<GroupType> GroupTypes => Set<GroupType>();
    public DbSet<Group> Groups => Set<Group>();
    public DbSet<Child> Children => Set<Child>();
    public DbSet<WaitingList> WaitingLists => Set<WaitingList>();
    public DbSet<ChildGroupAssignment> ChildGroupAssignments => Set<ChildGroupAssignment>();
    public DbSet<ChildAbsence> ChildAbsences => Set<ChildAbsence>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Position> Positions => Set<Position>();
    public DbSet<GroupStaffAssignment> GroupStaffAssignments => Set<GroupStaffAssignment>();
    public DbSet<KitchenStaffAssignment> KitchenStaffAssignments => Set<KitchenStaffAssignment>();
    public DbSet<Dish> Dishes => Set<Dish>();
    public DbSet<DailyMenu> DailyMenus => Set<DailyMenu>();
    public DbSet<MealServing> MealServings => Set<MealServing>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                     .SelectMany(e => e.GetForeignKeys()))
        {
            foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        }

        modelBuilder.Entity<WaitingList>()
            .HasOne(w => w.PreferredGroup)
            .WithMany(g => g.WaitingLists)
            .HasForeignKey(w => w.PreferredGroupId);
    }
}