using LibraryManagement.Infrastructure.Engine;
using LibraryManagement.Infrastructure.Repository;
using LibraryManagement.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlTypes;

namespace LibraryManagement.Repository.Engine
{
    public class RepositoryConfigurationRegister : IConfigurationRegister
    {
        /// <summary>
        /// Gets the Order.
        /// </summary>
        public int Order => 0;

        public void Configure(IServiceCollection service, IConfiguration configuration)
        {
            var setting = GetSetting(configuration);
            service.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(setting.ConnectionString));
            service.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            service.AddScoped<IUnitOfWork, UnitOfWork>();
            service.AddScoped<IBookRepository, BookRepository>();
            service.AddScoped<IMemberRepository, MemberRepository>();
            service.AddScoped<IBookTransactionRepository, BookTransactionRepository>();
            service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        }

        /// <summary>
        /// The Getoption.
        /// </summary>
        /// <param name="configuration">The configuration<see cref="IConfiguration"/>.</param>
        /// <returns>The <see cref="SettingOptions"/>.</returns>
        private ApplicationRepositorySetting GetSetting(IConfiguration configuration)
        {
            ApplicationRepositorySetting setting = new ApplicationRepositorySetting();
            var section = configuration.GetSection("ApplicationRepositorySetting");
            section.Bind(setting);
            Validate(setting);

            return setting;
        }

        /// <summary>
        /// The Validate.
        /// </summary>
        /// <param name="setting">The setting<see cref="RepositorySetting"/>.</param>
        private void Validate(ApplicationRepositorySetting setting)
        {
            if (setting == default(ApplicationRepositorySetting) || string.IsNullOrEmpty(setting.ConnectionString))
            {
                throw new SqlNullValueException("DB connection not found!");
            }
        }


    }
}
