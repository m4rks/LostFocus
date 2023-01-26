using LostFocus.ViewModels;
using LostFocus.ViewModels.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LostFocus
{
    public partial class App : Application
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _navigationStore = new NavigationStore();
            var serviceCollection = new ServiceCollection();

            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();

            services.AddScoped<MainViewModel>();

            services.AddSingleton<NavigationStore>();

            //add additional services here:

            services.AddSingleton<IFirstChildViewModel, FirstChildViewModel>();

            services.AddSingleton<ISecondChildViewModel, SecondChildViewModel>();

        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();

            mainWindow.DataContext = _serviceProvider.GetService<MainViewModel>();

            mainWindow.Show();
        }
    }
}
