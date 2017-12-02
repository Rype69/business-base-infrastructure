// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CannotRemoveExceptionTests.cs" company="Ryan Penfold Ltd">
//   Copyright © Ryan Penfold Ltd. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RyanPenfold.BusinessBase.Infrastructure.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Unit tests for <see cref="RyanPenfold.BusinessBase.Infrastructure.CannotRemoveException" />
    /// </summary>
    [TestFixture]
    public class CannotRemoveExceptionTests
    {
        /// <summary>
        /// A message for CannotRemoveExceptions
        /// </summary>
        public const string TestMessage = "Ipsum Lorem";

        /// <summary>
        /// Creates a new instance of CannotRemoveException
        /// </summary>
        [Test]
        public void CreateNewCannotRemoveException()
        {
            // create a new instance
            var exception = new CannotRemoveException(TestMessage);
            
            // test that it//s been instantiated
            Assert.IsNotNull(exception);

            // asserts whether the test exception//s message is equal to the test message
            Assert.AreEqual(TestMessage, exception.Message);        
        }

        /// <summary>
        /// Tests the Message property of the CannotRemoveException class
        /// </summary>
        [Test]
        public void SetMessageInConstructor()
        {
            // get new instance
            var instance = new CannotRemoveException(TestMessage);

            // asserts whether the test exception//s message is equal to the test message
            Assert.AreEqual(TestMessage, instance.Message);        
        }

        /// <summary>
        /// Tests the Message property of the CannotRemoveException class
        /// </summary>
        [Test]
        public void SetMessageInInitializer()
        {
            // get new instance and set the message property
            var instance = new CannotRemoveException(TestMessage) { Message = TestMessage };

            // asserts whether the test exception//s message is equal to the test message
            Assert.AreEqual(TestMessage, instance.Message);
        }
    }
}
