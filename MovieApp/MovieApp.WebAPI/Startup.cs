using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using MovieApp.Core.Helpers;
using MovieApp.Database;
using MovieApp.Mappings;
using MovieApp.Repositories.Implementations;
using MovieApp.Repositories.Interfaces;
using MovieApp.Services;
using MovieApp.Services.Implementations;
using MovieApp.Services.Interfaces;
using Swashbuckle.AspNetCore.Swagger;

namespace MovieApp.WebAPI
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

            //JWT CONFIGURATION
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,

                        ValidIssuer = JWTHelper.Issuer,
                        ValidAudience = JWTHelper.Audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTHelper.SecretKey))
                    };
                });


            // CORS CONFIGURATION
            services.AddCors();

            // SWAGGER CONFIGURATION
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Movie App WebAPI", Version = "v1" });
                c.AddSecurityDefinition("Bearer",
                    new ApiKeyScheme
                    {
                        In = "header",
                        Name = "Authorization",
                        Type = "apiKey"
                    });
                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>> {
                    { "Bearer", Enumerable.Empty<string>() },
                });

            });


            // AUTO MAPPER CONFIGURATION
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options=>options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            //LAZY LOADING CONFIGURAITON
            services.AddDbContext<MovieDBContext>(options =>
                options.UseLazyLoadingProxies()
                        .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning))
                        .UseSqlServer(Configuration.GetConnectionString("MovieAppDB")), ServiceLifetime.Transient);

            // SERVICES DEPENDENCY INJECTION CONDIGURAITON
            services.AddScoped<IMovieService,MovieService>();
            services.AddScoped<IActorService,ActorService>();
            services.AddScoped<IUserService,UserService>();

            // REPOSITORIES DEPENDENCY INJECTION CONDIGURAITON
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<IActorRepository,ActorRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseAuthentication();

            app.UseHttpsRedirection();

            // CORS CONFIGURATION
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            // STATIC FILES CONFIGURATION
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Images")),
                RequestPath = new PathString("/Images")
            });

            app.UseMvc();


            // SWAGGER CONFIG
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieApp API");
            });



        }
    }
}