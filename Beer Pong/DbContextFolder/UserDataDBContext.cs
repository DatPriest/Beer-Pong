using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
using Beer_Pong.Classes;


namespace Beer_Pong.DbContextFolder
{
    public class UserDataDBContext : DbContext
    {
        #region Constructor
        public UserDataDBContext(DbContextOptions<UserDataDBContext> options)
            :base(options)
        {

        }
        #endregion

        #region Public properties
        public DbSet<UserData> UserData { get; set; }
        #endregion

        #region Overriden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserData>().HasData(GetUserData());
            base.OnModelCreating(modelBuilder);
        }
        #endregion

        #region Private methods
        private List<UserData> GetUserData()
        {
            return new List<UserData>
            {

            };
        }
        #endregion

    }
}
