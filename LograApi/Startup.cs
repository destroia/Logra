using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LograData;
using LograData.Interfaces;
using LograData.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LograApi
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
            services.AddControllers();
            services.AddDbContext<LograDbContext>(

             options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionMain"))
         );
            services.AddScoped<IPrueba, PruebaRepository>();
            services.AddScoped<ILoginData, LoginData>();
            services.AddScoped<IWordData, WordData>();
            services.AddScoped<IQuestionData, QuestionData>();
            services.AddScoped<IMoodData, MoodData>();
            services.AddScoped<IInstutitionData, InstutitionData>();
            services.AddScoped<IGardenData, GardenData>();
            services.AddScoped<IUsersData, UsersData>();
            services.AddScoped<IAnswerData, AnswerData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
