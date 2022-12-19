using LibraryManagement.Infrastructure.Configuration;
using LibraryManagement.Infrastructure.Engine;
using System.Collections.Generic;

namespace LibraryManagement.Api.Engine
{
    public class ApiConfigurationRegister //: IConfigurationRegister
    {
        #region Properties

        /// <summary>
        /// Gets the Order.
        /// </summary>
        public int Order => 1;

        #endregion

        #region Methods

        /// <summary>
        /// The Configure.
        /// </summary>
        /// <param name="service">The service<see cref="IServiceCollection"/>.</param>
        /// <param name="configuration">The configuration<see cref="IConfiguration"/>.</param>
        public void Configure(IServiceCollection service, IConfiguration configuration)
        {
            var appOptions = new ApplicationOptions();
            configuration.GetSection("ApplicationOptions").Bind(appOptions);
            //service.AddSingleton<IUser<string>>(f => new ApiAppUser { Id = appOptions.ApplicationUser, Name = appOptions.ApplicationName });
        }

        #endregion
    }
}