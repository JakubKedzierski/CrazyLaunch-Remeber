using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyRL
{   
    /// <summary>
    /// Class is responsible for handling CRUD operations with database
    /// </summary>
    public class LaunchContext: DbContext
    {   
        /// <summary>
        /// Set of launches 
        /// </summary>
        public DbSet<Launch> launches { get; set; }

        /// <summary>
        /// Defaultr constructor  - it drops database if model changes
        /// 
        /// </summary>
        public LaunchContext(): base("CrazyLaunchRemember Database")
        {
            Database.SetInitializer<LaunchContext>(new DropCreateDatabaseIfModelChanges<LaunchContext>());
        }


        /// <summary>
        /// Configure default procedures for mapped fields
        /// </summary>
        /// <param name="modelBuilder"></param> model builder
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(t => t.MapToStoredProcedures());
        }
    }
}
