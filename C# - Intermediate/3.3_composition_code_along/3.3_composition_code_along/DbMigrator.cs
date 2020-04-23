namespace _3._3_composition_code_along
{
    public class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating blah blah blah..."); 
        }
    }
}
