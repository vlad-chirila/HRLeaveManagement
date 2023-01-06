using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HR.LeaveManagement.Persistence
{
    public class HrLeaveManagementDbContextFactory : IDesignTimeDbContextFactory<HrLeaveManagementDbContext>
    {
        public HrLeaveManagementDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<HrLeaveManagementDbContext>();
            var connectionString = configuration.GetConnectionString("LeaveManagementConnectionString");

            builder.UseSqlServer(connectionString);

            return new HrLeaveManagementDbContext(builder.Options);
        }
    }
}