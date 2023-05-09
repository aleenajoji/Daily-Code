using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MigrationinEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext() : base("SchoolDBConnectionString")
        {
            Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());

            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public object Database { get; }
    }
    public class SchoolDBInitializer : CreateDatabaseIfNotExists<SchoolDBContext>
    {
        protected override void Seed(SchoolDBContext context)
        {
            base.Seed(context);
        }
    }

}
