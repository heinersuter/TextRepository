using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

namespace TextRepository.UI
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            var fileProvider = new PhysicalFileProvider(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "text-repository", "dist"));

            var defaultFilesOptions = new DefaultFilesOptions { FileProvider = fileProvider };
            app.UseDefaultFiles(defaultFilesOptions);

            app.UseStaticFiles(
                new StaticFileOptions
                {
                    FileProvider = fileProvider
                });
        }

        private static void Test()
        {
        }
    }
}
