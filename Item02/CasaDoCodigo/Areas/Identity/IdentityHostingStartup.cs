using System;
using CasaDoCodigo.Areas.Identity.Data;
using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CasaDoCodigo.Areas.Identity.IdentityHostingStartup))]
namespace CasaDoCodigo.Areas.Identity
{
    //PRECISAMOS TRADUZIR AS MENSAGENS DE ERRO DE SENHAS:

    //ORIGINAL:
    //=========
    //Passwords must have at least one non alphanumeric character.
    //Passwords must have at least one lowercase('a' - 'z').
    //Passwords must have at least one uppercase('A' - 'Z').

    //PT-BR:
    //=========
    //A senha deve ter pelo menos um caractere alfanumérico.
    //A senha deve ter pelo menos uma letra minúscula('a' - 'z').
    //A senha deve ter pelo menos uma letra minúscula('a' - 'z').
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AppIdentityContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("AppIdentityContextConnection")));

                #region Traduzir erros
                //TAREFA:  
                //IMPLEMENTAR UMA NOVA CLASSE
                //DESCRITORA DE ERROS
                //EM PORTUGUÊS 
                #endregion
                services.AddDefaultIdentity<AppIdentityUser>()
                    .AddEntityFrameworkStores<AppIdentityContext>();
            });
        }
    }
}