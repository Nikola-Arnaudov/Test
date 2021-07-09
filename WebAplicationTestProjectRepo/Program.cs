namespace WebAplicationTestProjectRepo
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    public class Program
    {
        public static void Main(string[] args)
            => CreateHostBuilder(args).Build().Run();



        //Try to add new commit
        public static IHostBuilder CreateHostBuilder(string[] args)
            => Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>webBuilder
                    .UseStartup<Startup>());
    }
}
