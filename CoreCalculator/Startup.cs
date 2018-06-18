using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCalculator.Data;
using CoreCalculator.Models;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CoreCalculator
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<CalcQuery>();
            services.AddTransient<IBasicCalculator, BasicCalculator>();
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();
            services.AddTransient<OperationType>();
            var sp = services.BuildServiceProvider();
            services.AddScoped<ISchema>(_ => new CalcSchema(type => (GraphType)sp.GetService(type)) { Query = sp.GetService<CalcQuery>() });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
