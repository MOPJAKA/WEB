using WEB.Config.Interfaces;

namespace WEB.Config.Implimintation
{
    public class HostConfige : IHostConfige
    {
        private readonly IConfiguration _configuration;

        public HostConfige(IConfiguration configuration)
        {
           _configuration = configuration;
        }
        public string ConnectionString => _configuration.GetConnectionString("default");


    }
}
