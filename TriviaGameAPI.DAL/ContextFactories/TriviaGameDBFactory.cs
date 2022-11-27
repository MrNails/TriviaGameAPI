using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriviaGameAPI.DAL.Repositories;

namespace TriviaGameAPI.DAL.ContextFactories
{
    internal class TriviaGameDBFactory : IDesignTimeDbContextFactory<TriviaGameDBContext>
    {
        public TriviaGameDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TriviaGameDBContext>();
            optionsBuilder.UseSqlServer("data source=DESKTOP-U6JULRK;initial catalog=TriviaGameDB;integrated security=true;Persist Security Info=true;MultipleActiveResultSets=True;TrustServerCertificate=true;MultiSubnetFailover=True") ;

            return new TriviaGameDBContext(optionsBuilder.Options);
        }
    }
}
