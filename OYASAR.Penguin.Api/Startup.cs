using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using OYASAR.Framework.Core.Interface;
using OYASAR.Framework.Core.Manager;
using OYASAR.Framework.NetCoreIoc;
using OYASAR.Framework.Utils.Helper;
using OYASAR.Penguin.Api.Helper;

namespace OYASAR.Penguin.Api
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

            ServicesRegister(services);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidAudience = "onuryasar.org",
                    ValidateIssuer = true,
                    ValidIssuer = "onuryasar.org",
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes("uzun ince bir yoldayım şarkısını buradan tüm sevdiklerime hediye etmek istiyorum mümkün müdür acaba?"))
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            NetCoreIocManager.Instance.SetServiceProvider(serviceProvider);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseMvc();
        }


        public void ServicesRegister(IServiceCollection services)
        {
            NetCoreIocManager.Instance.Initialize(services);

            var actions = new Action[3];

            actions[0] = delegate
            {
                IocManager.Instance.RegisterTransient(IocHelper.TypeInterface, IocHelper.TypeImplementation);
            };

            actions[1] = delegate { IocManager.Instance.RegisterSingleton(IocHelper.TypeInterface, IocHelper.TypeImplementation); };


            actions[2] = delegate { IocManager.Instance.RegisterScoped(IocHelper.TypeInterface, IocHelper.TypeImplementation); };


            IocHelper.RegisterIntefaceBasedTypes<IDependency, ITransientDependency,

                ISingletonDependency, IScopedDependency>(actions, DomainHelper.BaseDirForDll);

        }
    }
}
