using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Entity
{
    public class BaseEntity<TId, TUserId> : IEntity<TId, TUserId>
    {
        #region Properties

        /// <summary>
        /// Gets or sets the CreatedBy.
        /// </summary>
        public TUserId CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public TId Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsActive.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the UpdatedBy.
        /// </summary>
        public TUserId UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the UpdatedDate.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        #endregion
    }
}
