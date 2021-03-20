using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyRL
{
    public class LaunchContext: DbContext
    {
        public LaunchContext(): base("CrazyLaunchRemember Database")
        {
            Database.SetInitializer<LaunchContext>(new DropCreateDatabaseIfModelChanges<LaunchContext>());
        }

        public DbSet<Launch> launches { get; set; } 
    }
}
