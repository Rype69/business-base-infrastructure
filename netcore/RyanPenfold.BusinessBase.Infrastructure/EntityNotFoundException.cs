// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityNotFoundException.cs" company="Inspire IT Ltd">
//   Copyright © Inspire IT Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RyanPenfold.BusinessBase.Infrastructure
{
    using System;

    /// <summary>
    /// Represents an error occurring when attempting to remove an item from a set
    /// </summary>
    public class EntityNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityNotFoundException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        public EntityNotFoundException(string message)
        {
            this.Message = message;
        }        
        
        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        public new string Message { get; set; }
    }
}
