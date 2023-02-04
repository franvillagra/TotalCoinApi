using TotalCoinApi.Interfaces;
using TotalCoinApi.Services;

namespace TotalCoinApi
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSwaggerGen();
            services.AddEndpointsApiExplorer();
            services.AddControllers();
            services.AddScoped<IMascotaService, MascotaService>();
            services.AddScoped<IDuenioService, DuenioService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IVendedorService, VendedorService>();
            services.AddScoped<IAutenticacionService, AutenticacionService>();
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();
        }
    }
}
