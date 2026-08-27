using Microsoft.EntityFrameworkCore;

namespace Abiturient
{
    public class Abiturient
    {
        public Guid id {  get; set; }
        public string name { get; set; }
    }

    public class AbiturientDb : DbContext
    {
        public AbiturientDb(DbContextOptions options) : base(options) { }
        public DbSet<Abiturient> Abiturients { get; set; } = null!;
    }
}
