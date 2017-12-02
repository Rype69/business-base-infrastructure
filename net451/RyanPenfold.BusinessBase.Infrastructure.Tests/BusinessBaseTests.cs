// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BusinessBaseTests.cs" company="Ryan Penfold Ltd">
//   Copyright © Ryan Penfold Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RyanPenfold.BusinessBase.Infrastructure.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Provides unit tests for the <see cref="RyanPenfold.BusinessBase.Infrastructure.BusinessBase"/> type.
    /// </summary>
    [TestFixture]
    public class BusinessBaseTests
    {
        /// <summary>
        /// Creates a new instance of ConcreteBusinessBase
        /// </summary>
        [Test]
        public void CreateNewBusinessBase()
        {
            // create a new instance of BusinessBase
            var instance = new ConcreteBusinessBase();
            
            // assert the instance is not null
            Assert.IsNotNull(instance);
        }

        /// <summary>
        /// Tests the ID property of the BusinessBase class
        /// </summary>
        [Test]
        public void ID()
        {
            // create a new instance of BusinessBase
            var instance = new ConcreteBusinessBase();
            
            // set a test id constant
            const int TestID = 5;

            // set the id of the instance to test id
            instance.ID = TestID;

            // ensure the property is equal to the constant
            Assert.AreEqual(TestID, instance.ID);
        }
    }
}
