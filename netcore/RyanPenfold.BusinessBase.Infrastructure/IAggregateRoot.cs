// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAggregateRoot.cs" company="Inspire IT Ltd">
//   Copyright © Inspire IT Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RyanPenfold.BusinessBase.Infrastructure
{
    /// <summary>
    /// Provides a common interface for all business entity types
    /// </summary>
    public interface IAggregateRoot
    {
        /// <summary>
        /// Gets or sets the unique identifier of the object
        /// </summary>
        long Id { get; set; }
    }
}
