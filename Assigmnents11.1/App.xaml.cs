using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Books
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddDbContext<Data.BookContext>(options =>
            {
                options.UseSqlite("Data Source=books.db");
            });
            services.AddSingleton<MainWindow>();
            _serviceProvider = services.BuildServiceProvider();
        }
        private void OnStartUp(Object sender,StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }

}
