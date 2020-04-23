namespace _3._3_composition_code_along
{
    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;            
        }

        public void Install()
        {
            _logger.Log("We are installing the application.");
        }
    }
}
