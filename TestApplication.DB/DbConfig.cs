using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace TestApplication.DB
{
    public class DbConfig : DbConfiguration
    {
        public DbConfig()
        {
            SetDefaultConnectionFactory(new SqlConnectionFactory());
            SetProviderServices("System.Data.SqlClient", SqlProviderServices.Instance);
        }
    }
}
