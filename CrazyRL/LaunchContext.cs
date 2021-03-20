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
        public LaunchContext(): base()
        {
            
        }

        public DbSet<Launch> launches { get; set; } 
    }
}
