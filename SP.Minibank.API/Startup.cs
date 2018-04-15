using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SP.Minibank.Domain.Handlers;
using SP.Minibank.Domain.Repositories;
using SP.Minibank.Domain.Services;
using SP.Minibank.Infra.MinibankContext.DataContexts;
using SP.Minibank.Infra.MinibankContext.Repositories;
using SP.Minibank.Infra.MinibankContext.Services;
using Microsoft.Extensions.Configuration;
using System.IO;
using SP.Minibank.Shared;

namespace SP.Minibank.API
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();


            services.AddMvc();

            services.AddResponseCompression();

            services.AddScoped<DataContext, DataContext>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<CustomerHandler, CustomerHandler>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<AccountHandler, AccountHandler>();
            

            Settings.ConnectionString = $"{Configuration["connectionString"]}";

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }

            app.UseMvc();
            app.UseResponseCompression();
        }
    }
}
