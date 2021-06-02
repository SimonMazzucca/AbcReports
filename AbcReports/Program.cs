using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbcReports
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ///Generate Host Builder and Register the Services for DI
            IHostBuilder builder = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddDbContext<ABCReportsContext>(options =>
                   {
                       options.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=ABCReports;Trusted_Connection=True;");
                   });
               });

            IHost host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var logg = services.GetRequiredService<ILogger<LoginForm>>();
                    var employeeContext = services.GetRequiredService<ABCReportsContext>();
                    Application.Run(new LoginForm(employeeContext));

                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occured: {0}", ex.Message);
                }
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
        }
    }
}
