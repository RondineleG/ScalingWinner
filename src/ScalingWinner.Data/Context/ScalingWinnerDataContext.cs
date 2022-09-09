using Microsoft.EntityFrameworkCore;
using ScalingWinner.Core.Entities;

namespace ScalingWinner.Data.Context;

public class ScalingWinnerDataContext : DbContext
{
    public DbSet<Developer> Developers { get; set; }
    public DbSet<Project> Projects { get; set; }

    public ScalingWinnerDataContext(DbContextOptions<ScalingWinnerDataContext> options) : base(options) { }

}