using System;

namespace _6._3_Interfaces_Ext_code_along
{

    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migratrion started at {0}" + DateTime.Now);
            // Details of migrating the database

            _logger.LogInfo("Migratrion finished at {0}" + DateTime.Now);


        }
    }
}
