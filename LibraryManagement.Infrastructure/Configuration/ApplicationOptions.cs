using System;

namespace LibraryManagement.Infrastructure.Configuration
{
    /// <summary>
    /// Defines the <see cref="ApplicationOptions" />.
    /// </summary>
    [Serializable]
    public class ApplicationOptions
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ApplicationId.
        /// </summary>
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the ApplicationName.
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets the ApplicationUser.
        /// </summary>
        public string ApplicationUser { get; set; }

        /// <summary>
        /// Gets or sets the NumberOfDatabaseRetries.
        /// </summary>
        public int NumberOfDatabaseRetries { get; set; }

        #endregion
    }
}
