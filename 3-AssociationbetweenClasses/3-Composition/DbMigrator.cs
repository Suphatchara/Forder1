namespace Composition
{
    public class DbMigrator
    {
        private readonly Logger _logger;
        public DbMigrator(Logger logger)
        {

        }
       
        public void Migrate()
        {
            _logger.Log("We are migratig blah blah blah...");


        }

    }
}
