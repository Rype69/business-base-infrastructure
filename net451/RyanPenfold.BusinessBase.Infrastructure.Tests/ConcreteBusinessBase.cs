// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteBusinessBase.cs" company="Ryan Penfold Ltd">
//   Copyright © Ryan Penfold Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RyanPenfold.BusinessBase.Infrastructure.Tests
{
    using System;

    /// <summary>
    /// A concrete implementation of the Business Base class
    /// </summary>
    public class ConcreteBusinessBase : BusinessBase
    {
        /// <summary>
        /// Determines whether the business domain entity is in valid state.
        /// </summary>
        protected override void Validate()
        {
            if (this.ID == null)
            {
                throw new Exception("Object is not valid.");
            }
        }
    }
}
