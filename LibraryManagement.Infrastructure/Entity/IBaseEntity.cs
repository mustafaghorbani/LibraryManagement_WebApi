using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Entity
{
    #region Interfaces

    /// <summary>
    /// Defines the <see cref="IBaseEntity{TId}" />.
    /// </summary>
    /// <typeparam name="TId">.</typeparam>
    public interface IBaseEntity<TId>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        TId Id { get; set; }

        #endregion
    }

    #endregion
}
